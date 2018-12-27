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

namespace Chapter8_WorkingWithTheRatingControl
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // bind the list to the set of movies
            this.listMovies.ItemsSource = this.GetListOfMovies();
        }

        public IList<Movie> GetListOfMovies()
        {
            // returns a list of fictitious Movies
            return new List<Movie> { 
        new Movie { MovieName = "Viva Silverlight", AverageRating = 0.5, RatingsCount = 1332 },
        new Movie { MovieName = "Collective Intelligence Returns", AverageRating = 0.25, RatingsCount = 3 },
        new Movie { MovieName = "RIA Raiders", AverageRating = 0.75, RatingsCount = 3500 },
        new Movie { MovieName = "Flash of RIA", AverageRating = 0.6, RatingsCount = 343343 },
        new Movie { MovieName = "Weekend at Silverlight 3", AverageRating = 0.4, RatingsCount = 4 }
    };
        }

        private void AverageRating_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<System.Nullable<double>> e)
        {
            // check to make sure this is not the initial binding
            if (e.OldValue != null)
            {
                // retrieve the rating control
                Rating ratingControl = sender as Rating;
                // define the amount of ratings
                int rateCount = 0;

                StackPanel panel = ratingControl.Parent as StackPanel;
                StackPanel panelParent = panel.Parent as StackPanel;

                // iterate over the parent to
                // access the second RatingCount stack panel
                for (int i = 0; i != panelParent.Children.Count; i++)
                {
                    // cast the panel to a FrameworkElement to access name property
                    FrameworkElement element = (FrameworkElement)panelParent.Children[i];

                    if (element.Name == "RatingCountPanel")
                    {
                        StackPanel ratingCountPanel = (StackPanel)element;

                        // retrieve the value from the RateCount text box
                        for (int j = 0; j != ratingCountPanel.Children.Count; j++)
                        {
                            // cast the panel to a FrameworkElement
                            TextBlock textBlock = (TextBlock)ratingCountPanel.Children[j];

                            if (textBlock.Name == "RatingsCount")
                            {
                                // retrieve count 
                                rateCount = Convert.ToInt32(textBlock.Text);

                                // remove the value changed event handler
                                ratingControl.ValueChanged -= this.AverageRating_ValueChanged;

                                // calculate the rating
                                ratingControl.Value = ((rateCount * e.OldValue) + e.NewValue) / (rateCount + 1);

                                // update the count and increment it by one (user's vote)
                                textBlock.Text = (rateCount + 1).ToString();

                                // thank the user for the vote
                                MessageBox.Show("Thank you for your vote", "Vote Confirmation", MessageBoxButton.OK);
                            }
                        }
                    }
                }

                // mark the control as read-only
                ratingControl.IsReadOnly = true;
                // set the curor to arrow (let's user know that action is not possible)
                ratingControl.Cursor = Cursors.Arrow;
                // set the transperancy to 0.6
                ratingControl.Opacity = 0.6;
            }
        }
    }
}