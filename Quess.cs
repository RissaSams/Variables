using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class Quess
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string quess, playAgain;
            int hidden, nCurrent;
            string hotCold = "";
            do
            {
                hidden = rand.Next(100);
                // Console.WriteLine(hidden);
                Console.Write("Quess the number: ");
                quess = Console.ReadLine();
                while (true)
                {
                    nCurrent = Convert.ToInt32(quess);

                    int diff = Math.Abs(nCurrent - hidden);
                    if (diff > 10)
                    {
                        hotCold = "Ice cold!";
                    }
                    else if (diff > 5)
                    {
                        hotCold = "Getting warmer!";
                    }
                    else if (diff > 3)
                    {
                        hotCold = "Getting hotter!";
                    }
                    else
                    {
                        hotCold = "On fire!";
                    }

                    if (nCurrent < hidden)
                    {
                        Console.WriteLine("Too cold! Try Again! ");
                        Console.WriteLine(hotCold);
                    }
                    else if (nCurrent > hidden)
                    {
                        Console.WriteLine("Too hot! Try again! ");
                        Console.WriteLine(hotCold);
                    }
                    else
                    {
                        Console.WriteLine("Just right! Congrats! ");
                        Console.WriteLine("WOuld you like to play again? ");
                        playAgain = Console.ReadLine();
                        break;
                    }
                    Console.Write("Enter another quess: ");
                    quess = Console.ReadLine();
                }
            } while (playAgain.ToUpper() == "Y");
        }
    }
}
