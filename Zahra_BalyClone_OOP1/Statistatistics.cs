using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Statistatistics
    {
        public static void ReportStatistics()
        {
            Console.WriteLine("Generating statistics report...");
            Console.WriteLine($"Total Amount: {FinanceManager.totalAmount}");
            Console.WriteLine("Trip Statistics:");
            // and all the other details
        }
    }
}
