using System;
class OddEvenChecker
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0) { 
        Console.WriteLine("The number is even.");
        }
        else {
          Console.WriteLine("The number is odd.");
        }
}
}