using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Chapter3_PersistingLocalData
{
    public partial class MainPage : UserControl
    {
        List<string> names = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLoadFromService_Click(object sender, RoutedEventArgs e)
        {
            this.names = this.loadNamesDataFromService();

            MessageBox.Show("Number of names loaded from service: " + this.names.Count.ToString());
        }

        private void btnLoadDataFromCacheThenService_Click(object sender, RoutedEventArgs e)
        {
            this.names = loadNamesDataFromCacheThanService();

            MessageBox.Show("Number of names loaded from cache: " + this.names.Count.ToString());
        }

        private void btnSaveDataToIsolatedStorage_Click(object sender, RoutedEventArgs e)
        {
            LocalCacheManager.CurrentLocalCacheManager().SaveToIsolatedStorage<List<string>>("names", this.names);
        }

        private void btnLoadDataFromIsolatedStorageCache_Click(object sender, RoutedEventArgs e)
        {
            // reset the names collection
            this.names = null;
            this.names = LocalCacheManager.CurrentLocalCacheManager().GetFromIsolatedStorage<List<string>>("names");

            MessageBox.Show("Number of names loaded from Isolated Storage: " + this.names.Count.ToString());
        }

        private List<string> loadNamesDataFromService()
        {
            // simulate an expensive service call
            System.Threading.Thread.Sleep(700);

            return new List<string> { "Joe", "Bob", "Ron", "Andrew", "Shane" };
        }

        private List<string> loadNamesDataFromCacheThanService()
        {
            this.names = LocalCacheManager.CurrentLocalCacheManager().GetCacheItem<List<string>>("names");

            if (this.names == null)
            {
                this.names = this.loadNamesDataFromService();
                LocalCacheManager.CurrentLocalCacheManager().AddCacheItem("names", this.names);
            }

            return this.names;
        }
    }
}
