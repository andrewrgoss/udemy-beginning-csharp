using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random(); 

            // Query the user
            Console.Write("Enter your guess Heads or Tails (H or T)");
            userGuess = Console.ReadLine();

            // Get a random number for the coin flip
            coin = rng.Next(0, 2);

            //0 = tails, 1 = heads
            if(coin == 0 && userGuess == "T")
            {
                Console.WriteLine("The coin flip was Tails, you win!");
            }
            else if (coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The coin flip was Heads, you win!");
            }
            else
            {
                if (coin == 0)
                {
                    Console.WriteLine("The coin flip was Tails, you lose!");
                }
                else
                {
                    Console.WriteLine("The coin flip was Heads, you lose!");
                }
            }

            Console.ReadLine();
        }
    }
}
