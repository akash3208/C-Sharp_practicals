using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] arr = new int[3];

            Console.WriteLine("Enter index:");
            int index = Convert.ToInt32(Console.ReadLine());

            arr[index] = 100;

            Console.WriteLine("Value stored successfully.");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Error: Invalid index!");
        }
        catch (Exception e)
        {
            Console.WriteLine("General Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }

        Console.WriteLine("End of program.");
    }
}