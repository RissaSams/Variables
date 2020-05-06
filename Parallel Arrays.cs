using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class Parallel_Arrays
    {
        static void Main(string[] args)
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "817-555,1334", "817-555-3882", "972-555-8211", "469-555-1617", "817-555-2803" };
            string strSearch;

            strSearch = Utils.GetInput("Type a name to search for in the phone book: ");
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i].IndexOf(strSearch) >= 0)
                {
                    Console.WriteLine($"{Names[i]} = {Phone[i]}");
                }
            }
        }
    }
}
