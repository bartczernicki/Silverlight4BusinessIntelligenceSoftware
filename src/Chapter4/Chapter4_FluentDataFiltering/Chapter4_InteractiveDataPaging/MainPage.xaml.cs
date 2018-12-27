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
using System.Windows.Data;

namespace Chapter4_InteractiveDataPaging
{
    public partial class MainPage : UserControl
    {
        SampleDataSource data = new SampleDataSource();

        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // create a PageCollection view from our sales data
            PagedCollectionView collectionView = new PagedCollectionView(data.Sales);
            // set the page size
            collectionView.PageSize = 10;
            // set the data context to the page collection views
            this.DataContext = collectionView;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // ensure not to call the code before the data grid is rendered
            if (this.dgSales != null)
            {
                this.dgSales.ItemsSource = null;

                // filter the data using LINQ based on the two slider values
                // SalesAmount and SalesForecast properties are used for filtering
                this.dgSales.ItemsSource = from s in data.Sales
                                           where s.SalesAmount >= this.sliderSalesAmount.Value &&
                                           s.SalesForecast >= this.sliderSalesForecast.Value
                                           select s;
            }
        }
    }
}
