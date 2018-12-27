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

            //this.SetQualitativeDataComponents();
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
            double minimumScaleValue = this.ScaleMinimum;
            double maximumScaleValue = this.ScaleMaximum;

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

        private double calculateProgressBarRenderValue(double value)
        {
            // calculate the scale range
            double scaleRange = this.ScaleMaximum - this.ScaleMinimum;

            // calculate newValue used for rendering
            double newValue =
                ((value + (this.ScaleMinimum < 0 ? Math.Abs(this.ScaleMinimum) : 0)) / (scaleRange)) * 100.0;

            return newValue;
        }

        private double calculateComperativeMeasureValue(double value)
        {
            // this calculation determines the location of the Comparative Measure rectangle
            double newValue = 0.0;
            double positionValue = value - this.ScaleMinimum;
            double rangeWidth = this.ScaleMaximum - this.ScaleMinimum;
            newValue = this.qualitativeComponentsGridWidth * (positionValue) / (rangeWidth);

            return newValue;
        }

        public void SetFeaturedMeasure()
        {
            if (this.hasSizeChangedProcessed)
            {
                // Set Featured Measure
                ProgressBar progressBar = this.FindName("featuredMeasure") as ProgressBar;
                if (progressBar != null)
                {
                    progressBar.Value =
                        calculateProgressBarRenderValue(Convert.ToDouble(this.FeaturedMeasure));
                }
            }
        }

        public void SetComparativeMeasure()
        {
            if (this.hasSizeChangedProcessed)
            {
                // Set Comparative measure
                Rectangle rectangle = this.FindName("comparativeMeasure") as Rectangle;
                if (rectangle != null)
                {
                    CompositeTransform ct = new CompositeTransform();
                    ct.ScaleY = 0.6;
                    ct.ScaleX = comparativeMeasureScaleX;
                    ct.TranslateX = calculateComperativeMeasureValue(this.ComparativedMeasure);
                    rectangle.RenderTransform = ct;
                }
            }
        }

        public void SetQualitativeRangeSatisfactory()
        {
            if (this.hasSizeChangedProcessed)
            {
                // Set Qualitative Range Satisfactory
                ProgressBar qualitativeRangeSatisfactory = this.FindName("qualitativeRangeSatisfactory") as ProgressBar;
                if (qualitativeRangeSatisfactory != null)
                {
                    qualitativeRangeSatisfactory.Value =
                        calculateProgressBarRenderValue(Convert.ToDouble(this.QualitativeRangeSatisfactory));
                }
            }
        }

        public void SetQualitativeRangeBad()
        {
            if (this.hasSizeChangedProcessed)
            {
                // Set Qualitative Range Bad
                ProgressBar setQualitativeRangeBad = this.FindName("qualitativeRangeBad") as ProgressBar;
                if (setQualitativeRangeBad != null)
                {
                    setQualitativeRangeBad.Value =
                        calculateProgressBarRenderValue(Convert.ToDouble(this.QualitativeRangeBad));
                }
            }
        }

        public void SetQualitativeDataComponents()
        {
            // sets all the qualitative components that depend on control rendering
            // this method should be triggered when either the minimum or maxium scale changes
            this.SetFeaturedMeasure();
            this.SetComparativeMeasure();
            this.SetQualitativeRangeSatisfactory();
            this.SetQualitativeRangeBad();
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

        #region Unit Label
        [Category(BulletGraphTextHelper.CategoryName)]
        public string UnitLabel
        {
            get
            {
                return (string)GetValue(UnitLabelProperty);
            }
            set
            {
                SetValue(UnitLabelProperty, value);
            }
        }

        public static readonly DependencyProperty UnitLabelProperty =
            DependencyProperty.Register("UnitLabel", typeof(string), typeof(BulletGraph),
            new PropertyMetadata(" ", new PropertyChangedCallback(ChangeUnitLabel)));

        private static void ChangeUnitLabel(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                TextBlock textBlock = bulletGraph.FindName("unitLabel") as TextBlock;

                if (textBlock != null)
                {
                    textBlock.Text = e.NewValue as string;
                }
            }
        }
        #endregion

        #region Show Labels
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowLabels
        {
            get
            {
                return (bool)GetValue(ShowLabelsProperty);
            }
            set
            {
                SetValue(ShowLabelsProperty, value);
            }
        }

        public static readonly DependencyProperty ShowLabelsProperty =
            DependencyProperty.Register("ShowLabels", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowLabels)));

        private static void ChangeShowLabels(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                TextBlock textLabel = bulletGraph.FindName("textLabel") as TextBlock;
                TextBlock unitLabel = bulletGraph.FindName("unitLabel") as TextBlock;

                if (textLabel != null && unitLabel != null)
                {
                    textLabel.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;

                    unitLabel.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region ShowQualitativeRangeBad
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowQualitativeRangeBad
        {
            get
            {
                return (bool)GetValue(ShowQualitativeRangeBadProperty);
            }
            set
            {
                SetValue(ShowQualitativeRangeBadProperty, value);
            }
        }

        public static readonly DependencyProperty ShowQualitativeRangeBadProperty =
            DependencyProperty.Register("ShowQualitativeRangeBad", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowQualitativeRangeBad)));

        private static void ChangeShowQualitativeRangeBad(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeBad") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region ShowQualitativeRangeSatisfactory
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowQualitativeRangeSatisfactory
        {
            get
            {
                return (bool)GetValue(ShowQualitativeRangeSatisfactoryProperty);
            }
            set
            {
                SetValue(ShowQualitativeRangeSatisfactoryProperty, value);
            }
        }

        public static readonly DependencyProperty ShowQualitativeRangeSatisfactoryProperty =
            DependencyProperty.Register("ShowQualitativeRangeSatisfactory", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowQualitativeRangeSatisfactory)));

        private static void ChangeShowQualitativeRangeSatisfactory(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeSatisfactory") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region ShowQualitativeRangeGood
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowQualitativeRangeGood
        {
            get
            {
                return (bool)GetValue(ShowQualitativeRangeGoodProperty);
            }
            set
            {
                SetValue(ShowQualitativeRangeGoodProperty, value);
            }
        }

        public static readonly DependencyProperty ShowQualitativeRangeGoodProperty =
            DependencyProperty.Register("ShowQualitativeRangeGood", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowQualitativeRangeGood)));

        private static void ChangeShowQualitativeRangeGood(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeGood") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region ShowComparativeMeasure
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowComparativeMeasure
        {
            get
            {
                return (bool)GetValue(ShowComparativeMeasureProperty);
            }
            set
            {
                SetValue(ShowComparativeMeasureProperty, value);
            }
        }

        public static readonly DependencyProperty ShowComparativeMeasureProperty =
            DependencyProperty.Register("ShowComparativeMeasure", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowComparativeMeasure)));

        private static void ChangeShowComparativeMeasure(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                Rectangle comparativeMeasure = bulletGraph.FindName("comparativeMeasure") as Rectangle;

                if (comparativeMeasure != null)
                {
                    comparativeMeasure.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region QualitativeRangeBadColor
        [Category(BulletGraphTextHelper.CategoryName)]
        public Brush QualitativeRangeBadColor
        {
            get
            {
                return (Brush)GetValue(QualitativeRangeBadColorProperty);
            }
            set
            {
                SetValue(QualitativeRangeBadColorProperty, value);
            }
        }

        public static readonly DependencyProperty QualitativeRangeBadColorProperty =
            DependencyProperty.Register("QualitativeRangeBadColor", typeof(Brush), typeof(BulletGraph),
            new PropertyMetadata(new PropertyChangedCallback(ChangeQualitativeRangeBadColor)));

        private static void ChangeQualitativeRangeBadColor(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeBad") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Foreground = e.NewValue as Brush;
                }
            }
        }
        #endregion

        #region QualitativeRangeSatisfactoryColor
        [Category(BulletGraphTextHelper.CategoryName)]
        public Brush QualitativeRangeSatisfactoryColor
        {
            get
            {
                return (Brush)GetValue(QualitativeRangeSatisfactoryColorProperty);
            }
            set
            {
                SetValue(QualitativeRangeSatisfactoryColorProperty, value);
            }
        }

        public static readonly DependencyProperty QualitativeRangeSatisfactoryColorProperty =
            DependencyProperty.Register("QualitativeRangeSatisfactoryColor", typeof(Brush), typeof(BulletGraph),
            new PropertyMetadata(new PropertyChangedCallback(ChangeQualitativeRangeSatisfactoryColor)));

        private static void ChangeQualitativeRangeSatisfactoryColor(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeSatisfactory") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Foreground = e.NewValue as Brush;
                }
            }
        }
        #endregion

        #region QualitativeRangeGoodColor
        [Category(BulletGraphTextHelper.CategoryName)]
        public Brush QualitativeRangeGoodColor
        {
            get
            {
                return (Brush)GetValue(QualitativeRangeGoodColorProperty);
            }
            set
            {
                SetValue(QualitativeRangeGoodColorProperty, value);
            }
        }

        public static readonly DependencyProperty QualitativeRangeGoodColorProperty =
            DependencyProperty.Register("QualitativeRangeGoodColor", typeof(Brush), typeof(BulletGraph),
            new PropertyMetadata(new PropertyChangedCallback(ChangeQualitativeRangeGoodColor)));

        private static void ChangeQualitativeRangeGoodColor(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                ProgressBar qualitativeRange = bulletGraph.FindName("qualitativeRangeGood") as ProgressBar;

                if (qualitativeRange != null)
                {
                    qualitativeRange.Foreground = e.NewValue as Brush;
                }
            }
        }
        #endregion

        #region ShowQuantitativeScale
        [Category(BulletGraphTextHelper.CategoryName)]
        public bool ShowQuantitativeScale
        {
            get
            {
                return (bool)GetValue(ShowQuantitativeScaleProperty);
            }
            set
            {
                SetValue(ShowQuantitativeScaleProperty, value);
            }
        }

        public static readonly DependencyProperty ShowQuantitativeScaleProperty =
            DependencyProperty.Register("ShowQuantitativeScale", typeof(bool), typeof(BulletGraph),
            new PropertyMetadata(true, new PropertyChangedCallback(ChangeShowQuantitativeScale)));

        private static void ChangeShowQuantitativeScale(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                Grid scaleGrid = bulletGraph.FindName("quantitativeScaleGrid") as Grid;

                if (scaleGrid != null)
                {
                    scaleGrid.Visibility = (Convert.ToBoolean(e.NewValue)) ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }
        #endregion

        #region ScaleMinimum
        [Category(BulletGraphTextHelper.CategoryName)]
        public double ScaleMinimum
        {
            get
            {
                return (double)GetValue(ScaleMinimumProperty);
            }
            set
            {
                SetValue(ScaleMinimumProperty, value);
            }
        }

        public static readonly DependencyProperty ScaleMinimumProperty =
            DependencyProperty.Register("ScaleMinimum", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(0.0, new PropertyChangedCallback(ChangeScaleMinimum)));

        private static void ChangeScaleMinimum(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all content in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                // Re-render the tick marks
                bulletGraph.AddTickMarksAndLabels();
                // Re-render the qualitative components
                bulletGraph.SetQualitativeDataComponents();
            }
        }
        #endregion

        #region ScaleMaximum
        [Category(BulletGraphTextHelper.CategoryName)]
        public double ScaleMaximum
        {
            get
            {
                return (double)GetValue(ScaleMaximumProperty);
            }
            set
            {
                SetValue(ScaleMaximumProperty, value);
            }
        }

        public static readonly DependencyProperty ScaleMaximumProperty =
            DependencyProperty.Register("ScaleMaximum", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(100.0, new PropertyChangedCallback(ChangeScaleMaximum)));

        private static void ChangeScaleMaximum(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all calculations in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  
            // We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.

            // Retrieve the reference to the bullet graph control
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                // Re-render the tick marks
                bulletGraph.AddTickMarksAndLabels();

                // Re-render the qualitative components
                bulletGraph.SetQualitativeDataComponents();
            }
        }
        #endregion

        #region FeaturedMeasure
        [Category(BulletGraphTextHelper.CategoryName)]
        public double FeaturedMeasure
        {
            get
            {
                return (double)GetValue(FeaturedMeasureProperty);
            }
            set
            {
                SetValue(FeaturedMeasureProperty, value);

                // Note: It is not recommended to add additional content in the setter for a
                // property bound to a dependency property in Silverlight.
            }
        }

        public static readonly DependencyProperty FeaturedMeasureProperty =
            DependencyProperty.Register("FeaturedMeasure", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(0.0, new PropertyChangedCallback(ChangeFeaturedMeasure)));

        private static void ChangeFeaturedMeasure(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all content in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                bulletGraph.SetFeaturedMeasure();
            }
        }
        #endregion

        #region ComparativedMeasure
        [Category(BulletGraphTextHelper.CategoryName)]
        public double ComparativedMeasure
        {
            get
            {
                return (double)GetValue(ComparativedMeasureProperty);
            }
            set
            {
                SetValue(ComparativedMeasureProperty, value);

                // Note: It is not recommended to add additional content in the setter for a
                // property bound to a dependency property in Silverlight.
            }
        }

        public static readonly DependencyProperty ComparativedMeasureProperty =
            DependencyProperty.Register("ComparativedMeasure", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(new PropertyChangedCallback(ChangeComparativedMeasure)));

        private static void ChangeComparativedMeasure(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all content in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                bulletGraph.SetComparativeMeasure();
            }
        }
        #endregion

        #region QualitativeRangeBad
        [Category(BulletGraphTextHelper.CategoryName)]
        public double QualitativeRangeBad
        {
            get
            {
                return (double)GetValue(QualitativeRangeBadProperty);
            }
            set
            {
                SetValue(QualitativeRangeBadProperty, value);

                // Note: It is not recommended to add additional content in the setter for a
                // property bound to a dependency property in Silverlight.
            }
        }

        public static readonly DependencyProperty QualitativeRangeBadProperty =
            DependencyProperty.Register("QualitativeRangeBad", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(0.0, new PropertyChangedCallback(ChangeQualitativeRangeBad)));

        private static void ChangeQualitativeRangeBad(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all content in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                bulletGraph.SetQualitativeRangeBad();
            }
        }
        #endregion

        #region QualitativeRangeSatisfactory
        [Category(BulletGraphTextHelper.CategoryName)]
        public double QualitativeRangeSatisfactory
        {
            get
            {
                return (double)GetValue(QualitativeRangeSatisfactoryProperty);
            }
            set
            {
                SetValue(QualitativeRangeSatisfactoryProperty, value);

                // Note: It is not recommended to add additional content in the setter for a
                // property bound to a dependency property in Silverlight.
            }
        }

        public static readonly DependencyProperty QualitativeRangeSatisfactoryProperty =
            DependencyProperty.Register("QualitativeRangeSatisfactory", typeof(double), typeof(BulletGraph),
            new PropertyMetadata(0.0, new PropertyChangedCallback(ChangeQualitativeRangeSatisfactory)));

        private static void ChangeQualitativeRangeSatisfactory(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            // Note: Best practice is to create all content in the static callback methods.
            // This enables advanced binding scenarios, such as element binding.
            // Since the dependency properties are static methods only reference members cannot be executed.
            // The source is passed as a reference of a bullet graph.  We can use this to access reference measures.
            // Another option is to trigger a virual method from a static method.
            // Virtual methods can trigger reference members of the class.
            BulletGraph bulletGraph = source as BulletGraph;

            if (bulletGraph != null)
            {
                bulletGraph.SetQualitativeRangeSatisfactory();
            }
        }
        #endregion

        #endregion
    }
}
