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

namespace Chapter6_TrendAnalysis
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            ((LineSeries)MutualFunds.Series[0]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 100.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 110.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), 130.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), 133.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), 135.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), 146.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), 144.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 142.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 140.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 133.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 133.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 132.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 136.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 143.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 142.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 140.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 137.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 133.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 128.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 125.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 123.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 122.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 124.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 126.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 127.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 128.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 128.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 129.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 130.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 132.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 132.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 131.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 133.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 134.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 135.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 140.0)
            };


            ((LineSeries)MutualFunds.Series[1]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 50.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 52.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), 54.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), 54.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), 54.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), 56.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), 58.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 56.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 56.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 57.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 57.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 60.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 61.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 62.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 64.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 63.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 62.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 66.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 68.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 66.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 65.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 65.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 66.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 63.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 62.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 64.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 66.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 68.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 70.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 72.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 68.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 67.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 62.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 65.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 64.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 63.0)
            };


            ((LineSeries)MutualFunds.Series[2]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), 24.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), 23.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), 23.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), 24.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), 24.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 25.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 26.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 27.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 28.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 30.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 31.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 32.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 31.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 32.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 32.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 33.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 34.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 34.0),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 35.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 36.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 36.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 37.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 39.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 39.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 40.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 41.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 42.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 42.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 43.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 44.0),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 45.0)
            };

            ((LineSeries)MutualFundsStandardized.Series[0]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 0.1),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), 0.3),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), 0.33),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), 0.35),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), 0.46),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), 0.44),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 0.42),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 0.40),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 0.33),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 0.33),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 0.43),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 0.42),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 0.4),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 0.37),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 0.33),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 0.25),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 0.23),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 0.22),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 0.26),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 0.27),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 0.29),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 0.30),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 0.31),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 0.33),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 0.34),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 0.35),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 0.4)
            };


            ((LineSeries)this.MutualFundsStandardized.Series[1]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 0.04),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), 0.08),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), 0.08),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), 0.08),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), 0.12),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), 0.16),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 0.12),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 0.12),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 0.14),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 0.14),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 0.20),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 0.22),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 0.26),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 0.3),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 0.3),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 0.26),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 0.40),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 0.44),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 0.34),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 0.30),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 0.26)
            };

            ((LineSeries)this.MutualFundsStandardized.Series[2]).ItemsSource =
new KeyValuePair<DateTime, double>[]{
            new KeyValuePair<DateTime, double>(new DateTime(1999, 1, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 2, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 3, 1), -.04),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 4, 1), -.08),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 5, 1), -.08),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 6, 1), -.04),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 7, 1), -.04),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 8, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 9, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 10, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 11, 1), 0.0),
            new KeyValuePair<DateTime, double>(new DateTime(1999, 12, 1), 0.04),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 1, 1), 0.08),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 2, 1), 0.12),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 3, 1), 0.20),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 4, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 5, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 6, 1), 0.24),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 7, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 8, 1), 0.28),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 9, 1), 0.32),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 10, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 11, 1), 0.36),
            new KeyValuePair<DateTime, double>(new DateTime(2000, 12, 1), 0.40),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 1, 1), 0.44),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 2, 1), 0.44),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 3, 1), 0.48),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 4, 1), 0.56),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 5, 1), 0.56),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 6, 1), 0.60),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 7, 1), 0.64),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 8, 1), 0.68),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 9, 1), 0.68),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 10, 1), 0.72),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 11, 1), 0.76),
            new KeyValuePair<DateTime, double>(new DateTime(2001, 12, 1), 0.8)
            };
        }
    }
}
