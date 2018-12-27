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

namespace Chapter6_WordSizedBarCharts
{
    public static class PointCollection
    {
        public static IEnumerable<GoalDiff> GetGoalDiffTeam1()
        {
            yield return new GoalDiff { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Diff = 2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Diff = 3 };
            yield return new GoalDiff { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Diff = 0 };
            yield return new GoalDiff { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Diff = -1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Diff = 2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/1/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Diff = 2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Diff = 0 };
            yield return new GoalDiff { Date = DateTime.Parse("8/29/2008", CultureInfo.InvariantCulture), Diff = -1 };
            yield return new GoalDiff { Date = DateTime.Parse("8/28/2008", CultureInfo.InvariantCulture), Diff = 3 };
        }

        public static IEnumerable<GoalDiff> GetGoalDiffTeam2()
        {
            yield return new GoalDiff { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Diff = 0 };
            yield return new GoalDiff { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Diff = 1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Diff = -1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/1/2008", CultureInfo.InvariantCulture), Diff = 2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Diff = 2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Diff = 4 };
            yield return new GoalDiff { Date = DateTime.Parse("8/29/2008", CultureInfo.InvariantCulture), Diff = 3 };
            yield return new GoalDiff { Date = DateTime.Parse("8/28/2008", CultureInfo.InvariantCulture), Diff = 3 };
        }

        public static IEnumerable<GoalDiff> GetGoalDiffTeam3()
        {
            yield return new GoalDiff { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Diff = -1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Diff = 4 };
            yield return new GoalDiff { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Diff = 1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/1/2008", CultureInfo.InvariantCulture), Diff = -4 };
            yield return new GoalDiff { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Diff = 4 };
            yield return new GoalDiff { Date = DateTime.Parse("8/29/2008", CultureInfo.InvariantCulture), Diff = 3 };
            yield return new GoalDiff { Date = DateTime.Parse("8/28/2008", CultureInfo.InvariantCulture), Diff = 0 };
        }

        public static IEnumerable<GoalDiff> GetGoalDiffTeam4()
        {
            yield return new GoalDiff { Date = DateTime.Parse("9/6/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/5/2008", CultureInfo.InvariantCulture), Diff = 1 };
            yield return new GoalDiff { Date = DateTime.Parse("9/4/2008", CultureInfo.InvariantCulture), Diff = 0 };
            yield return new GoalDiff { Date = DateTime.Parse("9/3/2008", CultureInfo.InvariantCulture), Diff = 0 };
            yield return new GoalDiff { Date = DateTime.Parse("9/2/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("9/1/2008", CultureInfo.InvariantCulture), Diff = -2 };
            yield return new GoalDiff { Date = DateTime.Parse("8/31/2008", CultureInfo.InvariantCulture), Diff = -3 };
            yield return new GoalDiff { Date = DateTime.Parse("8/30/2008", CultureInfo.InvariantCulture), Diff = -4 };
            yield return new GoalDiff { Date = DateTime.Parse("8/29/2008", CultureInfo.InvariantCulture), Diff = 3 };
            yield return new GoalDiff { Date = DateTime.Parse("8/28/2008", CultureInfo.InvariantCulture), Diff = -2 };
        }
    }
}
