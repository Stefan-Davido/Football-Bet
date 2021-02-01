using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _28._10
{
    class UserID : IUserID
    {
        private string Name;
        private DateTime Date;
        private double Transaction;
        private string City;
        private string Country;

        public UserID()
        {
            Name = "";
            Date = DateTime.Now;
            Transaction = 0.0;
            City = "";
            Country = "";
        }
        public UserID(string name, DateTime date, double transaction, string city, string country)
        {
            Name = name;
            Date = date;
            Transaction = transaction;
            City = city;
            Country = country;
        }
        public void ID(string Name, double Transaction, string City, string Country)
        {
            Console.WriteLine($" User name:{Name}");
            Console.WriteLine($" User Transaction:{Transaction}");
            Console.WriteLine($" User location:{City},{Country}");
            Console.WriteLine($" Todays date:{Date.Date}");
        }
    }   
}
