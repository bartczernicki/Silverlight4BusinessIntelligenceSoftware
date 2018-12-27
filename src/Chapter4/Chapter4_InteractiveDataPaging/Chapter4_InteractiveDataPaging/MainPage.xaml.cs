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
    }
}
