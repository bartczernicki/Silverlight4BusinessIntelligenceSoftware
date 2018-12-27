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

namespace Chapter6_WordSizedBarCharts
{
    public class Data
    {
        public IEnumerable<GoalDiff> GoalDiffTeam1
        {
            get
            {
                return PointCollection.GetGoalDiffTeam1();
            }
        }

        public IEnumerable<GoalDiff> GoalDiffTeam2
        {
            get
            {
                return PointCollection.GetGoalDiffTeam2();
            }
        }

        public IEnumerable<GoalDiff> GoalDiffTeam3
        {
            get
            {
                return PointCollection.GetGoalDiffTeam3();
            }
        }

        public IEnumerable<GoalDiff> GoalDiffTeam4
        {
            get
            {
                return PointCollection.GetGoalDiffTeam4();
            }
        }
    }
}
