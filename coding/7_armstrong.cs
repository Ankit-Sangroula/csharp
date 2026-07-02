using System;

class Armstrong
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());

        int original = n;
        int sum = 0;
        int digits = n.ToString().Length;

        while (n > 0)
        {
            int digit = n % 10;
            sum = sum + (int)Math.Pow(digit, digits);
            n = n / 10;
        }

        if (original == sum)
        {
            Console.WriteLine(original + " is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(original + " is not an Armstrong Number");
        }
    }
}