using System;

class person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
 class student : person
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
        student stu = new student();
        stu.Name = "John";
        stu.Age = 20;
        stu.Faculty = "Engineering";
        stu.DisplayStudent();
    }
}

