using System;

class loop
{
    static void Main()
    {
        // Print the multiplication table of a number
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}