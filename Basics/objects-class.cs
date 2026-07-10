using System;

class CarBasic
{
    public string color;
    public int speed;

    public void Drive()
    {
        Console.WriteLine(color + " car is driving at " + speed + " km/h");
    }
}

class ObjectsClassDemo   {
    static void Main()
    {
        CarBasic myCar = new CarBasic();
        myCar.color = "Red";
        myCar.speed = 120;
        myCar.Drive();

        CarBasic anotherCar = new CarBasic();
        anotherCar.color = "Blue";
        anotherCar.speed = 80;
        anotherCar.Drive();
    }
}