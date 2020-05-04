using System;

namespace Variables
{
    class Decisions
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Utils.GetNumber("Enter a number 1: ");
            num2 = Utils.GetNumber("Enter a number 2: ");
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}", num2, num1);
            }

            string gender = Utils.GetInput("Is the baby a boy or girl? ");
            if (gender.Equals("girl"))
            {
                Console.WriteLine("It's a girl!");
            }
            else if (gender.Equals("boy"))
            {
                Console.WriteLine("It's a boy!");
            }
            else
            {
                Console.WriteLine("It's going to be a surprise!");
            }

            string nGender = Utils.GetInput("is the baby a 'B' or a 'G'? ");
            string msg = "Congrats its a ";
            msg += (nGender.Equals("B", StringComparison.OrdinalIgnoreCase)) ? "boy" : "girl";

            int num = Utils.GetNumber("Enter a number ");
            Console.WriteLine("The number is " + (num % 2 == 0 ? "even" : "odd"));

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
