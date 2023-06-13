using System;

class Program
{
    static void Main()
    {
        int limit = 1000;  
        int sum = 0;      
        int fib1 = 1;     
        int fib2 = 1;     

        while (fib1 <= limit)
        {
            if (fib1 % 2 == 0)
            {
                sum += fib1;  
            }

            int temp = fib1 + fib2;  
            fib1 = fib2;
            fib2 = temp;
        }

        Console.WriteLine("The sum of even-valued Fibonacci terms below 1000 is: " + sum);
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}