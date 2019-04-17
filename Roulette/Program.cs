using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to begin");
            Console.Read();
            GamePlay();
        }
        static void GamePlay()
        {
            Bets bets = new Bets();
            Random rand = new Random();
            int n = rand.Next(0, 38);
            Console.Write("Rolling ball .");
            Task.Delay(1000).Wait();
            Console.Write(".");
            Task.Delay(1000).Wait();
            Console.Write(".");
            Task.Delay(1000).Wait();

            bool zeros = bets.CheckZeros(n);

            if (zeros == true)
            {
                Console.ReadLine();
                Console.ReadLine();
                return;
            }
            if (zeros == false)
            {
                Console.WriteLine($"Ball landed on : {n}");
                bets.IndividualNumberBet(n);
                bets.EvenOdd(n);
                bets.RedOrBlack(n, bets.RedNumbers, bets.BlackNumbers);
                bets.LowOrHigh(n);
                bets.Dozens(n);
                bets.Columns(n);
                bets.Street(n);
                bets.DoubleStreet(n);
                bets.Split(n);
                bets.Corner(n);
                Console.ReadLine();
            }
            Console.WriteLine("Play again? y/n [n]:");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.Clear();
                GamePlay();
            }
            else
                return;
        }
    }
}
