﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3\BONUS CODE\AppendixB_BulletGraphScenarios\AppendixB_BulletGraphScenarios\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "72C49BAC73FDD7702C37FE69A07C43E2"
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


namespace AppendixB_BulletGraphScenarios {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_MeasuresRemoved;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_NoQualitativeRanges;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_Color;
        
        internal SilverlightBulletGraph.BulletGraph NetMarginBulletGraph_NoLabelsOrScale;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppendixB_BulletGraphScenarios;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.NetMarginBulletGraph = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph")));
            this.NetMarginBulletGraph_MeasuresRemoved = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_MeasuresRemoved")));
            this.NetMarginBulletGraph_NoQualitativeRanges = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_NoQualitativeRanges")));
            this.NetMarginBulletGraph_Color = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_Color")));
            this.NetMarginBulletGraph_NoLabelsOrScale = ((SilverlightBulletGraph.BulletGraph)(this.FindName("NetMarginBulletGraph_NoLabelsOrScale")));
        }
    }
}

