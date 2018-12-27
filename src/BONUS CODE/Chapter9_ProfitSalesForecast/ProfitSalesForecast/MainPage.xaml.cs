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

namespace ProfitSalesForecast
{
    public partial class MainPage : UserControl
    {
        SampleDataSource dataSource = new SampleDataSource();

        public MainPage()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.TotalCosts.DependentOperation = "sum";
            this.TotalRev.DependentOperation = "sum";
            this.Final.DependentOperation = "diff";

            this.USASales.InitialValue = dataSource.Collection.Where(a => a.PropertyName == "USASales").First().Value;
            this.MexicoSales.InitialValue = dataSource.Collection.Where(a => a.PropertyName == "MexicoSales").First().Value;
            this.CanadaSales.InitialValue = dataSource.Collection.Where(a => a.PropertyName == "CanadaSales").First().Value;

            this.SalaryCosts.InitialValue = dataSource.Collection.Where(a => a.PropertyName == "SalaryCosts").First().Value;
            this.SalesCosts.InitialValue = dataSource.Collection.Where(a => a.PropertyName == "SalesCosts").First().Value;

            this.TotalRev.DependentForecastModels = new List<ForecastModel> { this.USASales, this.MexicoSales, this.CanadaSales };
            this.TotalCosts.DependentForecastModels = new List<ForecastModel> { this.SalaryCosts, this.SalesCosts };
            this.Final.DependentForecastModels = new List<ForecastModel> { this.TotalRev, this.TotalCosts };
            //
        }
    }
}
