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
using System.Collections.Generic;

namespace CrossTab
{
    public class CrossTabReport
    {
        public string DomainName { get; set; }
        public IEnumerable<Hits> USAHits { get; set; }
        public IEnumerable<Hits> EuropeHits { get; set; }
        public IEnumerable<Hits> OtherHits { get; set; }
        public string USAHitsSum { get; set; }
        public string EuropeHitsSum { get; set; }
        public string OtherHitsSum { get; set; }
        public IEnumerable<Hits> USAHitsGoal { get; set; }
        public IEnumerable<Hits> EuropeHitsGoal { get; set; }
        public IEnumerable<Hits> OtherHitsGoal { get; set; }
    }
}
