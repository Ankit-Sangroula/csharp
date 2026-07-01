using System;
class Calculate
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Addition = " + (num1 + num2));
        Console.WriteLine("Subtraction = " + (num1 - num2));
        Console.WriteLine("Multiplication = " + (num1 * num2));
        if (num2 == 0)
        {
            Console.WriteLine("Division = Cannot divide by zero");
            Console.WriteLine("Remainder = Cannot divide by zero");
        }
        else
        {
            Console.WriteLine("Division = " + (num1 / num2));
            Console.WriteLine("Remainder = " + (num1 % num2));
        }
    }
}