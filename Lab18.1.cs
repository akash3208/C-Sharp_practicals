using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;

            Console.WriteLine("Result: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error occurred: " + e.Message);
        }

        Console.WriteLine("Program continues...");
    }
}