using System;

class stringExample
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        Console.WriteLine("Word count: " + words.Length);
    }
}