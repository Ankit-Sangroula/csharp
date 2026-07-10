using System;

class Handling
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("That wasn't a valid number!");
        }
    }
}