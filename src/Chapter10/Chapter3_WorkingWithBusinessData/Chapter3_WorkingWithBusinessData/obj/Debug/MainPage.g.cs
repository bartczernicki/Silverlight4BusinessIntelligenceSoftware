﻿#pragma checksum "F:\Bart\Book_Rev2\Source Code\Version 3\Chapter10\Chapter3_WorkingWithBusinessData\Chapter3_WorkingWithBusinessData\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "322D842811B1B6D4C10B8F6BEF9DB8B1"
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


namespace Chapter3_WorkingWithBusinessData {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal System.Windows.Controls.TextBox numberOfRecordsToGenerate;
        
        internal System.Windows.Controls.TextBox numberOfThreadsToUse;
        
        internal System.Windows.Controls.Button btnGenerateData;
        
        internal System.Windows.Controls.Button btnConcurrentGenerateData;
        
        internal System.Windows.Controls.Button btnPerformAnalysis;
        
        internal System.Windows.Controls.Label bmiMinimum;
        
        internal System.Windows.Controls.Label bmiMaximum;
        
        internal System.Windows.Controls.Label bmiAverage;
        
        internal System.Windows.Controls.Label bmiObeseCount;
        
        internal System.Windows.Controls.Label dataGeneratedInPerformedIn;
        
        internal System.Windows.Controls.Label performedAnalysisIn;
        
        internal System.Windows.Controls.Label concurrentDataGeneratedInPerformedIn;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Chapter3_WorkingWithBusinessData;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.numberOfRecordsToGenerate = ((System.Windows.Controls.TextBox)(this.FindName("numberOfRecordsToGenerate")));
            this.numberOfThreadsToUse = ((System.Windows.Controls.TextBox)(this.FindName("numberOfThreadsToUse")));
            this.btnGenerateData = ((System.Windows.Controls.Button)(this.FindName("btnGenerateData")));
            this.btnConcurrentGenerateData = ((System.Windows.Controls.Button)(this.FindName("btnConcurrentGenerateData")));
            this.btnPerformAnalysis = ((System.Windows.Controls.Button)(this.FindName("btnPerformAnalysis")));
            this.bmiMinimum = ((System.Windows.Controls.Label)(this.FindName("bmiMinimum")));
            this.bmiMaximum = ((System.Windows.Controls.Label)(this.FindName("bmiMaximum")));
            this.bmiAverage = ((System.Windows.Controls.Label)(this.FindName("bmiAverage")));
            this.bmiObeseCount = ((System.Windows.Controls.Label)(this.FindName("bmiObeseCount")));
            this.dataGeneratedInPerformedIn = ((System.Windows.Controls.Label)(this.FindName("dataGeneratedInPerformedIn")));
            this.performedAnalysisIn = ((System.Windows.Controls.Label)(this.FindName("performedAnalysisIn")));
            this.concurrentDataGeneratedInPerformedIn = ((System.Windows.Controls.Label)(this.FindName("concurrentDataGeneratedInPerformedIn")));
        }
    }
}

