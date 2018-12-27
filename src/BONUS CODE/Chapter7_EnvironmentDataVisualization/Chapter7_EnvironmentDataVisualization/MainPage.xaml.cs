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
using System.Windows.Controls.DataVisualization.Charting;

namespace Chapter7_EnvironmentDataVisualization
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            ((BarSeries)this.ChartVisual.Series[0]).ItemsSource =
            new KeyValuePair<string, double>[]{
                new KeyValuePair<string, double>("Clothes", .7),
                new KeyValuePair<string, double>("Shoes", 0.6),
                new KeyValuePair<string, double>("School Supplies", 0.5),
                new KeyValuePair<string, double>("Cell Phones", 0.2),
                new KeyValuePair<string, double>("Other", 0.10)
            };
        }
    }
}
