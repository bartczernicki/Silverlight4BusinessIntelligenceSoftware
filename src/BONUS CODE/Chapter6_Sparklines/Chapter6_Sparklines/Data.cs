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

namespace Chapter6_Sparklines
{
    public class Data
    {
        public IEnumerable<PopularityPoll> Widgets
        {
            get
            {
                return WidgetPopularityPollCollection.GetWidgets();
            }
        }

        public IEnumerable<PopularityPoll> Wiskers
        {
            get
            {
                return WidgetPopularityPollCollection.GetWiskers();
            }
        }

        public IEnumerable<Hits> Domain1
        {
            get
            {
                return HitssCollection.GetHitsForDomain1();
            }
        }

        public IEnumerable<Hits> Domain1ReferenceLine
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain1();
            }
        }

        public IEnumerable<Hits> Domain2
        {
            get
            {
                return HitssCollection.GetHitsForDomain2();
            }
        }

        public IEnumerable<Hits> Domain2ReferenceLine
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain2();
            }
        }

        public IEnumerable<Hits> Domain3
        {
            get
            {
                return HitssCollection.GetHitsForDomain3();
            }
        }

        public IEnumerable<Hits> Domain3ReferenceLine
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain3();
            }
        }
    }
}
