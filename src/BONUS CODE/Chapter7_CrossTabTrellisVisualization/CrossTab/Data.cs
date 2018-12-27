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
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace CrossTab
{
    public class Data
    {
        public IEnumerable<Hits> Domain1
        {
            get
            {
                return HitssCollection.GetHitsForDomain1();
            }
        }

        public IEnumerable<Hits> Domain2
        {
            get
            {
                return HitssCollection.GetHitsForDomain2();
            }
        }

        public IEnumerable<Hits> Domain3
        {
            get
            {
                return HitssCollection.GetHitsForDomain3();
            }
        }

        public IEnumerable<Hits> Domain1Goal
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain1();
            }
        }

        public IEnumerable<Hits> Domain2Goal
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain2();
            }
        }

        public IEnumerable<Hits> Domain3Goal
        {
            get
            {
                return HitssCollection.GetReferenceLineForDomain3();
            }
        }

        public IList<CrossTabReport> CrossTabData
        {
            get
            {
                List<CrossTabReport> reportData = new List<CrossTabReport>();
                reportData.Add(
                    // Domain1.com data
                    new CrossTabReport 
                        { 
                            DomainName = "Domain1.com", 
                            USAHits = Domain1.Where(a => a.HitRegion == Region.USA),
                            USAHitsSum = string.Format("{0:0,0k}",
                                         ((from domain in Domain1
                                         where domain.HitRegion == Region.USA
                                         select domain.NumberOfHits).Sum())),
                            USAHitsGoal = Domain1Goal.Where(a => a.HitRegion == Region.USA),
                            EuropeHits = Domain1.Where(a => a.HitRegion == Region.Europe),
                            EuropeHitsSum = string.Format("{0:0,0k}",
                                         ((from domain in Domain1
                                           where domain.HitRegion == Region.Europe
                                           select domain.NumberOfHits).Sum())),
                            EuropeHitsGoal = Domain1Goal.Where(a => a.HitRegion == Region.Europe),
                            OtherHits = Domain1.Where(a => a.HitRegion == Region.Other),
                            OtherHitsSum = string.Format("{0:0,0k}",
                                         ((from domain in Domain1
                                           where domain.HitRegion == Region.Other
                                           select domain.NumberOfHits).Sum())),
                            OtherHitsGoal = Domain1Goal.Where(a => a.HitRegion == Region.Other)
                        });

                reportData.Add(
                    // Domain2.com data
                    new CrossTabReport
                    {
                        DomainName = "Domain2.com",
                        USAHits = Domain2.Where(a => a.HitRegion == Region.USA),
                        USAHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain2
                                       where domain.HitRegion == Region.USA
                                       select domain.NumberOfHits).Sum())),
                        USAHitsGoal = Domain2Goal.Where(a => a.HitRegion == Region.USA),
                        EuropeHits = Domain2.Where(a => a.HitRegion == Region.Europe),
                        EuropeHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain2
                                       where domain.HitRegion == Region.Europe
                                       select domain.NumberOfHits).Sum())),
                        EuropeHitsGoal = Domain2Goal.Where(a => a.HitRegion == Region.Europe),
                        OtherHits = Domain2.Where(a => a.HitRegion == Region.Other),
                        OtherHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain2
                                       where domain.HitRegion == Region.Other
                                       select domain.NumberOfHits).Sum())),
                        OtherHitsGoal = Domain2Goal.Where(a => a.HitRegion == Region.Other)
                    });

                reportData.Add(
                    // Domain3.com data
                    new CrossTabReport
                    {
                        DomainName = "Domain3.com",
                        USAHits = Domain3.Where(a => a.HitRegion == Region.USA),
                        USAHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain3
                                       where domain.HitRegion == Region.USA
                                       select domain.NumberOfHits).Sum())),
                        USAHitsGoal = Domain3Goal.Where(a => a.HitRegion == Region.USA),
                        EuropeHits = Domain3.Where(a => a.HitRegion == Region.Europe),
                        EuropeHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain3
                                       where domain.HitRegion == Region.Europe
                                       select domain.NumberOfHits).Sum())),
                        EuropeHitsGoal = Domain3Goal.Where(a => a.HitRegion == Region.Europe),
                        OtherHits = Domain3.Where(a => a.HitRegion == Region.Other),
                        OtherHitsSum = string.Format("{0:0,0k}",
                                     ((from domain in Domain3
                                       where domain.HitRegion == Region.Other
                                       select domain.NumberOfHits).Sum())),
                        OtherHitsGoal = Domain3Goal.Where(a => a.HitRegion == Region.Other)
                    });

                return reportData;
            }
        }
    }
}
