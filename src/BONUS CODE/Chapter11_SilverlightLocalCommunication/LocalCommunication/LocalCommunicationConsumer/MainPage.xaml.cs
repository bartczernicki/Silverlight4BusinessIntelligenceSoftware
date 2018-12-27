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
using System.Windows.Messaging;

namespace LocalCommunicationConsumer
{
    public partial class MainPage : UserControl
    {
        // collection of sales
        List<Sale> sales = new List<Sale>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // set up receiver to listen to messages of type Region
            LocalMessageReceiver receiver = new LocalMessageReceiver("Region");

            // when message is received listen to event handlers
            receiver.MessageReceived += 
                new EventHandler<MessageReceivedEventArgs>(receiver_MessageReceived);

            // receive listens to incoming messages
            receiver.Listen();

            this.sales = new List<Sale>
            {
                new Sale { CompanyName = "Contoso", SalesActual= 15000.0, SalesForecast = 25000.0, Region="North"},
                new Sale { CompanyName = "Magie's Travels", SalesActual= 30000.0, SalesForecast = 50000.0, Region="North"},
                new Sale { CompanyName = "Joe's Tires", SalesActual= 5000.0, SalesForecast = 70000.0, Region="North"},
                new Sale { CompanyName = "World Wide Traders", SalesActual= 75000.0, SalesForecast = 55000.0, Region="North"},
                new Sale { CompanyName = "Iono", SalesActual= 10000.0, SalesForecast = 5000.0, Region="North"},

                new Sale { CompanyName = "Contoso", SalesActual= 5000.0, SalesForecast = 5000.0, Region="South"},
                new Sale { CompanyName = "Magie's Travels", SalesActual= 20000.0, SalesForecast = 40000.0, Region="South"},
                new Sale { CompanyName = "Joe's Tires", SalesActual= 2000.0, SalesForecast = 50000.0, Region="South"},
                new Sale { CompanyName = "World Wide Traders", SalesActual= 45000.0, SalesForecast = 55000.0, Region="South"},
                new Sale { CompanyName = "Iono", SalesActual= 9000.0, SalesForecast = 4000.0, Region="South"},

                new Sale { CompanyName = "Contoso", SalesActual= 25000.0, SalesForecast = 35000.0, Region="International"},
                new Sale { CompanyName = "Magie's Travels", SalesActual= 20000.0, SalesForecast = 10000.0, Region="International"},
                new Sale { CompanyName = "Joe's Tires", SalesActual= 5000.0, SalesForecast = 70000.0, Region="International"},
                new Sale { CompanyName = "World Wide Traders", SalesActual= 25000.0, SalesForecast = 35000.0, Region="International"},
                new Sale { CompanyName = "Iono", SalesActual= 7000.0, SalesForecast = 1000.0, Region="International"}
            };

            this.DataContext = sales.Where(a => a.Region == "North");
        }

        void receiver_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            // filter the sales data based on selected region from provider
            this.DataContext = sales.Where(a => a.Region == e.Message);
        }
    }

    public class Sale
    {
        public string CompanyName { get; set; }
        public double SalesActual { get; set; }
        public double SalesForecast { get; set; }
        public string Region { get; set; }
    }
}
