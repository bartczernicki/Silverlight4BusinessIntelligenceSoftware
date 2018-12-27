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
using System.ComponentModel;

namespace SilverlightBulletGraph
{
    public partial class BulletGraph : UserControl
    {
        // private field that will hold the actual width value
        private double actualWidth;
        // private field taht will hold the width of the qualitative components grid
        private double qualitativeComponentsGridWidth;
        private double comparativeMeasureWidth;

        // default values for non-configurable bullet graph components
        // Note: you can factor these values out for extra configuration options
        //  via dependency properties
        private double bottomScalePercentage = 0.8;
        private const double comparativeMeasureScaleX = 0.01;
        private const double tickMarkScaleX = 0.0035;
        private const double tickMarkScaleY = 0.4;
        private int numberOfTickMarks = 11;

        // private field that holds the value of the size changed event was triggered
        private bool hasSizeChangedProcessed = false;

        public BulletGraph()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Note: Use SizeChanged event, because this ensures that
            // ActualWidth and ActualHeight properties are set
            this.actualWidth = this.ActualWidth;

            // Width properties are available after LayoutUpdated event is triggered
            // Bullet Graph canvas takes up 75% of the width of the entire control
            // Note: this event is called multiple times
            this.qualitativeComponentsGridWidth = this.ActualWidth * 0.75;

            // calculate the width of the comparative measure
            this.comparativeMeasureWidth = qualitativeComponentsGridWidth * comparativeMeasureScaleX;

            this.AddTickMarksAndLabels();

            // flag that size changed has processed
            // Note: this flag will be used to determine that the ActualWidth and ActualHeight
            // dimensions were set
            this.hasSizeChangedProcessed = true;

        }

        #region Bullet Graph Methods

        private void AddTickMarksAndLabels()
        {
            // Retrieve the container of the quantitative scale
            // Clear existing tick marks & labels
            Grid quantitativeScaleGrid = this.FindName("quantitativeScaleGrid") as Grid;
            if (quantitativeScaleGrid != null)
            {
                quantitativeScaleGrid.Children.Clear();
            }

            // Retrieve the minimum and maximum values of the quantitative scale
            double minimumScaleValue = 0;
            double maximumScaleValue = 200;

            // Calculate the scale range
            double tickMarksStep = (maximumScaleValue - minimumScaleValue) / (this.numberOfTickMarks - 1);
            
            // Calculate an even area between each tick mark in the quantitative scale
            double tickMarkOffSet = this.qualitativeComponentsGridWidth / (this.numberOfTickMarks - 1);

            for (int i = 0; i != numberOfTickMarks; i++)
            {
                // Create a stack panel layout container
                StackPanel spContainer = new StackPanel();
                spContainer.Orientation = Orientation.Vertical;
                spContainer.HorizontalAlignment = HorizontalAlignment.Left;
                spContainer.VerticalAlignment = VerticalAlignment.Top;

                // Create a tick mark
                Rectangle tickMark = new Rectangle();
                tickMark.HorizontalAlignment = HorizontalAlignment.Center;
                tickMark.Fill = new SolidColorBrush(Colors.Gray);
                tickMark.StrokeThickness = 0.0;
                
                // Calculate the tick mark dimensions
                double tickMarkerWidth = this.actualWidth * bottomScalePercentage * tickMarkScaleX;
                tickMark.Width = tickMarkerWidth;
                tickMark.Height = quantitativeScaleGrid.ActualHeight * tickMarkScaleY;

                // Add the tick mark to the container
                spContainer.Children.Add(tickMark);

                // Create a text block label for the tick mark
                TextBlock tb = new TextBlock();
                tb.Text = Math.Round(((minimumScaleValue + (i) * tickMarksStep)), 0).ToString();
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.TextAlignment = TextAlignment.Center;
                tb.Width = tickMarkOffSet * 2;

                // Add the tick mark to the stack panel container
                spContainer.Children.Add(tb);

                // Apply a CompositeTransform that will properly set the position of the stack panel
                CompositeTransform ct = new CompositeTransform();
                ct.TranslateX = (i - 1) * tickMarkOffSet;
                spContainer.RenderTransform = ct;

                // Add the stack panel container to the quantitative scale grid
                if (quantitativeScaleGrid != null)
                {
                    quantitativeScaleGrid.Children.Add(spContainer);
                }
            }
        }
        
        #endregion

        #region Bullet Graph Properties

        #region TextLabel
        [Category(BulletGraphTextHelper.CategoryName)]
        [Description(BulletGraphTextHelper.TextLabelDescription)]
        public string TextLabel
        {
            get
            {
                return (string)GetValue(TextLabelProperty);
            }
            set
            {
                SetValue(TextLabelProperty, value);
            }
        }

        public static readonly DependencyProperty TextLabelProperty =
            DependencyProperty.Register("TextLabel", typeof(string), typeof(BulletGraph),
            new PropertyMetadata(new PropertyChangedCallback(TextLabelChanged)));

        private static void TextLabelChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                TextBlock textBlock = bulletGraph.FindName("textLabel") as TextBlock;

                if (textBlock != null)
                {
                    textBlock.Text = e.NewValue as string;
                }
            }
        }
        #endregion
        
        #endregion
    }
}
