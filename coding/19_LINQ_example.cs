using System;

class linqExample
{

    //using Without LINQ
    //static void Main()
    //{
    //    List<int> marks = new() { 45, 80, 65,90,35,75};
    //    List<int> result = new List<int>();
    //    foreach (int mark in marks)
    //    {
    //        if (mark > 60)
    //        {
    //            result.Add(mark);
    //        }
    //    }
    //        foreach(int mark in result) 
    //    {
    //            Console.WriteLine(mark);
    //        }

    //}


    //with LINQ
    static void Main()
    {
        List<int> marks = new() { 45, 80, 65,90,35,75};
       var result = marks.Where(m => m > 60);
        foreach (var mark in result) 
        {
                Console.WriteLine(mark);
            }
        
    }
}