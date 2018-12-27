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

namespace Chapter10_GPUAcceleration
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new List<Sale>
            {
                new Sale { CompanyName = "Contoso", SalesActual= 15000.0, SalesForecast = 25000.0},
                new Sale { CompanyName = "Magie's Travels", SalesActual= 30000.0, SalesForecast = 50000.0},
                new Sale { CompanyName = "Joe's Tires", SalesActual= 5000.0, SalesForecast = 70000.0},
                new Sale { CompanyName = "World Wide Traders", SalesActual= 75000.0, SalesForecast = 55000.0},
                new Sale { CompanyName = "Iono", SalesActual= 10000.0, SalesForecast = 5000.0}
            };
        }
    }

    public class Sale
    {
        public string CompanyName { get; set; }
        public double SalesActual { get; set; }
        public double SalesForecast { get; set; }
    }
}
