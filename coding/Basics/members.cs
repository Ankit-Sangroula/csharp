using System;

class Counter
{
    public static int totalObjectsCreated = 0;   
    public int id;                               

    public Counter()
    {
        totalObjectsCreated++;     
        id = totalObjectsCreated;   
    }
}

class Members
{
    static void Main()
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        Console.WriteLine("c1 id: " + c1.id);   
        Console.WriteLine("c2 id: " + c2.id);   
        Console.WriteLine("c3 id: " + c3.id);   

        
        Console.WriteLine("Total created: " + Counter.totalObjectsCreated);   
    }
}