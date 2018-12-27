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

namespace SilverlightRotateTransition
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.SbFlip.Completed += (o, a) =>
                {
                    this.SbFlipBack.Begin();
                };

            this.SbFlip.Begin();
        }


    }
}
