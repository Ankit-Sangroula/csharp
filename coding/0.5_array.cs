using System;

class Array
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter? ");
        int count = int.Parse(Console.ReadLine());
        int[] a = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;

        foreach (int number in a)
        {
            sum = sum + number;
        }

        Console.WriteLine("Sum = " + sum);
    }
}




//without foreach
//using System;

//class Array
//{
//    static void Main()
//    {
//        Console.Write("How many numbers do you want to enter? ");
//        int count = int.Parse(Console.ReadLine());

//        int[] a = new int[count]; 

//        for (int i = 0; i < count; i++)
//        {
//            Console.Write("Enter number " + (i + 1) + ": ");
//            a[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;

//        for (int i = 0; i < a.Length; i++) 
//        {
//            sum = sum + a[i]; 
//        }

//        Console.WriteLine("Sum = " + sum);
//    }
//}