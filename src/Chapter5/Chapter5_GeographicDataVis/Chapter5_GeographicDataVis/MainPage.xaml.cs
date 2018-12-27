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
using Microsoft.Expression.Shapes;
using Microsoft.Maps.MapControl;

namespace Chapter5_GeographicDataVis
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // create the fictitious data
            List<TaxiPickup> taxiPickups = new List<TaxiPickup>
            {
                new TaxiPickup{ FareAmount = 25.0, 
                    PickupLocationLatitude = 40.7091, PickupLocationLongitude = -74.012},
                new TaxiPickup{ FareAmount = 45.0, 
                    PickupLocationLatitude = 40.712, PickupLocationLongitude = -74.01},
                new TaxiPickup{ FareAmount = 25.0, 
                    PickupLocationLatitude = 40.710, PickupLocationLongitude = -74.012},
                new TaxiPickup{ FareAmount = 75.0, 
                    PickupLocationLatitude = 40.7123, PickupLocationLongitude = -74.013111},
                new TaxiPickup{ FareAmount = 20.0, 
                    PickupLocationLatitude = 40.7111, PickupLocationLongitude = -74.01222},
                new TaxiPickup{ FareAmount = 105.0, 
                    PickupLocationLatitude = 40.71255, PickupLocationLongitude = -74.01},
                new TaxiPickup{ FareAmount = 125.0, 
                    PickupLocationLatitude = 40.713, PickupLocationLongitude = -74.012},
                new TaxiPickup{ FareAmount = 15.0, 
                    PickupLocationLatitude = 40.71111, PickupLocationLongitude = -74.0122},
                new TaxiPickup{ FareAmount = 20.0, 
                    PickupLocationLatitude = 40.7111, PickupLocationLongitude = -74.01222},
                new TaxiPickup{ FareAmount = 150.0, 
                    PickupLocationLatitude = 40.7134, PickupLocationLongitude = -74.0155},
                new TaxiPickup{ FareAmount = 175.0, 
                    PickupLocationLatitude = 40.7133, PickupLocationLongitude = -74.00},
                new TaxiPickup{ FareAmount = 100.0, 
                    PickupLocationLatitude = 40.7137, PickupLocationLongitude = -73.999},
                new TaxiPickup{ FareAmount = 95.0, 
                    PickupLocationLatitude = 40.7136, PickupLocationLongitude = -73.998},
                new TaxiPickup{ FareAmount = 15.0, 
                    PickupLocationLatitude = 40.7141, PickupLocationLongitude = -74.00},
                new TaxiPickup{ FareAmount = 42.0, 
                    PickupLocationLatitude = 40.7139, PickupLocationLongitude = -73.995},
                new TaxiPickup{ FareAmount = 55.0, 
                    PickupLocationLatitude = 40.714, PickupLocationLongitude = -73.997},
                new TaxiPickup{ FareAmount = 25.0, 
                    PickupLocationLatitude = 40.7065, PickupLocationLongitude = -74.0155},
                new TaxiPickup{ FareAmount = 5.0, 
                    PickupLocationLatitude = 40.7062, PickupLocationLongitude = -74.0152},
                new TaxiPickup{ FareAmount = 15.0, 
                    PickupLocationLatitude = 40.7063, PickupLocationLongitude = -74.0148},
                new TaxiPickup{ FareAmount = 25.0, 
                    PickupLocationLatitude = 40.7083, PickupLocationLongitude = -74.013},
                new TaxiPickup{ FareAmount = 25.0, 
                    PickupLocationLatitude = 40.7071, PickupLocationLongitude = -74.011},
                new TaxiPickup{ FareAmount = 66.0, 
                    PickupLocationLatitude = 40.7066, PickupLocationLongitude = -74.010},
                new TaxiPickup{ FareAmount = 59.0, 
                    PickupLocationLatitude = 40.7062, PickupLocationLongitude = -74.011}
            };

            // iterate through the taxi pickup data
            // add a green circle for a taxi pickup that netted over 35 dollars
            // add a red circle for a taxi pickup that netted less than 35 dollars
            foreach (var taxiPickup in taxiPickups)
            {
                Shape kpiShape = null;

                if (taxiPickup.FareAmount > 35.0)
                {
                    // create a (green KPI) circle indicator
                    Ellipse ellipse = new Ellipse
                    {
                        Height = 25,
                        Width = 25,
                        Fill = new SolidColorBrush(Colors.Green),
                        Cursor = Cursors.Hand,
                        Stroke = new SolidColorBrush(Colors.Black)
                    };

                    kpiShape = ellipse;
                }
                else
                {
                    // create a (red KPI) circle indicator
                    RegularPolygon polygon = new RegularPolygon
                    {
                        Height = 25,
                        Width = 25,
                        Fill = new SolidColorBrush(Colors.Red),
                        Cursor = Cursors.Hand,
                        PointCount = 4,
                        Stroke = new SolidColorBrush(Colors.Black)
                    };

                    kpiShape = polygon;
                }

                // add a tooltip for the circle indicator
                ToolTipService.SetToolTip(kpiShape, String.Format("{0:c}", taxiPickup.FareAmount));
                // set the location for the KPI
                Location location = new Location();
                location.Latitude = taxiPickup.PickupLocationLatitude;
                location.Longitude = taxiPickup.PickupLocationLongitude;

                // add the circle indicator control to the map layer
                (this.silverlightMapControl.FindName("TaxiPickUpLayer") as MapLayer).AddChild(kpiShape, location);
            }
        }

        public class TaxiPickup
        {
            public double FareAmount { get; set; }
            public double PickupLocationLatitude { get; set; }
            public double PickupLocationLongitude { get; set; }
        }
    }
}
