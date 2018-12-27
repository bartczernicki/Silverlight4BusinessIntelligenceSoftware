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

namespace Chapter9_ImplentingPredictiveAnalytics
{
    public static class MathHelper
    {
        public static double CalculatePoissonProbability(double mean, int numberOfSuccesses)
        {
            double result = (Math.Pow(mean, numberOfSuccesses)) * (Math.Pow(Math.E, -mean)) / Factorial(numberOfSuccesses);

            return result;
        }

        public static int Factorial(int x)
        {
            int factorial = 1;
            int i = 1;

            while (i <= x)
            {
                factorial *= i;
                i++;
            }

            return factorial;
        }
    }
}
