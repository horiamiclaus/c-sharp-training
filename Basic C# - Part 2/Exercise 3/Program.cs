using System;

class Program
{
    static void Main()
    {
        int count = 0;   
        int number = 2; 

        while (count < 47)
        {
            if (IsPrime(number))
            {
                count++;
            }

            number++;
        }

        Console.WriteLine("The 47th prime number is: " + (number - 1));
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}