using System;

class Car
{
    public string color;
    public int speed;

    public Car(string carColor, int carSpeed)
    {
        color = carColor;
        speed = carSpeed;
    }

    public void Drive()
    {
        Console.WriteLine(color + " car driving at " + speed + " km/h");
    }
}

class ConstructorExample
{
    static void Main()
    {
        Car myCar = new Car("Black", 150); // values set immediately at creation
        myCar.Drive();
    }
}