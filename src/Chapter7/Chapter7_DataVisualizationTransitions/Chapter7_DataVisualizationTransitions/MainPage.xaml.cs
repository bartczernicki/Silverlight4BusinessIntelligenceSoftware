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

namespace Chapter7_DataVisualizationTransitions
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // add event handler to trigger method when initial animation is completed
            this.SbFlip.Completed += new EventHandler(SbFlip_Completed);
        }

        private void ButtonFlip_Click(object sender, RoutedEventArgs e)
        {
            this.SbFlip.Begin();
        }

        void SbFlip_Completed(object sender, EventArgs e)
        {
            // change the visibility of the chart
            if (this.BarChart.Visibility == Visibility.Collapsed)
            {
                this.PieChart.Visibility = Visibility.Collapsed;
                this.BarChart.Visibility = Visibility.Visible;
            }
            else
            {
                this.PieChart.Visibility = Visibility.Visible;
                this.BarChart.Visibility = Visibility.Collapsed;
            }

            // flip the panel back
            this.SbFlipBack.Begin();
        }
    }
}
