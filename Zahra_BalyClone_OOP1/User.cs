﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class User
    {
        public static String Name;
        
        public static void Login(String username, String password)
        {
            // Logic to handle user login
            Console.WriteLine($"User {username} logged in successfully.");
        }
        public static void SignUp(String username, String password, String email)
        {
            // Logic to handle user registration
            Console.WriteLine($"User {username} registered successfully with email {email}.");
        }
        public static void Logout(String username)
        {
            // Logic to handle user logout
            Console.WriteLine($"User {username} logged out successfully.");
        }
        public static void ModifyTrip(string TripID)
        {
            Console.WriteLine($"Trip {TripID} modified successfully.");
        }
    }
}
