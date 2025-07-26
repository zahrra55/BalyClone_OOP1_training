using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Trip
    {
        public static string InitialPoint;
        public static string EndPoint;
        public static double Price;
        public static string time;
        public static string TripType;

        public static int Rate(int stars)
        {
            return stars;
        }

        public static double Discount(double percentage)
        {
            return Price *= percentage;
        }

        public static double CalculatePrice(double Price, double distance, double Time)
        {
            return Price + (distance * Time);
        }
    }
}
