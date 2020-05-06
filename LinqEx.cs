using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class LinqEx
    {
        static void Main(string[] args)
        {
            //  let's play with arrays of numbers using the LINQ statements
            double total;
            double biggest, average;
            double[] numbers = { 12, 3, 2, 743, 6, 302, 2242, 5, 3312, 3, 621, 2, 5, 4 };

            //  get the average number of all elements in the array
            average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            biggest = numbers.Max();
            Console.WriteLine($"The biggest number is: {biggest}");

            var rev = numbers.Reverse();
            var distinct = numbers.Distinct();

            var evens = numbers.Where(num => num % 2 == 0);

            total = numbers.Aggregate((num, tot) => tot *= num);
            Console.WriteLine($"The product of all numbers is {total}");
            
            total = numbers.Aggregate((num, tot) => tot += num);
            total = numbers.Sum();
            Console.WriteLine($"The sum of all number is {total}");

            foreach  (int num in evens)
            {
                Console.WriteLine(num);
            }
        }
    }
}
