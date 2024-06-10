using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[], args)
        {
            // Simple calculator program in C#
            int num1;
            int num2;
            int result;
            
            string answer;

            Console.WriteLine("Hello, welcome to the calculator!");
            Console.WriteLine("Please enter your first number: ");

            num1 = Convert.ToInt32(Console.ReadLine()); // convert the line to int.
            Console.WriteLine(num1);

            Console.WriteLine("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation do you want to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, or d for division.");

            answer = Console.ReadLine();
            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num1 / num2;
            }
            else 
            {
                Console.WriteLine("That is not a valid operation, please try again.");
            }

            System.Console.WriteLine("The result is " + result);
            System.Console.WriteLine("Thank you for calculating!");

            Console.ReadKey();
        }
    }
}