using System;

class FactorialExample
{
    public static int CalculateAge(int birthYear , int currentYear)
    {
        return currentYear - birthYear;
    }
}

class AgeCalculator
{
    static void Main()
    {
        Console.Write("Enter Current year: ");
        int currentYear = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine()); 

        int age = FactorialExample.CalculateAge(currentYear ,birthYear); 
        Console.WriteLine("Your age is: " + age); 
    }
}