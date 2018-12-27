using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chapter6_Sparklines
{
    public class PopularityPoll
    {
        /// <summary>
        /// Gets or sets the date on which the poll was taken.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the percentage of support the thing had.
        /// </summary>
        public double Percent { get; set; }
    }
}