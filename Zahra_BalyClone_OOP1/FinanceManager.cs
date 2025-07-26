using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class FinanceManager
    {
        public static double totalAmount = 0.0;
        public static void CalculateAmount()
        {

            // Calculate total amount from trips
            totalAmount += Trip.Price;

            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }
}
