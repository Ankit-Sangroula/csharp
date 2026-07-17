using System;
using System.IO;

class fileExample1
{
    static void Main()
    {
        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        File.WriteAllText("output.txt", input);

        Console.WriteLine("Saved!");
    }
}