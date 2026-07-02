using System;

class FactorialMethod
{
    static int Fact(int number)
    {
        int fact = 1;
        for (int i = 1; i <= number; i++) 
        {
            fact = fact * i;
        }
        return fact;
    }

    static int Cube(int number)
    {
        return number * number * number;
    }

    static void Main() 
    {
        Console.Write("Enter a Number: ");
        int n1 = int.Parse(Console.ReadLine());
        int factorialResult = Fact(n1);
        Console.WriteLine($"Factorial of {n1} is: {factorialResult}"); 

        Console.Write("Enter a Number for Cube: ");
        int n2 = int.Parse(Console.ReadLine());
        int cubeResult = Cube(n2); 
        Console.WriteLine($"Cube of {n2} is: {cubeResult}"); 
    }
}