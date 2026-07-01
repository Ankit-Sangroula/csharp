using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principle = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest (%): ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (Years): ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principle * rate * time) / 100;

        Console.WriteLine("Principal = " + principle);
        Console.WriteLine("Rate = " + rate);
        Console.WriteLine("Time = " + time);
        Console.WriteLine("Simple Interest = " + simpleInterest);
    }
}