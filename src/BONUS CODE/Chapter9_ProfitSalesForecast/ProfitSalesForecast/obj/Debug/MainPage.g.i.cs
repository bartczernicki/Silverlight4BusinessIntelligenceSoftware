﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3 Beta\Bonus Code\Chapter9\ProfitSalesForeCast\ProfitSalesForecast\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "935BE478154552BCC4F53667ECBECB5F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProfitSalesForecast;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ProfitSalesForecast {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal System.Windows.Controls.StackPanel Sales;
        
        internal ProfitSalesForecast.ForecastModel USASales;
        
        internal ProfitSalesForecast.ForecastModel MexicoSales;
        
        internal ProfitSalesForecast.ForecastModel CanadaSales;
        
        internal System.Windows.Controls.StackPanel Costs;
        
        internal ProfitSalesForecast.ForecastModel SalaryCosts;
        
        internal ProfitSalesForecast.ForecastModel SalesCosts;
        
        internal ProfitSalesForecast.ForecastModel TotalRev;
        
        internal ProfitSalesForecast.ForecastModel TotalCosts;
        
        internal ProfitSalesForecast.ForecastModel Final;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ProfitSalesForecast;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.Sales = ((System.Windows.Controls.StackPanel)(this.FindName("Sales")));
            this.USASales = ((ProfitSalesForecast.ForecastModel)(this.FindName("USASales")));
            this.MexicoSales = ((ProfitSalesForecast.ForecastModel)(this.FindName("MexicoSales")));
            this.CanadaSales = ((ProfitSalesForecast.ForecastModel)(this.FindName("CanadaSales")));
            this.Costs = ((System.Windows.Controls.StackPanel)(this.FindName("Costs")));
            this.SalaryCosts = ((ProfitSalesForecast.ForecastModel)(this.FindName("SalaryCosts")));
            this.SalesCosts = ((ProfitSalesForecast.ForecastModel)(this.FindName("SalesCosts")));
            this.TotalRev = ((ProfitSalesForecast.ForecastModel)(this.FindName("TotalRev")));
            this.TotalCosts = ((ProfitSalesForecast.ForecastModel)(this.FindName("TotalCosts")));
            this.Final = ((ProfitSalesForecast.ForecastModel)(this.FindName("Final")));
        }
    }
}

