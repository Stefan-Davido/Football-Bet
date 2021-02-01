using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _28._10
{
    class MatchesForBet : IMatchesForBet
    {
        public void LaLigaMatches()
        {
            Console.WriteLine("Enter your cost:");
            double cost = int.Parse(Console.ReadLine());
            Console.WriteLine($"From your Transaction will be taken:{cost} euros");

            Console.WriteLine("Enter number of the match:");
            Console.WriteLine(" 200) Barcelona vs Real Betis");
            Console.WriteLine(" 201) Athletico Madrid vs Villareal");
            Console.WriteLine(" 202) Levante vs Sevilla");
            Console.WriteLine(" 203) Cadiz vs Getafe");

            int laLigaMatch = int.Parse(Console.ReadLine());
            switch (laLigaMatch)
            {
                case 200:
                    double BarcaWin = 1.55;
                    double BetisWin = 1.90;
                    double BRBDraw = 2.30;
                    Console.WriteLine("Barcelona vs Real Betis");
                    Console.WriteLine($" Bet for Barcelona to win:{BarcaWin}");
                    Console.WriteLine($" Bet for Real Betis to win:{BetisWin}");
                    Console.WriteLine($" Bet for Draw:{BRBDraw}");
                    Console.WriteLine("What is your bet?");

                    int BRBbet = int.Parse(Console.ReadLine());
                    switch (BRBbet)
                    {
                        case 1:
                            double ifBarcaWins = cost * BarcaWin;
                            Console.WriteLine($"Your tiket cost {ifBarcaWins}");
                            break;
                        case 2:
                            double ifBetisWins = cost * BetisWin;
                            Console.WriteLine($"Your ticket cost {ifBetisWins}");
                            break;
                        case 0:
                            double ifBRBDraw = cost * BRBDraw;
                            Console.WriteLine($"Your ticket cost {ifBRBDraw}");
                            break;
                    }
                    break;
                case 201:
                    double AthMWin = 1.50;
                    double VillWin = 1.95;
                    double AtMVillDraw = 2.10;
                    Console.WriteLine("Athletico Madrid vs Villareal");
                    Console.WriteLine($" Bet for Athletico Madrid to win:{AthMWin}");
                    Console.WriteLine($" Bet for Villareal to win:{VillWin}");
                    Console.WriteLine($" Bet for Draw:{AtMVillDraw}");
                    Console.WriteLine("What is your bet?");

                    int AtMVillbet = int.Parse(Console.ReadLine());
                    switch (AtMVillbet)
                    {
                        case 1:
                            double ifAthMWins = cost * AthMWin;
                            Console.WriteLine($"Your tiket cost {ifAthMWins}");
                            break;
                        case 2:
                            double ifVillWins = cost * VillWin;
                            Console.WriteLine($"Your ticket cost {ifVillWins}");
                            break;
                        case 0:
                            double ifAthMVillDraw = cost * AtMVillDraw;
                            Console.WriteLine($"Your ticket cost {ifAthMVillDraw}");
                            break;
                    }
                    break;
                case 202:
                    double LevWin = 2.10;
                    double SevWin = 1.45;
                    double LevSevDraw = 1.75;
                    Console.WriteLine("Levante vs Sevilla");
                    Console.WriteLine($" Bet for Levante to win:{LevWin}");
                    Console.WriteLine($" Bet for Sevilla to win:{SevWin}");
                    Console.WriteLine($" Bet for Draw:{LevSevDraw}");
                    Console.WriteLine("What is your bet?");

                    int LevSevBet = int.Parse(Console.ReadLine());
                    switch (LevSevBet)
                    {
                        case 1:
                            double ifLevWins = cost * LevWin;
                            Console.WriteLine($"Your tiket cost {ifLevWins}");
                            break;
                        case 2:
                            double ifSevWins = cost * SevWin;
                            Console.WriteLine($"Your ticket cost {ifSevWins}");
                            break;
                        case 0:
                            double ifALevSevDraw = cost * LevSevDraw;
                            Console.WriteLine($"Your ticket cost {ifALevSevDraw}");
                            break;
                    }
                    break;
                case 203:
                    double CadWin = 2.70;
                    double GetWin = 1.30;
                    double CadGetDraw = 2.20;
                    Console.WriteLine("Cadiz vs Getafe");
                    Console.WriteLine($" Bet for Cadiz to win:{CadWin}");
                    Console.WriteLine($" Bet for Getafe to win:{GetWin}");
                    Console.WriteLine($" Bet for Draw:{CadGetDraw}");
                    Console.WriteLine("What is your bet?");

                    int CadGetBet = int.Parse(Console.ReadLine());
                    switch (CadGetBet)
                    {
                        case 1:
                            double ifLevMwins = cost * CadWin;
                            Console.WriteLine($"Your tiket cost {ifLevMwins}");
                            break;
                        case 2:
                            double ifGetwins = cost * GetWin;
                            Console.WriteLine($"Your ticket cost {ifGetwins}");
                            break;
                        case 0:
                            double ifCadGetDraw = cost * CadGetDraw;
                            Console.WriteLine($"Your ticket cost {ifCadGetDraw}");
                            break;
                    }
                    break;
            }
        }
        public void PremierLieagueMatches()
        {
            Console.WriteLine("Enter your cost:");
            double cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of the match:");
            Console.WriteLine(" 100) Leichester vs Leeds");
            Console.WriteLine(" 101) Wolves vs WBA");
            Console.WriteLine(" 102) Liverpool vs Manchester United");
            Console.WriteLine(" 103) Arsenal vs Manchester City");


            int PremierMatch = int.Parse(Console.ReadLine());
            switch (PremierMatch)
            {
                case 100:
                    double LeiWin = 1.40;
                    double LeedsWin = 1.90;
                    double LeiLeedsDraw = 2.00;
                    Console.WriteLine("Leichester vs Leeds");
                    Console.WriteLine($" Bet for Leicester to win:{LeiWin}");
                    Console.WriteLine($" Bet for Leeds to win:{LeedsWin}");
                    Console.WriteLine($" Bet for Draw:{LeiLeedsDraw}");
                    Console.WriteLine("What is your bet?");

                    int LeiLeedsBet = int.Parse(Console.ReadLine());
                    switch (LeiLeedsBet)
                    {
                        case 1:
                            double ifLeiWins = cost * LeiWin;
                            Console.WriteLine($"Your tiket cost {ifLeiWins}");
                            break;
                        case 2:
                            double ifLeedsWins = cost * LeedsWin;
                            Console.WriteLine($"Your ticket cost {ifLeedsWins}");
                            break;
                        case 0:
                            double ifLeiLeedsDraw = cost * LeiLeedsDraw;
                            Console.WriteLine($"Your ticket cost {ifLeiLeedsDraw}");
                            break;
                    }
                    break;
                case 101:
                    double WolvWin = 1.35;
                    double WBAWin = 1.95;
                    double WolvWBADeraw = 2.10;
                    Console.WriteLine("Wolves vs WBA");
                    Console.WriteLine($" Bet for Wolves to win:{WolvWin}");
                    Console.WriteLine($" Bet for WBA to win:{WBAWin}");
                    Console.WriteLine($" Bet for Draw:{WolvWBADeraw}");
                    Console.WriteLine("What is your bet?");

                    int WolvWBABet = int.Parse(Console.ReadLine());
                    switch (WolvWBABet)
                    {
                        case 1:
                            double ifWolvWins = cost * WolvWin;
                            Console.WriteLine($"Your tiket cost {ifWolvWins}");
                            break;
                        case 2:
                            double ifWBAWins = cost * WBAWin;
                            Console.WriteLine($"Your ticket cost {ifWBAWins}");
                            break;
                        case 0:
                            double ifWolvWBADraw = cost * WolvWBADeraw;
                            Console.WriteLine($"Your ticket cost {ifWolvWBADraw}");
                            break;
                    }
                    break;
                case 102:
                    double LivWin = 1.50;
                    double ManUWin = 1.95;
                    double LivManUDraw = 1.85;
                    Console.WriteLine("Liverpool vs Manchester United");
                    Console.WriteLine($" Bet for Liverpool to win:{LivWin}");
                    Console.WriteLine($" Bet for Manchester United to win:{ManUWin}");
                    Console.WriteLine($" Bet for Draw:{LivManUDraw}");
                    Console.WriteLine("What is your bet?");

                    int LivManUBet = int.Parse(Console.ReadLine());
                    switch (LivManUBet)
                    {
                        case 1:
                            double ifLivWins = cost * LivWin;
                            Console.WriteLine($"Your tiket cost {ifLivWins}");
                            break;
                        case 2:
                            double ifManUWins = cost * ManUWin;
                            Console.WriteLine($"Your ticket cost {ifManUWins}");
                            break;
                        case 0:
                            double ifLivManUDraw = cost * LivManUDraw;
                            Console.WriteLine($"Your ticket cost {ifLivManUDraw}");
                            break;
                    }
                    break;
                case 103:
                    double ArsWin = 2.00;
                    double ManCWin = 1.40;
                    double ArsManCDraw = 2.20;
                    Console.WriteLine("Arsenal vs Manchester City");
                    Console.WriteLine($" Bet for Arsenal to win:{ArsWin}");
                    Console.WriteLine($" Bet for Manchester CIty to win:{ManCWin}");
                    Console.WriteLine($" Bet for Draw:{ArsManCDraw}");
                    Console.WriteLine("What is your bet?");

                    int ArsManCBet = int.Parse(Console.ReadLine());
                    switch (ArsManCBet)
                    {
                        case 1:
                            double ifArsWins = cost * ArsWin;
                            Console.WriteLine($"Your tiket cost {ifArsWins}");
                            break;
                        case 2:
                            double ifMAnCWins = cost * ManCWin;
                            Console.WriteLine($"Your ticket cost {ifMAnCWins}");
                            break;
                        case 0:
                            double ifArsManCDraw = cost * ArsManCDraw;
                            Console.WriteLine($"Your ticket cost {ifArsManCDraw}");
                            break;
                    }
                    break;
            }
        }
        public void BundesLieagueMatches()
        {
            Console.WriteLine("Enter your cost:");
            double cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of the match:");
            Console.WriteLine(" 300) Borrusia Dortmund vs Shalke04");
            Console.WriteLine(" 301) Bayern Leverkusen vs Köln");
            Console.WriteLine(" 302) Mayern Munich vs Hoffeinhaim");
            Console.WriteLine(" 303) Laipzig vs Ausburg");


            int BundesMatch = int.Parse(Console.ReadLine());
            switch (BundesMatch)
            {
                case 300:
                    double BVBWin = 1.55;
                    double S04Win = 1.90;
                    double BVBS04Draw = 2.20;
                    Console.WriteLine("Borrusia Dortmund vs Shalke04");
                    Console.WriteLine($" Bet for Borrusia Dortmund to win:{BVBWin}");
                    Console.WriteLine($" Bet for Shalke04 to win:{S04Win}");
                    Console.WriteLine($" Bet for Draw:{BVBS04Draw}");
                    Console.WriteLine("What is your bet?");

                    int BVBS04Bet = int.Parse(Console.ReadLine());
                    switch (BVBS04Bet)
                    {
                        case 1:
                            double iBVBWins = cost * BVBWin;
                            Console.WriteLine($"Your tiket cost {iBVBWins}");
                            break;
                        case 2:
                            double ifS04Wins = cost * S04Win;
                            Console.WriteLine($"Your ticket cost {ifS04Wins}");
                            break;
                        case 0:
                            double ifLBVBS04Draw = cost * BVBS04Draw;
                            Console.WriteLine($"Your ticket cost {ifLBVBS04Draw}");
                            break;
                    }
                    break;
                case 301:
                    double LvrWin = 1.50;
                    double KolnWin = 1.75;
                    double LvrKolnDraw = 1.90;
                    Console.WriteLine("Bayern Leverkusen vs Köln");
                    Console.WriteLine($" Bet for Leverkusen to win:{LvrWin}");
                    Console.WriteLine($" Bet for Köln to win:{KolnWin}");
                    Console.WriteLine($" Bet for Draw:{LvrKolnDraw}");
                    Console.WriteLine("What is your bet?");

                    int LvrKolnBet = int.Parse(Console.ReadLine());
                    switch (LvrKolnBet)
                    {
                        case 1:
                            double ifLvrWins = cost * LvrWin;
                            Console.WriteLine($"Your tiket cost {ifLvrWins}");
                            break;
                        case 2:
                            double ifKolnWins = cost * KolnWin;
                            Console.WriteLine($"Your ticket cost {ifKolnWins}");
                            break;
                        case 0:
                            double ifLvrKolnDraw = cost * LvrKolnDraw;
                            Console.WriteLine($"Your ticket cost {ifLvrKolnDraw}");
                            break;
                    }
                    break;
                case 302:
                    double BMWin = 1.40;
                    double HoffWin = 1.95;
                    double BMHoffDraw = 2.25;
                    Console.WriteLine("Mayern Munich vs Hoffeinhaim");
                    Console.WriteLine($" Bet for Mayern Munich to win:{BMWin}");
                    Console.WriteLine($" Bet for Hoffeinhaim  to win:{HoffWin}");
                    Console.WriteLine($" Bet for Draw:{BMHoffDraw}");
                    Console.WriteLine("What is your bet?");

                    int BMHoffBet = int.Parse(Console.ReadLine());
                    switch (BMHoffBet)
                    {
                        case 1:
                            double ifBMWins = cost * BMWin;
                            Console.WriteLine($"Your tiket cost {ifBMWins}");
                            break;
                        case 2:
                            double idHoffWins = cost * HoffWin;
                            Console.WriteLine($"Your ticket cost {idHoffWins}");
                            break;
                        case 0:
                            double ifBMHoffDraw = cost * BMHoffDraw;
                            Console.WriteLine($"Your ticket cost {ifBMHoffDraw}");
                            break;
                    }
                    break;
                case 303:
                    double LaiWin = 1.25;
                    double AusCWin = 2.50;
                    double LaiAusCDraw = 2.20;
                    Console.WriteLine("Laipzig vs Ausburg");
                    Console.WriteLine($" Bet for Laipzig to win:{LaiWin}");
                    Console.WriteLine($" Bet for Ausburg to win:{AusCWin}");
                    Console.WriteLine($" Bet for Draw:{LaiAusCDraw}");
                    Console.WriteLine("What is your bet?");

                    int LaiAusCBet = int.Parse(Console.ReadLine());
                    switch (LaiAusCBet)
                    {
                        case 1:
                            double ifLaiWins = cost * LaiWin;
                            Console.WriteLine($"Your tiket cost {ifLaiWins}");
                            break;
                        case 2:
                            double ifAusCWins = cost * AusCWin;
                            Console.WriteLine($"Your ticket cost {ifAusCWins}");
                            break;
                        case 0:
                            double ifLaiAusDraw = cost * LaiAusCDraw;
                            Console.WriteLine($"Your ticket cost {ifLaiAusDraw}");
                            break;
                    }
                    break;
            }
        }
        public void SeriaAMatches()
        {
            Console.WriteLine("Enter your cost:");
            double cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of the match:");
            Console.WriteLine(" 400) Milan vs Sassuolo");
            Console.WriteLine(" 401) Juventus vs Lazio");
            Console.WriteLine(" 402) Napoli vs Atalanta ");
            Console.WriteLine(" 403) Inter vs Roma");


            int SeriaAMatch = int.Parse(Console.ReadLine());
            switch (SeriaAMatch)
            {
                case 400:
                    double MilWin = 1.55;
                    double SassWin = 1.90;
                    double MilSassDraw = 2.10;
                    Console.WriteLine("Milan vs Sassuolo");
                    Console.WriteLine($" Bet for Milanto win:{MilWin}");
                    Console.WriteLine($" Bet for Sassuolo to win:{SassWin}");
                    Console.WriteLine($" Bet for Draw:{MilSassDraw}");
                    Console.WriteLine("What is your bet?");

                    int MilSassBet = int.Parse(Console.ReadLine());
                    switch (MilSassBet)
                    {
                        case 1:
                            double iMilWins = cost * MilWin;
                            Console.WriteLine($"Your tiket cost {iMilWins}");
                            break;
                        case 2:
                            double ifSassWins = cost * SassWin;
                            Console.WriteLine($"Your ticket cost {ifSassWins}");
                            break;
                        case 0:
                            double ifMilSassDraw = cost * MilSassDraw;
                            Console.WriteLine($"Your ticket cost {ifMilSassDraw}");
                            break;
                    }
                    break;
                case 401:
                    double JuvWin = 1.65;
                    double LazWin = 1.95;
                    double JuvLazDraw = 1.85;
                    Console.WriteLine("Juventus vs Lazio");
                    Console.WriteLine($" Bet for Juventus to win:{JuvWin}");
                    Console.WriteLine($" Bet for Lazio to win:{LazWin}");
                    Console.WriteLine($" Bet for Draw:{JuvLazDraw}");
                    Console.WriteLine("What is your bet?");

                    int JuvLazBet = int.Parse(Console.ReadLine());
                    switch (JuvLazBet)
                    {
                        case 1:
                            double ifJuvWins = cost * JuvWin;
                            Console.WriteLine($"Your tiket cost {ifJuvWins}");
                            break;
                        case 2:
                            double ifLazWins = cost * LazWin;
                            Console.WriteLine($"Your ticket cost {ifLazWins}");
                            break;
                        case 0:
                            double ifJuvLazDraw = cost * JuvLazDraw;
                            Console.WriteLine($"Your ticket cost {ifJuvLazDraw}");
                            break;
                    }
                    break;
                case 402:
                    double NapWin = 1.50;
                    double AtaWin = 1.75;
                    double NapAtaDraw = 1.65;
                    Console.WriteLine("Napoli vs Atalanta");
                    Console.WriteLine($" Bet for Napoli to win:{NapWin}");
                    Console.WriteLine($" Bet for Atalanta  to win:{AtaWin}");
                    Console.WriteLine($" Bet for Draw:{NapAtaDraw}");
                    Console.WriteLine("What is your bet?");

                    int NapAtaBet = int.Parse(Console.ReadLine());
                    switch (NapAtaBet)
                    {
                        case 1:
                            double ifNapWins = cost * NapWin;
                            Console.WriteLine($"Your tiket cost {ifNapWins}");
                            break;
                        case 2:
                            double iAtaWins = cost * AtaWin;
                            Console.WriteLine($"Your ticket cost {iAtaWins}");
                            break;
                        case 0:
                            double ifNapAtaDraw = cost * NapAtaDraw;
                            Console.WriteLine($"Your ticket cost {ifNapAtaDraw}");
                            break;
                    }
                    break;
                case 403:
                    double IntWin = 1.55;
                    double RomaCWin = 1.80;
                    double IntRomaCDraw = 1.90;
                    Console.WriteLine("Inter vs Roma");
                    Console.WriteLine($" Bet for Inter to win:{IntWin}");
                    Console.WriteLine($" Bet for Roma to win:{RomaCWin}");
                    Console.WriteLine($" Bet for Draw:{IntRomaCDraw}");
                    Console.WriteLine("What is your bet?");

                    int IntRomaBet = int.Parse(Console.ReadLine());
                    switch (IntRomaBet)
                    {
                        case 1:
                            double ifIntWins = cost * IntWin;
                            Console.WriteLine($"Your tiket cost {ifIntWins}");
                            break;
                        case 2:
                            double ifRomaWins = cost * RomaCWin;
                            Console.WriteLine($"Your ticket cost {ifRomaWins}");
                            break;
                        case 0:
                            double ifIntRomaDraw = cost * IntRomaCDraw;
                            Console.WriteLine($"Your ticket cost {ifIntRomaDraw}");
                            break;
                    }
                    break;
            }
        }
    }
}
