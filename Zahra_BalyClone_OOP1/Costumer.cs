using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Costumer
    {
        public static string CostumerRate;
        // public string CostumerName;
        public static string CostumerType; // e.g., "Regular", "VIP", "Corporate"


        public static void BookRide(string RideID)
        {
            Console.WriteLine($"Ride {RideID} booked successfully.");
        }
        public static void CancelRide(string RideID)
        {
            Console.WriteLine($"Ride {RideID} cancelled successfully.");
        }
        public static void ViewRideHistory(string CostumerID)
        {
            Console.WriteLine($"Displaying ride history for customer {CostumerID}.");
        }
        public static void RateDriver(string DriverID, string Rating)
        {
            Console.WriteLine($"Driver {DriverID} rated with {Rating} stars.");
        }
        public static void ViewDriverDetails(string DriverID)
        {
            Console.WriteLine($"Displaying details for driver {DriverID}.");
        }
        public static void ViewCarDetails(string CarID)
        {
            Console.WriteLine($"Displaying details for car {CarID}.");
        }

        public static void StartTrip()
        {
            Console.WriteLine("Trip started successfully.");
        }
    }
}
