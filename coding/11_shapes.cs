using System;

class Rectangle 
{
    public double Area(double length, double width)
    {
        return length * width;
    }
    public double Perimeter(double length, double width)
    {
        return 2 * (length + width);
    }
}

class Polygon
{
    static void Main() 
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Rectangle obj = new Rectangle();

        Console.WriteLine("Area of Rectangle: " + obj.Area(length, width));       // ✅
        Console.WriteLine("Perimeter of Rectangle: " + obj.Perimeter(length, width)); // ✅
    }
}