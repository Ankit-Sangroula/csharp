using System;

class Condition
{
    static void main()
    {
        Console.WriteLine("Enter Marks:");
        double marks = double.Parse(Console.ReadLine());

        if(marks >= 90)
        {
            Console.WriteLine("Excellent");      
        }else if(marks >= 70)
        {
            Console.WriteLine("Good");
        }
        else if(marks >= 50)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Fail");
        }
}
}