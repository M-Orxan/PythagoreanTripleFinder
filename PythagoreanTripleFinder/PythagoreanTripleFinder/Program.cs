using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTripleFinder
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pythagorean Triple Finder");
            Console.WriteLine("A Pythagorean triple consists of three positive integers a, b, and c, such that a^2 + b^2 = c^2.");
            Console.WriteLine();
            bool playAgain = true;

            while (playAgain)
            {


                Console.WriteLine("Enter the first number:");

                string input1 = Console.ReadLine();

                int number1 = ConvertUserInputToInteger(input1);
                Console.WriteLine();
                Console.WriteLine("Enter the second number:");

                string input2 = Console.ReadLine();

                int number2 = ConvertUserInputToInteger(input2);

                Console.WriteLine();

                Console.WriteLine("Enter the third number:");

                string input3 = Console.ReadLine();

                int number3 = ConvertUserInputToInteger(input3);
                Console.WriteLine();

                bool isPythagoreanTriple = CheckPythagoreanTriple(number1, number2, number3);

                if (isPythagoreanTriple)
                {
                    Console.WriteLine("It's PythagoreanTriple");
                }
                else
                {
                    Console.WriteLine("It's not PythagoreanTriple");

                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? Yes or no:");

                string answer = Console.ReadLine();

                playAgain = Continuity(answer);

                Console.WriteLine();


            }

            Console.WriteLine("Thanks for playing!");


        }

        static int ConvertUserInputToInteger(string input)
        {

            int result;

            while (!int.TryParse(input, out result) || result < 0)
            {
                if (result < 0)
                {
                    Console.WriteLine("Only positive numbers. Try again:");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again:");
                    input = Console.ReadLine();
                }




            }

            return result;
        }

        static bool CheckPythagoreanTriple(int number1, int number2, int number3)
        {



            if ((Math.Pow(number1, 2) + Math.Pow(number2, 2) == Math.Pow(number3, 2)) || (Math.Pow(number1, 2) + Math.Pow(number3, 2) == Math.Pow(number2, 2)) || (Math.Pow(number2, 2) + Math.Pow(number3, 2) == Math.Pow(number1, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        static bool Continuity(string input)
        {

            bool isValid = false;
            bool shouldContinue = false;

            while (!isValid)
            {
                if (input.ToLower() == "yes")
                {
                    isValid = true;
                    shouldContinue = true;
                }
                else if (input.ToLower() == "no")
                {
                    isValid = true;

                }
                else
                {
                    Console.WriteLine("Invalid chocie. Try again:");
                    input = Console.ReadLine();
                }
            }

            return shouldContinue;





        }
    }
}
