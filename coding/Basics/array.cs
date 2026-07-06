using System;

class ArrayExample
{
    static void Main()
    {
        int[] scores = { 85, 92, 78, 60, 99 };
        int sum = 0;

        foreach (int score in scores)
        {
            sum += score;
        }

        double average = (double)sum / scores.Length;
        Console.WriteLine("Average: " + average);
    }
}