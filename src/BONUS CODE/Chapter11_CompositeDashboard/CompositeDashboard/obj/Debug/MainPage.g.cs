﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3 Beta\Bonus Code\Chapter11\CompositeDashboard\CompositeDashboard\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "531576B05BD221260630C420DD44FBD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Blacklight.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace CompositeDashboard {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal Blacklight.Controls.DragDockPanelHost DragPanelHostHeader;
        
        internal Blacklight.Controls.DragDockPanelHost DragPanelHost;
        
        internal System.Windows.Controls.DataVisualization.Charting.Chart PieChart;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CompositeDashboard;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.DragPanelHostHeader = ((Blacklight.Controls.DragDockPanelHost)(this.FindName("DragPanelHostHeader")));
            this.DragPanelHost = ((Blacklight.Controls.DragDockPanelHost)(this.FindName("DragPanelHost")));
            this.PieChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(this.FindName("PieChart")));
        }
    }
}
