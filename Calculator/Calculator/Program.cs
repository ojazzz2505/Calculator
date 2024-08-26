using System;
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            // Convert the input string to a decimal
            decimal FirstNum = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the second number:");
            // Convert the input string to a decimal
            decimal SecondNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("------------------------");

            Console.WriteLine("Addition - a\nSubtraction - s\nMultiplication - m\nDivision - d\nModulus - M");

            Console.WriteLine("------------------------");

            string choice = Console.ReadLine();

            if (choice == "a")
            {
                Console.WriteLine("Result: " + (FirstNum + SecondNum));
            }
            else if (choice == "s")
            {
                Console.WriteLine("Result: " + (FirstNum - SecondNum));
            }
            else if (choice == "m")
            {
                Console.WriteLine("Result: " + (FirstNum * SecondNum));
            }
            else if (choice == "d")
            {
                if (SecondNum != 0)
                {
                    Console.WriteLine("Result: " + (FirstNum / SecondNum));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else if (choice == "M")
            {
                if (SecondNum != 0)
                {
                    Console.WriteLine("Result: " + (FirstNum % SecondNum));
                }
                else
                {
                    Console.WriteLine("Error: Modulus by zero.");
                }
            }
            else
            {
                Console.WriteLine("Choice was invalid!");
            }

            Console.ReadLine();
        }


    }
}

