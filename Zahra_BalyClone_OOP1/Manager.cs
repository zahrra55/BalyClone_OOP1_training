using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Manager
    {
        public String Name;
        
        public static void AddDriver(string DriverID)
        {
            Console.WriteLine($"Driver {DriverID} added successfully.");
        }

        public static void RemoveDriver(string DriverID)
        {
            Console.WriteLine($"Driver {DriverID} removed successfully.");
        }

        public static void ViewAllDrivers()
        {
            Console.WriteLine("Displaying all drivers.");
        }

        public static void AddCar(string CarID)
        {
            Console.WriteLine($"Car {CarID} added successfully.");
        }
        public static void RemoveCar(string CarID)
        {
            Console.WriteLine($"Car {CarID} removed successfully.");
        }

        public static void ViewAllCars()
        {
            Console.WriteLine("Displaying all cars.");
        }

        public static void AddCustomer(string CustomerID)
        {
            Console.WriteLine($"Customer {CustomerID} added successfully.");
        }
        public static void RemoveCustomer(string CustomerID)
        {
            Console.WriteLine($"Customer {CustomerID} removed successfully.");
        }

        public static void ViewAllCustomers()
        {
            Console.WriteLine("Displaying all customers.");
        }

        public static void BlockUser(string UserID)
        {
            Console.WriteLine($"User {UserID} blocked successfully.");
        }
        public static void UnblockUser(string UserID)
        {
            Console.WriteLine($"User {UserID} unblocked successfully.");
        }
        public static void ViewAllBlockedUsers()
        {
            Console.WriteLine("Displaying all blocked users.");
        }


    }
}
