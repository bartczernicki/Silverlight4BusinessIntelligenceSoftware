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

namespace Chapter3_WorkingWithBusinessData
{
    public partial class MainPage : UserControl
    {
        List<Person> people = new List<Person>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGenerateData_Click(object sender, RoutedEventArgs e)
        {
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
            this.btnGenerateData.Content = "Data Generated. Click again to regenerate.";
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

            // calculate the min, max, and average BMIs
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
    }
}
