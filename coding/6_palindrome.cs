using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());

        int original = n;
        int reverse = 0;

        while (n > 0)
        {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n = n / 10;
        }

        if (original == reverse)
        {
            Console.WriteLine(original + " is a Palindrome");
        }
        else
        {
            Console.WriteLine(original + " is not a Palindrome");
        }
    }
}