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
using System.Globalization;

namespace CrossTab
{
    public static class HitssCollection
    {
        public static IEnumerable<Hits> GetHitsForDomain1()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 75, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 90, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 94, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 75, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 70 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 60 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 47 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 45 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 47 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 38 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 44 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 49 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 46 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 , HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 , HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 14, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 13, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 17, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 19, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 12, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 13, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 12, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 17, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 13, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 17, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 24, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 19, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 16, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 19, HitRegion = Region.Europe };

            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 50, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 44, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 41, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 38, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 38, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 37, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 37, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 36, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 36, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 35, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 34, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 33, HitRegion = Region.Other };



        }

        public static IEnumerable<Hits> GetReferenceLineForDomain1()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };

            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
        }

        public static IEnumerable<Hits> GetHitsForDomain2()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 25, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 24, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 45, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 30, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 35, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 37, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 37, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 38, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 38, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 47, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 44, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 44, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 44, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 45, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 49, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 40, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 41, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 46, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 47, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 48, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 49, HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 35, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 30, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 34, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 35, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 30, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 30, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 47, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 45, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 40, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 49, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 47, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 37, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 40, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 44, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 49, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 40, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 41, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 46, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 19, HitRegion = Region.Europe };

            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 50, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 99, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 98, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 95, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 87, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 85, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 77, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 70, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 68, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 68, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 63, HitRegion = Region.Other };
        }

        public static IEnumerable<Hits> GetReferenceLineForDomain2()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };

            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
        }
        
        public static IEnumerable<Hits> GetHitsForDomain3()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 25, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 14, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 10, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 23, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 27, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 25, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 29, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 23, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 27, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 23, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 28, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 29, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 24, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 29, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 16, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 17, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 14, HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 35, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 30, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 34, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 45, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 57, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 80, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 49, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 43, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 42, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 27, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 23, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 17, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 24, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 29, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 22, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 26, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 20, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 21, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 19, HitRegion = Region.Europe };


            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 50, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 55, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 60, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 62, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 61, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 69, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 68, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 68, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 67, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 66, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 64, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 63, HitRegion = Region.Other };
        }

        public static IEnumerable<Hits> GetReferenceLineForDomain3()
        {
            // USA
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 39, HitRegion = Region.USA };

            // Europe
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 15, HitRegion = Region.Europe };

            // Other
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 65, HitRegion = Region.Other };
        }
    }
}
