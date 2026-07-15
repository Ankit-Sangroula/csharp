using System;


class fileExample3
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}