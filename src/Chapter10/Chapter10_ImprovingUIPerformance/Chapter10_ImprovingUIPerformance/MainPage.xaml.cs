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
using System.ComponentModel;

namespace Chapter10_ImprovingUIPerformance
{
    public partial class MainPage : UserControl
    {
        // declare count variables
        int countSliderSimple = 0;
        int countSliderSingleThreaded = 0;
        int countSliderMultiThreaded = 0;
        // last value
        double lastMultiThreadedSliderValue = 0.0;
        // declare background worker
        BackgroundWorker bw = new BackgroundWorker();


        public MainPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            // wire up RunWorkerCompleted event
            // This will fire when the business logic has completed
            this.bw.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            // Wire up the DoWork event
            // This will fire each time we need to process the "business logic"
            this.bw.DoWork += new DoWorkEventHandler(bw_DoWork);
        }

        private void SliderSimple_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // increment simple slider event count
            this.countSliderSimple++;
            // set the slider value to its text box
            this.txtSliderSimpleValue.Text = this.SliderSimple.Value.ToString();
            // set the count on the text box
            this.txtSliderSimpleNumberEventFires.Text = this.countSliderSimple.ToString();
        }

        private void SliderSingleThreaded_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // increment single threaded slider event count
            this.countSliderSingleThreaded++;
            // set the slider value to its text box
            this.txtSliderSingleThreadedValue.Text = this.SliderSingleThreaded.Value.ToString();

            // add a fake delay of 150 milliseconds (3/20 of a second)
            System.Threading.Thread.Sleep(150);

            // set the count on the text box
            this.txtSliderSingleThreadNumberEventFires.Text = this.countSliderSingleThreaded.ToString();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //NOTE: The logic here is processed on the secondary thread

            // add a fake delay of 150 milliseconds (about 1/7 of a second)
            // this mocks an expensive business algorithm
            System.Threading.Thread.Sleep(150);
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //NOTE: The logic here is processed on the main thread

            // set the slider value to its text box
            // notice this is set here, as it guarantees that the value is now officially set
            // setting it in the SliderMultiThreaded_ValueChanged event, the 2nd thread would have to catch up to the UI
            this.txtSliderMultiThreadedValue.Text = this.SliderMultiThreaded.Value.ToString();

            // Run the background worker again in case the slider value needs to catch up
            // If you stop the slider at the end for example, it might be still processing the previous event
            // you want to make sure that where the slider is stopped (last event fired) matches what was processed by the 2nd thread
            if (!this.bw.IsBusy)
            {
                // if the values are not in sync, then the 2nd thread needs to catch up to the UI
                if ((this.SliderMultiThreaded.Value != this.LastMultiThreadedSliderValue) && (this.LastMultiThreadedSliderValue != 0.0))
                {
                    // run the process again if the last value set has not been run by the second thread
                    this.bw.RunWorkerAsync();
                    // set the value to 0.0
                    this.LastMultiThreadedSliderValue = 0.0;
                }
            }
        }

        public double LastMultiThreadedSliderValue
        {
            get
            {
                object objLock = new object();
                lock (objLock)
                {
                    return this.lastMultiThreadedSliderValue;
                }
            }
            set
            {
                // lock the setter so multiple threads do not leave the value inconsistant
                object objLock = new object();
                lock (objLock)
                {
                    this.lastMultiThreadedSliderValue = value;
                }
            }
        }

        private void SliderMultiThreaded_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // increment multi threaded slider event count
            this.countSliderMultiThreaded++;
            // set the last value set compared to the current value
            this.LastMultiThreadedSliderValue = this.SliderMultiThreaded.Value;

            // If the BackgroundWorker is free, 
            // execute the business logic on the second thread
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }

            // set the count on the text box
            this.txtSliderMultiThreadNumberEventFires.Text = this.countSliderMultiThreaded.ToString();
        }

    }
}
