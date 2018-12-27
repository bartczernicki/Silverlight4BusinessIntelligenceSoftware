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
using System.Collections.ObjectModel;

namespace Chapter9_ImplentingPredictiveAnalytics
{
    public partial class MainPage : UserControl
    {
        ObservableCollection<ProbabilityResults> results;

        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.calculateProbability();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            this.calculateProbability();
        }

        private void SliderNumberOfHits_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.calculateProbability();
        }

        private void calculateProbability()
        {
            int numberOfHits = Convert.ToInt32(this.NumberOfHits == null ? "200" : this.NumberOfHits.Text);
            double mean = Convert.ToDouble(numberOfHits) / Convert.ToDouble(162);

            this.results =
                    new ObservableCollection<ProbabilityResults>{
                    new ProbabilityResults{ NumberOfEvents = 0, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 0)},
                    new ProbabilityResults{ NumberOfEvents = 1, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 1)},
                    new ProbabilityResults{ NumberOfEvents = 2, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 2)},
                    new ProbabilityResults{ NumberOfEvents = 3,
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 3)},
                    new ProbabilityResults{ NumberOfEvents = 4, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 4)},
                    new ProbabilityResults{ NumberOfEvents = 5, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 5)},
                    new ProbabilityResults{ NumberOfEvents = 6, 
                        ProbabilityOfSuccess = MathHelper.CalculatePoissonProbability(mean, 6)}
                };

            this.DataContext = this.results;
        }
    }
}
