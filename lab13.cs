using System;

class Rectangle
{
    private double length;
    private double width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double FindArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length = " + length);
        Console.WriteLine("Width = " + width);
        Console.WriteLine("Area = " + FindArea());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();

        Console.WriteLine("Rectangle 1 (Default Constructor):");
        r1.Display();

        Console.WriteLine();

        Rectangle r2 = new Rectangle(10, 5);

        Console.WriteLine("Rectangle 2 (Parameterized Constructor):");
        r2.Display();
    }
}