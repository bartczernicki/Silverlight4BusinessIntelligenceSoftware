﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3\AppendixB\SilverlightBulletGraphApp_Part4_BusinessIntelligenceScenarios\SilverlightBulletGraphApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D35FD7AD50E3FE756DA5DBBD84647F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverlightBulletGraph;
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


namespace SilverlightBulletGraphApp {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard SbAnimateBulletGraph;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_MeasuresRemoved;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_NoQualitativeRanges;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_Color;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_NoLabelsOrScale;
        
        internal SilverlightBulletGraph.BulletGraph bulletTest;
        
        internal System.Windows.Controls.Slider slider;
        
        internal System.Windows.Controls.Slider slider_Copy;
        
        internal System.Windows.Controls.Slider slider_Copy1;
        
        internal System.Windows.Controls.Slider slider_Copy2;
        
        internal SilverlightBulletGraph.BulletGraph bulletGraph;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightBulletGraphApp;component/MainPage.xaml", System.UriKind.Relative));
            this.SbAnimateBulletGraph = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SbAnimateBulletGraph")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.NetMarginBulletGraph = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph")));
            this.NetMarginBulletGraph_MeasuresRemoved = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_MeasuresRemoved")));
            this.NetMarginBulletGraph_NoQualitativeRanges = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_NoQualitativeRanges")));
            this.NetMarginBulletGraph_Color = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_Color")));
            this.NetMarginBulletGraph_NoLabelsOrScale = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_NoLabelsOrScale")));
            this.bulletTest = ((SilverlightBulletGraph.BulletGraph)(this.FindName("bulletTest")));
            this.slider = ((System.Windows.Controls.Slider)(this.FindName("slider")));
            this.slider_Copy = ((System.Windows.Controls.Slider)(this.FindName("slider_Copy")));
            this.slider_Copy1 = ((System.Windows.Controls.Slider)(this.FindName("slider_Copy1")));
            this.slider_Copy2 = ((System.Windows.Controls.Slider)(this.FindName("slider_Copy2")));
            this.bulletGraph = ((SilverlightBulletGraph.BulletGraph)(this.FindName("bulletGraph")));
        }
    }
}

