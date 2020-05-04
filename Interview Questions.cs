using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class Interview_Questions
    {
        static void Main(string[] args)
        {
            InterviewQ1();
        }

        private static void InterviewQ1()
        {
            string phrase = Utils.GetInput("Enter a sentance: ");
            string[] words = phrase.Split(" ");
            int bigWordLength = words[0].Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > bigWordLength)
                {
                    bigWordLength = words[i].Length;
                }
            }
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            foreach (var word in words)
            {
                Console.Write("*");
                Console.Write(word.PadLeft(bigWordLength, ' '));
                Console.Write(word.PadRight(bigWordLength, ' '));
                Console.WriteLine("*");
            }
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
        }
    }
}
