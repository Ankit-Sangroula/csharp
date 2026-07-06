using System;

class Car
{
    public string color;
    public int speed;

    public void Drive()
    {
        Console.WriteLine(color + " car is driving at " + speed + " km/h");
    }
}

class Vechicle
{
    static void Main()
    {
        Car myCar = new Car();     // create an object from the Car blueprint
        myCar.color = "Red";
        myCar.speed = 120;
        myCar.Drive();

        Car anotherCar = new Car(); // a separate, independent object
        anotherCar.color = "Blue";
        anotherCar.speed = 80;
        anotherCar.Drive();
    }
}