using System;
using System.Dynamic;

namespace _28._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Enter your transaction:");
            double transaction  = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your location(City):");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your location(Country):");
            string country = Console.ReadLine();

            IUserID userID = new UserID();
            userID.ID(name, transaction, city, country);
            Console.WriteLine(Strings.BigLine);

            Console.WriteLine("Press 1 for Premier's League table");
            Console.WriteLine("Press 2 for La Liga's table");
            Console.WriteLine("Press 3 for Bundes's League table");
            Console.WriteLine("Press 4 for Seria A's table");

            int league = int.Parse(Console.ReadLine());
            Leagues.League(league);
            Console.WriteLine(Strings.newLine);
            Console.WriteLine(Strings.BigLine);

            IBets letsBet = new Bets();
            letsBet.Guide();
            Console.WriteLine(Strings.BigLine);
            letsBet.BET();
            Console.WriteLine(Strings.BigLine);

            Main(args);            
        }
    }
}
