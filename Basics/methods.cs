using System;

class Method
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        Greet("Ankit");
        int result = Add(5, 7);
        Console.WriteLine("Sum: " + result);
    }
}