using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class HomeWork_1
    {

        static void Main(string[] args)
        {
            // Number 4
            int year = Utils.GetNumber("Enter a year ");
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year!");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year!");
            }

            //Number 6
            int m;
            m = Utils.GetNumber("Enter a number: ");

            if (m > 0)
            {
                Console.WriteLine("The vlaue on n is 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("The value of n is 0");
            }
            else
            {
                Console.WriteLine("The value of n is -1");
            }

            //Number 7
            int num = Utils.GetNumber("Enter your height in centimeters: ");

            if (num < 92)
            {
                Console.WriteLine("You are a hobbit!");
            }
            else if (num < 122)
            {
                Console.WriteLine("You are a dwarf!");
            }
            else if (num < 183)
            {
                Console.WriteLine("You are a human/elf!");
            }
            else
            {
                Console.WriteLine("You are a troll!");
            }

            //Number 8
            int num1, num2, num3;
            num1 = Utils.GetNumber("Enter number 1: ");
            num2 = Utils.GetNumber("Enter number 2: ");
            num3 = Utils.GetNumber("Enter number 3: ");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the largest!");
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " is the largest!");
            }
            else
            {
                Console.WriteLine(num3 + " is the largest!");
            }

            //Number 13
            int temp;
            temp = Utils.GetNumber("Enter a temp: ");
            if (temp < 0)
            {
                Console.WriteLine("Freezing");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Very Cold");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Cold");
            }
            else if (temp < 30)
            {
                Console.WriteLine("Normal");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Very Hot");
            }

            //Number 14
            int side1, side2, side3;
            side1 = Utils.GetNumber("Side 1: ");
            side2 = Utils.GetNumber("Side 2: ");
            side3 = Utils.GetNumber("Side 3: ");

            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("It is an Eguilateral!");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("It is an Isosceles!");
            }
            else if (side1 != side2 && side1 != side3)
            {
                Console.WriteLine("Its is a Scalene!");
            }

            //Number 15
            int sideOne, sideTwo, sideThree, sum;
            sideOne = Utils.GetNumber("Side 1 ");
            sideTwo = Utils.GetNumber("Side 2 ");
            sideThree = Utils.GetNumber("Side 3 ");
            sum = sideOne + sideTwo + sideThree;

            if (sum == 180)
            {
                Console.WriteLine("You can make it into a triangle!");
            }
            else
            {
                Console.WriteLine("Try agian! Total of angles need to add up to 180!");
            }

            //Number 16
            string letter = Utils.GetInput("Enter a letter: ");

            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine(letter + " is a vowel!");
            }
            else
            {
                Console.WriteLine(letter + " is a consonant!");
            }

            //Number 22
            string month = Utils.GetInput("Enter the first 3 letters of a month: ");
            int monthNumber;
            
                monthNumber = month switch
                {
                    "jan" => 1,
                    "feb" => 2,
                    "mar" => 3,
                    "apr" => 4,
                    "may" => 5,
                    "jun" => 6,
                    "jul" => 7,
                    "aug" => 8,
                    "sep" => 9,
                    "oct" => 10,
                    "nov" => 11,
                    "dec" => 12,
                    _ => 0,
                };
                Console.WriteLine(month + " is the " + monthNumber + " month of the year.");
            

            //Number 23
            string mon = Utils.GetInput("Enter a month number: ");
            int monthDays;
            
                monthDays = mon switch
                {
                    "1" => 31,
                    "2" => 28,
                    "3" => 31,
                    "4" => 30,
                    "5" => 31,
                    "6" => 30,
                    "7" => 31,
                    "8" => 31,
                    "9" => 30,
                    "10" => 31,
                    "11" => 30,
                    "12" => 31,
                    _ => 0,
                };
                Console.WriteLine(mon + " has " + monthDays + " days in the month.");
            
        }
    }
}
