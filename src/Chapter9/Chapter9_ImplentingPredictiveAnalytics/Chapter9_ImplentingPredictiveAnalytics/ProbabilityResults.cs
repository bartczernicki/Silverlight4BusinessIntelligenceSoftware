using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Chapter9_ImplentingPredictiveAnalytics
{
    public class ProbabilityResults : INotifyPropertyChanged
    {
        int numberOfEvents = 0;
        double probabilityOfSuccess = 0.0;

        public int NumberOfEvents
        {
            get
            {
                return numberOfEvents;
            }
            set
            {
                numberOfEvents = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("NumberOfEvents"));
            }
        }

        public double ProbabilityOfSuccess
        {
            get
            {
                return probabilityOfSuccess;
            }
            set
            {
                probabilityOfSuccess = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("ProbabilityOfSuccess"));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion
    }
}
