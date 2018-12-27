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
using System.Threading;

namespace Chapter3_WorkingWithBusinessData
{
    public partial class MainPage : UserControl
    {
        // create a list that will hold the person items
        List<Person> people = new List<Person>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGenerateData_Click(object sender, RoutedEventArgs e)
        {
            // start the timer
            DateTime dateStart = DateTime.Now;

            int numberOfRecordsToGenerate = Convert.ToInt32(this.numberOfRecordsToGenerate.Text);

            // clear the list
            this.people.Clear();

            // iterate through list and add Person objects
            for (int i = 0; i != 1000000; i++)
            {
                Random randWeight = new Random(DateTime.Now.Millisecond);
                int weight = randWeight.Next(85, 320);

                Random randHeight = new Random(DateTime.Now.Second * 100 + DateTime.Now.Millisecond);
                int height = randHeight.Next(5, 8);

                Person person = new Person
                {
                    ID = i + 1,
                    Weight = weight,
                    Height = height
                };

                people.Add(person);
            }

            // show message when processing is complete
            this.btnGenerateData.Content = "Data Generated.  Click again to regenerate.";

            // calculate the length of analysis time and set it
            this.dataGeneratedInPerformedIn.Content = DateTime.Now.Subtract(dateStart).TotalMilliseconds.ToString();
        }

        private void btnPerformAnalysis_Click(object sender, RoutedEventArgs e)
        {
            // start the timer
            DateTime dateStart = DateTime.Now;

            // generate people iterator with BMI calculation
            var peoplewithBMI = (
            from p in people
            select new { ID = p.ID, BMI = p.Weight * 4.88 / (p.Height * p.Height) }
            );

            // calculate the min, max, average BMI's
            var minBMI = peoplewithBMI.Min(a => a.BMI);
            var maxBMI = peoplewithBMI.Max(a => a.BMI);
            var averageBMI = peoplewithBMI.Average(a => a.BMI);

            // calculate the count of people who are considered obese (BMI > 30)
            var countOfPeopleWithObeseBMI = peoplewithBMI.Count(a => a.BMI > 30);

            // round and set the appropriate labels on the controls
            this.bmiMinimum.Content = Math.Round(minBMI, 2).ToString();
            this.bmiMaximum.Content = Math.Round(maxBMI, 2).ToString();
            this.bmiAverage.Content = Math.Round(averageBMI, 2).ToString();
            this.bmiObeseCount.Content = countOfPeopleWithObeseBMI.ToString();

            // calculate the length of analysis time and set it
            this.performedAnalysisIn.Content = DateTime.Now.Subtract(dateStart).Milliseconds.ToString() + " ms";
        }

        private List<Person> CreatePersons(int start, int numberOfPersons)
        {
            // number of person to genereate = seed point + number to generate
            numberOfPersons += start;
            // create a locally scoped collection
            List<Person> personList = new List<Person>(numberOfPersons);

            // add the people to the list
            for (int i = start; i != numberOfPersons; i++)
            {
                Random rand = new Random(i);

                int weight = rand.Next(85, 320);
                int height = rand.Next(5, 8);

                Person person = new Person
                {
                    ID = i + 1,
                    Weight = weight,
                    Height = height
                };
                personList.Add(person);
            }

            // return the list of Person objects
            return personList;
        }

        private void btnConcurrentGenerateData_Click(object sender, RoutedEventArgs e)
        {
            // start the timer
            DateTime dateStart = DateTime.Now;

            // retrieve number of records to generate from the text box
            int numberOfRecordsToGenerate =
                Convert.ToInt32(this.numberOfRecordsToGenerate.Text);
            // retrieve number of threads to generate
            int numberOfThreadsToGenerate =
                Convert.ToInt32(this.numberOfThreadsToUse.Text);


            this.people = new List<Person>(numberOfRecordsToGenerate);

            // STEP ONE
            // create a list of AutoResetEvents
            // We are going to queue two worker threads, therefore
            AutoResetEvent[] autoEvents = new AutoResetEvent[numberOfThreadsToGenerate];

            // add a list of auto reset events
            for (int i = 0; i != autoEvents.Length; i++)
            {
                autoEvents[i] = new AutoResetEvent(false);
            }


            // STEP TWO
            // create a second thread to manage the data generation process
            new Thread(new ThreadStart(delegate
            {
                // STEP THREE

                // determine how many records to place on each thread
                int numberOfRecrodsToGenerateForEachThread =
                    numberOfRecordsToGenerate / numberOfThreadsToGenerate;

                // Queue worker thread from ThreadPool.
                // using the ThreadPool is a good practice, not to overwhelm
                // the environment with too many threads
                // Queue the appropriate number of worker threads
                for (int j = 0; j != numberOfThreadsToGenerate; j++)
                {
                    // add this to the delegate closure
                    int currentThreadNumber = j;

                    ThreadPool.QueueUserWorkItem(
                        delegate(object o)
                        {
                            // process the appropriate subset
                            this.people.AddRange(CreatePersons(
                                // calculate the starting point
                                (numberOfRecordsToGenerate / (currentThreadNumber + 1)) * currentThreadNumber,
                                // pass in the number of records to generate for each thread
                                numberOfRecrodsToGenerateForEachThread)
                                );
                            // set the AutoResetEvent to signal process is complete
                            autoEvents[currentThreadNumber].Set();
                        }
                    );
                }


                // STEP FOUR
                // This blocks the current thread (the second one)
                // Thread is blocked until all the queued worker items complete
                WaitHandle.WaitAll(autoEvents);

                // STEP FIVE
                // Dispatch that the processing has finished
                // This has to be done on the UI thread
                this.Dispatcher.BeginInvoke(delegate
                {
                    this.btnConcurrentGenerateData.Content = "Data Generated concurrently.  Click again to regenerate.";
                    // calculate the length of analysis time and set it
                    this.concurrentDataGeneratedInPerformedIn.Content = DateTime.Now.Subtract(dateStart).TotalMilliseconds.ToString();
                });

            })).Start();
        }
    }
}
