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
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3_WorkingWithBusinessData
{
    public class BMIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Stop processing if the value is not of type IEnumerable<Person>
            if ((value is IEnumerable<Person>) == false)
                return -1;

            // Calculate the BMI
            double aggregate = 0.0;
            IEnumerable<Person> people = value as IEnumerable<Person>;

            switch (parameter.ToString())
            {
                case "AVG":
                    // aggregate the data finding the average BMI calculation
                    aggregate = people.Average(p => p.Weight * 4.88 / (p.Height * p.Height));
                    break;
                case "MIN":
                    // aggregate the data finding the minimum BMI calculation
                    aggregate = people.Min(p => p.Weight * 4.88 / (p.Height * p.Height));
                    break;
                case "MAX":
                    // aggregate the data finding the maximum BMI calculation
                    aggregate = people.Max(p => p.Weight * 4.88 / (p.Height * p.Height));
                    break;
                default:
                    if (parameter.ToString().StartsWith("COUNT"))
                    {
                        // split the optional paramter and take the second item
                        // this item will let us know what body type we are looking for
                        string countType = parameter.ToString().Split(';')[1];

                        switch (countType)
                        {
                            case "OBESE":
                                // obese body type is BMI over 30
                                aggregate = people.Count(p => p.Weight * 4.88 / (p.Height * p.Height) > 30);
                                break;
                            case "NORMAL":
                                // normal body type is BMI between 18.5 and 25
                                aggregate = people.Count(p => p.Weight * 4.88 / (p.Height * p.Height)
                                    >= 18.5 && p.Weight * 4.88 / (p.Height * p.Height) < 25);
                                break;
                            case "UNDERWEIGHT":

                                // underweight body type is BMI is under 18.5
                                aggregate = people.Count(p => p.Weight * 4.88 / (p.Height * p.Height) < 18.5);
                                break;
                        }
                    }
                    break;
            }

            // return rounded string value
            return Math.Round(aggregate, 2).ToString();

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
