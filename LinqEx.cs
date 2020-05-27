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
            //Examples1();
            //Examples2();
            //Examples3();
            //Examples4();
        }

        private static void Examples1()
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

            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

        }

        private static void Examples2()
        {
            int[] scores = { 3, 3, 32, 5, 2, 2, 5, 24737, 23445, 234, 435, 562, 12, 5876, 69, 096, 567, 567, 768, 58, 4 };
            string[] classes = { "Java", "C#", "SQL", "HTML", "JavaScript", "Node.js", "Project1", "Agile" };

            var high = scores.Max();
            var little = classes.Min();
            var lastClass = classes.Max();

            var sum = scores.Sum();
            var ave = scores.Average();
            var cnt = scores.Count();
            var total = scores.Aggregate((score, total) => total += score);
            var first = scores.First();
            var last = scores.Last();

            var any = classes.Any(c => c.Length < 4);
            var all = classes.All(c => c.Contains("s"));
            var contain = classes.Contains("Java");

            var uniq = scores.Distinct();

            var mtoZ = classes.Where(course => course.CompareTo("M") >= 0);

            var classList = classes.OrderBy(c => c);
            var highScores = scores.Where(score => score > 200).OrderBy(score => score).Reverse();

            int[] bigNums = { 34521, 51454, 12341, 35673562, 134341, 76858, 1341, 5151 };
            string[] littleWords = { "to", "in", "at", "by", "of", "on", "it" };
            // what is the biggest number
            var big = bigNums.Max();
            Console.WriteLine($"The biggest number is {big}.");
            // what is the average of all numbes
            var avg = bigNums.Average();
            Console.WriteLine($"The average is {avg}.");
            // create a list of words that start with "o"
            var startO = littleWords.Where(l => l.StartsWith("o"));
            Console.WriteLine($"These words start with 'o' {startO}");
            // how many words are in the array
            var howMany = littleWords.Count();
            Console.WriteLine($"There are {howMany} words in the array.");
            // what is the 'smallest' word?
            var smallest = littleWords.OrderBy(l => l).First();
            Console.WriteLine($"The fist word is {smallest}.");

        }

        private static void Examples3()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            int seconds = now.Second;
            int hours = now.Hour;

            if (seconds < 15)
            {
                Console.WriteLine($"{seconds} is less than 15!");
                if (seconds >= 15 && seconds <= 45)
                {
                    Console.WriteLine($"{seconds} is in the middle!");
                    if (seconds > 45)
                    {
                        Console.WriteLine($"{seconds} is more than 45!");
                    }
                }
            }
            if (seconds % 4 == 0)
            {
                Console.WriteLine($"{seconds} seconds is divisible by 4.");
            }
            else
            {
                Console.WriteLine($"{seconds} seconds is NOT divisible by 4.");
            }
                        
            for (int h = hours; h < seconds; h++)
            {
                Console.WriteLine(h);
            }
        }

        private static void Examples4()
        {

            int[] nums = { 3, 4, 2, 4, 5, 6, 32, 9, 4, 6, 76, 8, 432, 4, 2, 5 };
            int[] sub = { 32, 5, 6, 2 };

            int max = nums.Max();
            var big = nums.Where(n => n > 10);
            var unique = nums.Distinct();
            var above10 = nums.Where(n => n > 10).Sum();
            var select = nums.Select(n => n > 10);
            var below16 = nums.Where(n => n < 16);
            double ave = below16.Average();
            bool anyOdds = below16.Any(n => n % 2 == 1);

            var any = nums.Any(n => n > 5);
            var all = nums.All(n => n > 0);
            var average = nums.Average();
            var contains = nums.Contains(9);
            var count = nums.Count();
            var distinct = nums.Distinct();
            var elementAt = nums.ElementAt(6);
            var except = nums.Except(sub);
            var first = nums.First();
            var last = nums.Last();
            var min = nums.Min();
            var orderBy = nums.OrderBy(n => n);
            var prepend = nums.Prepend(-1);
            var range = Enumerable.Range(-5, 5);
            var repeat = Enumerable.Repeat("Beetlejuice", 3);
            var reverse = nums.Reverse();
            var skip = nums.Skip(5);
            var skipLast = nums.SkipLast(5);
            var skipWhile = nums.SkipWhile(n => n != 9);
            var sum = nums.Sum();
            var take = nums.Take(5);
            var takeLast = nums.TakeLast(5);
            var takeWhile = nums.TakeWhile(n => n < 32);
            var where = nums.Where(n => n % 2 == 1);


        }
    }
}

