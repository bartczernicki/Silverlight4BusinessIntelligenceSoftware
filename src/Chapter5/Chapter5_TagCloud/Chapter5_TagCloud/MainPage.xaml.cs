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

namespace Chapter5_TagCloud
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // define a list of sales
            List<Sale> sales = new List<Sale>
        {
            new Sale { CompanyName = "Contoso", SalesAmount= 15000.0},
            new Sale { CompanyName = "Magie's Travels", SalesAmount= 15000.0},
            new Sale { CompanyName = "Joe's Tires", SalesAmount= 16000.0},
            new Sale { CompanyName = "World Wide Traders", SalesAmount= 15000.0},
            new Sale { CompanyName = "Iono", SalesAmount= 15000.0},
            new Sale { CompanyName = "Nokes", SalesAmount= 25000.0},
            new Sale { CompanyName = "Bob's Repair", SalesAmount= 15000.0},
            new Sale { CompanyName = "Tara's Plumbing", SalesAmount= 15000.0},
            new Sale { CompanyName = "Smitty Funs", SalesAmount= 16000.0},
            new Sale { CompanyName = "Granpeeda", SalesAmount= 45000.0},
            new Sale { CompanyName = "Tyo", SalesAmount= 115000.0},
            new Sale { CompanyName = "Weeebo", SalesAmount= 155000.0},
            new Sale { CompanyName = "Vic's Bagels", SalesAmount= 15000.0},
            new Sale { CompanyName = "Wrenchmaniacs", SalesAmount= 15000.0},
            new Sale { CompanyName = "Fan Fixers", SalesAmount= 85000.0},
            new Sale { CompanyName = "Jemo Holdings", SalesAmount= 15000.0},
            new Sale { CompanyName = "TAC Bank", SalesAmount= 70000.0},
            new Sale { CompanyName = "Finite Metals", SalesAmount= 5000.0},
            new Sale { CompanyName = "Smitty Coins", SalesAmount= 15000.0},
            new Sale { CompanyName = "Target Tootsies", SalesAmount= 7000.0}
        };

            // define min and max sales amounts
            double minSalesAmount = sales.Min(a => a.SalesAmount);
            double maxSalesAmount = sales.Max(a => a.SalesAmount);
            // calculate the sales delta
            double salesAmountDelta = maxSalesAmount - minSalesAmount;

            // define the min and max font sizes
            double minFontSize = 10.0;
            double maxFontSize = 30.0;
            // calculate the font size delta
            double fontSizeDelta = maxFontSize - minFontSize;

            // add items to the wrap panel
            for (int i = 0; i != sales.Count; i++)
            {
                // define a new text block control
                TextBlock textBlock = new TextBlock
                {
                    // set the text to the company name
                    Text = sales[i].CompanyName,
                    // alternate the colors
                    Foreground = i % 2 == 0 ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Blue),
                    // apply a uniform margin
                    Margin = new Thickness(2),
                    // set the font size
                    FontSize = minFontSize + sales[i].SalesAmount * fontSizeDelta / salesAmountDelta
                };

                this.wrapPanelSales.Children.Add(textBlock);
            }


        }

        public class Sale
        {
            public string CompanyName { get; set; }
            public double SalesAmount { get; set; }
        }
    }
}
