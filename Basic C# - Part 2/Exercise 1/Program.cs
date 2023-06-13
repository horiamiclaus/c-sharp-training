using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int number);

            if (success)
            {
                if (number % 7 == 0 && number % 11 == 0)
                {
                    Console.WriteLine(number + " is divisible by 7 and 11.");
                }
                else
                {
                    Console.WriteLine(number + " is not divisible by 7 and 11.");
                }
            }
            else
            {
                Console.WriteLine("Error.Please enter a valid number");
            }
        }
    }
}