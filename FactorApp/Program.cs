using System;
using FactorLogic;

namespace FactorApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Factorization App!");
            Console.WriteLine("Please enter a number to factor:");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 2)
            {
                var factors = Factorizer.Factor(number);
                Console.WriteLine($"- The factors of {number} are: {string.Join(" x ", factors)}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer (2 or greater).");
            }
        }
    }
}

