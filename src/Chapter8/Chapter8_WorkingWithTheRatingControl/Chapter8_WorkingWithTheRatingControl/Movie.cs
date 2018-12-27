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

namespace Chapter8_WorkingWithTheRatingControl
{
    public class Movie
    {
        public string MovieName { get; set; }
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
    }
}
