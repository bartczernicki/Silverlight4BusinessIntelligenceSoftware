﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3\Chapter5\Chapter5_GeographicDataVis\Chapter5_GeographicDataVis\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47167BC8CE8F480E4DDFBE57994FD83B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Maps.MapControl;
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


namespace Chapter5_GeographicDataVis {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Maps.MapControl.Map silverlightMapControl;
        
        internal Microsoft.Maps.MapControl.MapLayer TaxiPickUpLayer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Chapter5_GeographicDataVis;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.silverlightMapControl = ((Microsoft.Maps.MapControl.Map)(this.FindName("silverlightMapControl")));
            this.TaxiPickUpLayer = ((Microsoft.Maps.MapControl.MapLayer)(this.FindName("TaxiPickUpLayer")));
        }
    }
}

