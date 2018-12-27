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

namespace CrossTab
{
    public class Hits
    {
        /// <summary>
        /// Gets or sets the date on which the poll was taken.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the amount of hits
        /// </summary>
        public double NumberOfHits { get; set; }

        public Region HitRegion { get; set; }
    }

    public enum Region
    {
        USA,
        Europe,
        Other
    }
}
