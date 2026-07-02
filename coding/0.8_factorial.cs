using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 1;
        for(int i = 1; i <= n; i++) {
         fact = fact * i;
        }
        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }

}
