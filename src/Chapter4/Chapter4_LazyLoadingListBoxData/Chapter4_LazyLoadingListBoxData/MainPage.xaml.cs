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
using Expression.Blend.SampleData.SampleDataSource;


namespace Chapter4_LazyLoadingListBoxData
{
    public partial class MainPage : UserControl
    {
		SampleDataSource data = new SampleDataSource();
		int page = 1;
		
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			this.bindData();
        }
		
		private void bindData()
		{
			this.lstCompanies.ItemsSource = data.Companies.Take(10*page);
		}

		private void Thumb_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
            // cast the sender as the thumb
            FrameworkElement thumb = sender as FrameworkElement;
            // retrieve the actual height & width of the thumb (rounded)
            double thumbHeight = thumb.ActualHeight;
            double thumbWidth = thumb.ActualWidth;

            // retrieve the thumb parent
            UIElement thumbParent = thumb.Parent as UIElement;

            // define the increase button height and default value
            double increaseButtonHeight = 16.0;
            // define the increase button height and default value
            double increaseButtonWidth = 16.0;
            // define the increase button top margin and default value
            double increaseButtonMarginTop = 1.0;
            // define the increase button bottom margin and default value
            double increaseButtonMarginBottom = 1.0;

            // retrieve parent control of the thumb control (grid)
            FrameworkElement thumbParentFrameworkElement = thumb.Parent as FrameworkElement;

            // retrieve the root control
            FrameworkElement root = thumbParentFrameworkElement.Parent as FrameworkElement;

            // retrieve the scrollbar control
            FrameworkElement scrollBar = root.Parent as FrameworkElement;

            // Find the relative postion of the thumb to the scroll grid (parent)
            GeneralTransform gt = thumb.TransformToVisual(thumb.Parent as UIElement);
            Point p = gt.Transform(new Point(0, 0));

            // Check if ListBox is vertical
            if (thumbParentFrameworkElement.Name == "VerticalRoot")
            {
                FrameworkElement verticalSmallIncrease =
                    thumbParentFrameworkElement.FindName("VerticalSmallIncrease") as FrameworkElement;
                increaseButtonHeight = verticalSmallIncrease.Height;
                increaseButtonMarginTop = verticalSmallIncrease.Margin.Top;
                increaseButtonMarginBottom = verticalSmallIncrease.Margin.Bottom;

                // if the thumb has reached the bottom of the list
                // increase the page number shown
                // re-bind the data
                if (p.Y + thumbHeight + increaseButtonHeight + increaseButtonMarginTop + increaseButtonMarginBottom == thumbParentFrameworkElement.RenderSize.Height)
                {
                    this.page++;
                    this.bindData();
                }
            }
            else // if listBox is horizontal
            {
                FrameworkElement horizontalSmallIncrease =
                    thumbParentFrameworkElement.FindName("HorizontalSmallIncrease") as FrameworkElement;
                increaseButtonHeight = horizontalSmallIncrease.Height;
                increaseButtonMarginTop = horizontalSmallIncrease.Margin.Top;
                increaseButtonMarginBottom = horizontalSmallIncrease.Margin.Bottom;

                // if the thumb has reached the max width of the list
                // increase the page number shown
                // re-bind the data
                if (p.X + thumbWidth + increaseButtonWidth + increaseButtonMarginTop + increaseButtonMarginBottom == thumbParentFrameworkElement.RenderSize.Width)
                {
                    this.page++;
                    this.bindData();
                }
            }
		}
    }
}
