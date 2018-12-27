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

namespace Chapter6_ReferenceLine
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            ((LineSeries)this.HRs.Series[0]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 15), 0),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 16), 1),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 17), 1),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 18), 2),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 19), 2),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 20), 2),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 21), 3),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 22), 3),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 23), 4),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 25), 5),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 26), 7),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 27), 7),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 28), 8),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 29), 10),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 30), 10),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 1), 10),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 2), 11),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 3), 11),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 4), 11),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 5), 12),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 6), 12),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 7), 13),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 8), 13),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 9), 13),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 10), 14),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 11), 15),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 12), 16),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 13), 16),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 14), 16),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 15), 16),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 16), 17)
            };


            ((LineSeries)this.HRs.Series[1]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 15), 50),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 16), 50)
            };

            ((LineSeries)this.HRs.Series[2]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(2009, 4, 15), 9),
            new KeyValuePair<DateTime, double>(new DateTime(2009, 5, 16), 9)
            };
        }
    }
}
