using System;

interface Exam
{
    bool Pass(int mark);
}

interface Classify
{
    string Division(int average);
}

class Result : Exam, Classify
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No division";
    }
}

class Program
{
    static void Main()
    {
        Result r = new Result();

        int marks, avg;

        Console.Write("Enter Marks: ");
        marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Average: ");
        avg = Convert.ToInt32(Console.ReadLine());

        if (r.Pass(marks))
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");

        Console.WriteLine("Division: " + r.Division(avg));
    }
}