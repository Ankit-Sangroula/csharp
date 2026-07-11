using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
 class Student : Person
{
    public string Faculty { get; set; }

    public void DisplayStudent()
    {
        DisplayPerson();          
        Console.WriteLine($"Faculty: {Faculty}");
    }
}
class studentShow
{
    static void Main(string[] args)
    {
        Student stu = new Student();
        stu.Name = "John";
        stu.Age = 20;
        stu.Faculty = "Engineering";
        stu.DisplayStudent();
    }
}

