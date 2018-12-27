using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;


namespace Chapter3_PersistingLocalData
{
    public class LocalCacheManager
    {
        // local cache
        public static LocalCacheManager localCache = new LocalCacheManager();
        // dictionary of cache
        private readonly IDictionary<string, object> cacheDictionary = new Dictionary<string, object>();
        // local cache manager folder
        private const string localCacheMangerFolder = "LocalCacheManager";

        // private constructor
        private LocalCacheManager()
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                // create the local cache manager folder
                if (!isf.DirectoryExists(localCacheMangerFolder))
                {
                    isf.CreateDirectory(localCacheMangerFolder);
                }

                // load the files from the Isolated Storage Cache
                string[] fileNames = isf.GetFileNames(localCacheMangerFolder + @"\*");

                for (int i = 0; i != fileNames.Length; i++)
                {
                    this.cacheDictionary.Add(fileNames[i], null);
                }
            }
        }

        public void AddCacheItem(string key, object value)
        {
            if (this.cacheDictionary.ContainsKey(key))
            {
                this.cacheDictionary.Remove(key);
            }

            this.cacheDictionary.Add(key, value);
        }

        public T GetCacheItem<T>(string key) where T : class
        {
            if (this.cacheDictionary.ContainsKey(key))
            {
                return (T)this.cacheDictionary[key];
            }
            else
            {
                return null;
            }
        }

        public T GetCacheItem<T>(string key, bool checkIsolatedStorage) where T : class
        {
            if (this.cacheDictionary.ContainsKey(key))
            {
                return (T)this.cacheDictionary[key];
            }

            else
            {
                return (T)this.GetFromIsolatedStorage<T>(key);
            }
        }

        public static LocalCacheManager CurrentLocalCacheManager()
        {
            return localCache;
        }

        public void Clear(bool includeIsolatedStorage)
        {
            this.cacheDictionary.Clear();

            // remove the local cache manager
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isf.DirectoryExists(localCacheMangerFolder))
                {
                    string[] fileNames = isf.GetFileNames(localCacheMangerFolder + @"\*");

                    for (int i = 0; i != fileNames.Length; i++)
                    {
                        isf.DeleteFile(localCacheMangerFolder + @"\" + fileNames[i]);
                    }
                }
            }
        }

        public bool Clear(string key)
        {
            bool remove = this.cacheDictionary.Remove(key);

            return remove;
        }

        public bool Clear(string key, bool includeIsolatedStorage)
        {
            bool remove = this.cacheDictionary.Remove(key);

            // remove the local cache manager
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                isf.DeleteFile(localCacheMangerFolder + @"\" + key);
            }

            return remove;
        }

        public bool Exists(string key)
        {
            return this.cacheDictionary.ContainsKey(key);
        }

        public void SaveToIsolatedStorage<T>(string fileName, T objectToSave)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream isfs = isf.OpenFile(localCacheMangerFolder + @"\" + fileName, FileMode.Create))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                    serializer.WriteObject(isfs, objectToSave);
                }
            }
        }

        public T GetFromIsolatedStorage<T>(string fileName)
        {
            T obj = default(T);

            string localStorageFullName = localCacheMangerFolder + @"\" + fileName;

            using (IsolatedStorageFile appStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (appStore.FileExists(localStorageFullName))
                {
                    using (IsolatedStorageFileStream isfs = appStore.OpenFile(localStorageFullName, FileMode.Open))
                    {
                        DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                        obj = (T)serializer.ReadObject(isfs);
                    }
                }
            }

            return obj;
        }

        public IDictionary<string, object> CacheDictionary
        {
            get { return this.cacheDictionary; }
        }
    }
}

