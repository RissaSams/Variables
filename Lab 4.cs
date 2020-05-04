using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class Lab_4
    {
        static void Main(string[] args)
        {
            int nLargest, nSmallest, nCurrent;
            string strEntry;

            Console.Write("Enter a number: ");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number or Q to quit: ");
            strEntry = Console.ReadLine();

            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }
                Console.Write("Enter another number or Q to quit: ");
                strEntry = Console.ReadLine();
            }
            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was " + nSmallest + ".");

            Console.ReadLine();
        }
    }
}
