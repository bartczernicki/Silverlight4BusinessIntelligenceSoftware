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

namespace Chapter6_WordSizedBarCharts
{
    public class GoalDiff
    {
        public DateTime Date { get; set; }

        public int Diff { get; set; }

        public SolidColorBrush Brush 
        {
            get
            {
                if (this.Diff < 0)
                {
                    return new SolidColorBrush { Color = Colors.Red };
                }
                else if (this.Diff > 0)
                {
                    return new SolidColorBrush { Color = Colors.Green };
                }
                else
                {
                    return new SolidColorBrush { Color = Colors.Black };
                }
            }
        }
    }
}
