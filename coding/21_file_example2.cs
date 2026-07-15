using System;


class fileExample2
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        List<int> squared = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared list:");
        foreach (int num in squared)
        {
            Console.WriteLine(num);
        }
    }
}