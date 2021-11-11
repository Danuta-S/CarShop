using System;

namespace CarShop.Library
{
    internal class UserOutput
    {
        public UserOutput()
        {
        }

        internal void UserOutputMethod()
        {
            Console.WriteLine("Please choose car operation");
            Console.WriteLine("1. Add car to the shop");
            Console.WriteLine("2. Find car by is available");
            Console.WriteLine("3. Find car by year");
            Console.WriteLine("4. Show list of all presented cars");
            Console.WriteLine("5. Buy a car");
        }

        internal void UserOutputMethod(int i)
        {
            Console.WriteLine("Please add car model:");
        }

        internal void UserOutputMethod(int i, int j)
        {
            Console.WriteLine("Add car color");
        }

        internal void UserOutputMethod(int i, int j, int a)
        {
            Console.WriteLine("Add car year");
        }

        internal void UserOutputMethod(int i, int j, int a, int b)
        {
            Console.WriteLine("Do you want to create more cars?(Yes/No)");
        }

        internal void UserOutputMethod(int i, int j, int a, int b, int c)
        {
            Console.WriteLine("Please provide car id from the car list");
        }
    }
}