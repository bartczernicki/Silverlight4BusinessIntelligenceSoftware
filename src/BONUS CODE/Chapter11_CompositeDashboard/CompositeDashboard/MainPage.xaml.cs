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
using System.Collections.ObjectModel;
using Blacklight.Controls;

namespace CompositeDashboard
{
    public partial class MainPage : UserControl
    {
        private ObservableCollection<DragDockPanel> panels = new ObservableCollection<DragDockPanel>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            this.DragPanelHost.MinimizedPosition = Blacklight.Controls.MinimizedPositions.Right;
            this.DragPanelHost.MinimizedColumnWidth = 400;
        }
    }
}
