using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year:");
        string input = Console.ReadLine();
        bool success = int.TryParse(input, out int year);

        if (success)
        {
            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}