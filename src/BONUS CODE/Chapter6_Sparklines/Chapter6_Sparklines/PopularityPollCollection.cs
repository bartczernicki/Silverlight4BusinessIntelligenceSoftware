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
using System.Globalization;
using System.Collections.Generic;

namespace Chapter6_Sparklines
{
    public static class WidgetPopularityPollCollection
    {
        /// <summary>
        /// Returns a stream of popularity polls.
        /// </summary>
        /// <returns>A stream of popularity polls.</returns>
        public static IEnumerable<PopularityPoll> GetWidgets()
        {
            yield return new PopularityPoll { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Percent = 75 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Percent = 90 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Percent = 120 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Percent = 20 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Percent = 42 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Percent = 43 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Percent = 43 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), Percent = 47 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), Percent = 45 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), Percent = 40 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/19/2008", CultureInfo.InvariantCulture), Percent = 39 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/17/2008", CultureInfo.InvariantCulture), Percent = 42 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/16/2008", CultureInfo.InvariantCulture), Percent = 43 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/15/2008", CultureInfo.InvariantCulture), Percent = 42 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/12/2008", CultureInfo.InvariantCulture), Percent = 47 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/10/2008", CultureInfo.InvariantCulture), Percent = 43 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/7/2008", CultureInfo.InvariantCulture), Percent = 38 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/3/2008", CultureInfo.InvariantCulture), Percent = 39 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/2/2008", CultureInfo.InvariantCulture), Percent = 41 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/1/2008", CultureInfo.InvariantCulture), Percent = 41 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/28/2008", CultureInfo.InvariantCulture), Percent = 44 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/26/2008", CultureInfo.InvariantCulture), Percent = 49 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/25/2008", CultureInfo.InvariantCulture), Percent = 42 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/22/2008", CultureInfo.InvariantCulture), Percent = 40 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/19/2008", CultureInfo.InvariantCulture), Percent = 41 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/12/2008", CultureInfo.InvariantCulture), Percent = 46 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/11/2008", CultureInfo.InvariantCulture), Percent = 40 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/10/2008", CultureInfo.InvariantCulture), Percent = 41 };
            yield return new PopularityPoll { Date = DateTime.Parse("7/9/2008", CultureInfo.InvariantCulture), Percent = 39 };
        }

        public static IEnumerable<PopularityPoll> GetWiskers()
        {
            yield return new PopularityPoll { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Percent = -1 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Percent = 0 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/29/2008", CultureInfo.InvariantCulture), Percent = 0 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/28/2008", CultureInfo.InvariantCulture), Percent = -1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/27/2008", CultureInfo.InvariantCulture), Percent = -1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/26/2008", CultureInfo.InvariantCulture), Percent = -1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/25/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/24/2008", CultureInfo.InvariantCulture), Percent = 1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/23/2008", CultureInfo.InvariantCulture), Percent = 0 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/22/2008", CultureInfo.InvariantCulture), Percent = -1 };
            yield return new PopularityPoll { Date = DateTime.Parse("8/21/2008", CultureInfo.InvariantCulture), Percent = -1 };
        }
    }
}
