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

namespace Chapter6_Sparklines
{
    public static class HitssCollection
    {
        public static IEnumerable<Hits> GetHitsForDomain1()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 75 };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 90 };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 94 };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 75 };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 70 };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 60 };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 47 };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 45 };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 47 };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 43 };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 38 };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 44 };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 49 };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 46 };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 41 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 39 };
        }

        public static IEnumerable<Hits> GetReferenceLineForDomain1()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 55 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 55 };
        }

        public static IEnumerable<Hits> GetHitsForDomain2()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 55 };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 42 };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 44 };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 46 };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 50 };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 55 };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 60 };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 65 };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 70 };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 71 };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 69 };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 70 };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 71 };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 72 };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 73 };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 75 };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 76 };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 77 };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 80 };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 81 };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 82 };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 82 };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 83 };
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 86 };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 87 };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 88 };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 89 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 90 };
        }

        public static IEnumerable<Hits> GetReferenceLineForDomain2()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 64 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 64 };
        }

        public static IEnumerable<Hits> GetHitsForDomain3()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 22 };
            yield return new Hits { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), NumberOfHits = 21 };
            yield return new Hits { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), NumberOfHits = 26 };
            yield return new Hits { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 27 };
            yield return new Hits { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 46 };
            yield return new Hits { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), NumberOfHits = 44 };
            yield return new Hits { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), NumberOfHits = 44 };
            yield return new Hits { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), NumberOfHits = 32 };
            yield return new Hits { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 31 };
            yield return new Hits { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), NumberOfHits = 30 };
            yield return new Hits { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 32 };
            yield return new Hits { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), NumberOfHits = 35 };
            yield return new Hits { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), NumberOfHits = 37 };
            yield return new Hits { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), NumberOfHits = 38 };
            yield return new Hits { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 32 };
            yield return new Hits { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 31 };
            yield return new Hits { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), NumberOfHits = 34 };
            yield return new Hits { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), NumberOfHits = 36 };
            yield return new Hits { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), NumberOfHits = 37 };
            yield return new Hits { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 };
            yield return new Hits { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), NumberOfHits = 31 };
            yield return new Hits { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), NumberOfHits = 32 };
            yield return new Hits { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), NumberOfHits = 33 };
            yield return new Hits { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), NumberOfHits = 40 } ;
            yield return new Hits { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), NumberOfHits = 37 };
            yield return new Hits { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), NumberOfHits = 37 };
            yield return new Hits { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), NumberOfHits = 36 };
            yield return new Hits { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), NumberOfHits = 32 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 31 };
        }

        public static IEnumerable<Hits> GetReferenceLineForDomain3()
        {
            yield return new Hits { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), NumberOfHits = 35 };
            yield return new Hits { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), NumberOfHits = 35 };
        }
    }
}
