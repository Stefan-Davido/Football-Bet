using System;
using System.Collections.Generic;
using System.Text;

namespace _28._10
{
    public class Leagues
    {
        public static void League(int league)
        {
            Strings strings = new Strings();
            ConsoleKeyInfo cki;
            switch (league)
            {
                case 1:
                    Console.WriteLine("The stats of the Premier League are:");
                    foreach (int i in Enum.GetValues(typeof(Premier)))
                    {
                        Console.Write($"{Enum.GetName(typeof(Premier), i)}");
                        Console.WriteLine($" {i}");
                    }
                    break;
                case 2:
                    Console.WriteLine("The stats of the laLiga are:");
                    foreach (int i in Enum.GetValues(typeof(LaLiga)))
                    {
                        Console.Write($"{Enum.GetName(typeof(LaLiga), i)}");
                        Console.WriteLine($" {i}");
                    }       
                    break;
                case 3:
                    Console.WriteLine("The stats of the Bundes League are:");
                    foreach (int i in Enum.GetValues(typeof(BundesLeague)))
                    {
                        Console.Write($"{Enum.GetName(typeof(BundesLeague), i)}");
                        Console.WriteLine($" {i}");
                    }
                    break;
                case 4:
                    Console.WriteLine("The stats of the Seria A are:");
                    foreach (int i in Enum.GetValues(typeof(SeriaA)))
                    {
                        Console.Write($"{Enum.GetName(typeof(SeriaA), i)}");
                        Console.WriteLine($" {i}");
                    }
                    break;
                case 5:
                    do
                    {
                        cki = Console.ReadKey();
                        Console.WriteLine("*** \n");
                    }
                    while (cki.Key != ConsoleKey.Escape);

                    break;

            }
        }
    }
}
