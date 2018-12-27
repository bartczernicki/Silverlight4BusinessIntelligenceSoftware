using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightHostingCustomPivotViewerSample
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            this.PivotViewer.LoadCollection("http://localhost:1882/SilverlightHostingCustomPivotViewerSampleSite/SampleCollection.cxml", string.Empty);
		}
	}
}