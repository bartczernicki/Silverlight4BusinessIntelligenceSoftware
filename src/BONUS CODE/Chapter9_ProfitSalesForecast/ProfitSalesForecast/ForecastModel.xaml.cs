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
using System.Diagnostics;

namespace ProfitSalesForecast
{
    public partial class ForecastModel : UserControl
    {
		public string title = String.Empty;
        public double initialValue = 0.0;
        public event EventHandler<ForecastEventArgs> ForecastChanged = delegate { };
        private List<ForecastModel> forecastModels;
        private string dependentOperation;
        private double currentValue;

        public ForecastModel()
        {
            InitializeComponent();
        }
		
		public string PositionType
		{
			get;
			set;
		}
		
		public bool IsReadOnly
		{
			get;
			set;
		}
		
		public double InitialValue
		{
            get
            {
                return this.initialValue;
            }
            set
            {
                this.initialValue = value;
                this.MaxValue.Content = String.Format("{0:C}", Math.Round(this.initialValue*1.4), 0);
                this.Progress.Maximum = this.initialValue * 1.4;
                this.CurrentValue = value;
            }
		}

        public double CurrentValue
        {
            get
            {
                return this.currentValue;

            }
            set
            {
                this.currentValue = value;
                // set the value of the progress bar
                this.Progress.Value = this.currentValue;
                // set the label display of the control
                this.Value.Text = String.Format("{0:C}", Math.Round(this.currentValue), 0);
                // trigger the ForecastChanged event
                this.ForecastChanged(this, new ForecastEventArgs { ForecastModelValue = this.currentValue });
            }
        }

        public List<ForecastModel> DependentForecastModels
        {
            get
            {
                return this.forecastModels;
            }
            set
            {
                this.forecastModels = value;
                double currentValues = 0;

                foreach (ForecastModel model in this.forecastModels)
                {
                    if (this.DependentOperation == "sum")
                    {
                        currentValues += model.CurrentValue * 1.1;
                    }
                    else
                    {
                        if (currentValues == 0.0)
                        {
                            currentValues += model.CurrentValue * 1.1;
                        }
                        else
                        {
                            currentValues -= model.CurrentValue * 1.1;
                        }
                    }

                    model.ForecastChanged += new EventHandler<ForecastEventArgs>(DependentForecastChanged);
                }

                this.MinValue.Content = String.Format("{0:C}", Math.Round(currentValues / 3, 0));
                this.Progress.Minimum = currentValues / 3;
                this.InitialValue = currentValues;
            }
        }

        public string DependentOperation
        {
            get
            {
                return this.dependentOperation;
            }
            set
            {
                this.dependentOperation = value;
            }
        }
		
		public string Title
		{
			set
			{
				this.title = value;
				this.ModelTitle.Text = value;
			}
			get
			{
				return title;
			}
		}

		private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			switch (this.PositionType)
			{
				case "Top":
					VisualStateManager.GoToState(this, "Top", false);
					break;
				case "Middle":
					VisualStateManager.GoToState(this, "Middle", false);
					break;
				case "Bottom":
					VisualStateManager.GoToState(this, "Bottom", false);
					break;
				case "None":
                    VisualStateManager.GoToState(this, "None", false);
					break;
			}
			
			if (this.IsReadOnly)
			{
				VisualStateManager.GoToState(this, "ReadOnly", false);
			}
		}

        void DependentForecastChanged(object sender, ForecastEventArgs e)
        {
            if (this.DependentOperation == "sum")
            {
                this.CurrentValue = this.forecastModels.Sum(a => a.CurrentValue);
            }
            else
            {
                this.CurrentValue = this.forecastModels[0].CurrentValue - this.forecastModels[1].CurrentValue;
            }
        }

		private void Slider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
		{
            double newValue = ((Slider)sender).Value;

            double doubleValue = Math.Round(this.InitialValue + (this.InitialValue * newValue / 100), 0);

            this.CurrentValue = doubleValue;
		}
    }
}
