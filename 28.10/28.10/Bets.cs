using System;
using System.Collections.Generic;
using System.Text;

namespace _28._10
{
    class Bets: IBets
    {
        IMatchesForBet BetMatch = new MatchesForBet();
      public void Guide()
      {
            Console.WriteLine("BET RULES: '1' for HOME club to WIN");
            Console.WriteLine("BET RULES: '2' for GUESt club to WIN");
            Console.WriteLine("BET RULES: '0' for DRAW");
      }
       public  void BET()
        {
            Console.WriteLine("Today's matches:");
            Console.WriteLine("Pres 1) for Premier League matches");
            Console.WriteLine("Pres 2) for LaLiga League matches");
            Console.WriteLine("Pres 3) for Bundes League matches");
            Console.WriteLine("Pres 4) for Seria A matches");

            int Bet = int.Parse(Console.ReadLine());
            switch(Bet)
            {
                case 1:
                    Console.WriteLine("You chose Premier League matches");
                    BetMatch.PremierLieagueMatches();
                    break;
                    
                case 2:
                    Console.WriteLine("You chose La Liga League matches");
                    BetMatch.LaLigaMatches();
                    break;

                case 3:
                    Console.WriteLine("You chose Bundes League matches");
                    BetMatch.BundesLieagueMatches();
                    break;

                case 4:
                    Console.WriteLine("You chose Seria A League matches");
                    BetMatch.SeriaAMatches();
                    break;
            }
        }
    }
}
