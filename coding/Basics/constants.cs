using System;

class ConstantExample
{
    static void Main()
    {
        const double TaxRate = 0.13;
        double price = 1000;

        double finalPrice = price + (price * TaxRate);
        Console.WriteLine("Final price: " + finalPrice);

        // TaxRate = 0.15;   // ❌ this line would fail to compile
    }
}