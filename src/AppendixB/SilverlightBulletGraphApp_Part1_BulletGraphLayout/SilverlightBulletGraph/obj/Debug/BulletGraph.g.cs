﻿#pragma checksum "C:\download\SLBulletGraph\SilverlightBulletGraphApp_Part1_ BulletGraphLayout\SilverlightBulletGraph\BulletGraph.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9359A89DB20E14D1AFF49A252192CDB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SilverlightBulletGraph {
    
    
    public partial class BulletGraph : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textLabel;
        
        internal System.Windows.Controls.TextBlock unitLabel;
        
        internal System.Windows.Controls.Grid qualitativeComponentsGrid;
        
        internal System.Windows.Controls.ProgressBar qualitativeRangeGood;
        
        internal System.Windows.Controls.ProgressBar qualitativeRangeSatisfactory;
        
        internal System.Windows.Controls.ProgressBar qualitativeRangeBad;
        
        internal System.Windows.Controls.ProgressBar featuredMeasure;
        
        internal System.Windows.Shapes.Rectangle comparativeMeasure;
        
        internal System.Windows.Controls.Grid quantitativeScaleGrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightBulletGraph;component/BulletGraph.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textLabel = ((System.Windows.Controls.TextBlock)(this.FindName("textLabel")));
            this.unitLabel = ((System.Windows.Controls.TextBlock)(this.FindName("unitLabel")));
            this.qualitativeComponentsGrid = ((System.Windows.Controls.Grid)(this.FindName("qualitativeComponentsGrid")));
            this.qualitativeRangeGood = ((System.Windows.Controls.ProgressBar)(this.FindName("qualitativeRangeGood")));
            this.qualitativeRangeSatisfactory = ((System.Windows.Controls.ProgressBar)(this.FindName("qualitativeRangeSatisfactory")));
            this.qualitativeRangeBad = ((System.Windows.Controls.ProgressBar)(this.FindName("qualitativeRangeBad")));
            this.featuredMeasure = ((System.Windows.Controls.ProgressBar)(this.FindName("featuredMeasure")));
            this.comparativeMeasure = ((System.Windows.Shapes.Rectangle)(this.FindName("comparativeMeasure")));
            this.quantitativeScaleGrid = ((System.Windows.Controls.Grid)(this.FindName("quantitativeScaleGrid")));
        }
    }
}

