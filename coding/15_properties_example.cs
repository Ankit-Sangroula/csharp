using System;

class EmployeeInformation
{
    private int id;
    private string name;
    private double salary;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                salary = 0;
            else
                salary = value;
        }
    }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class EmployeeShow
{
    static void Main(string[] args)
    {
        EmployeeInformation emp = new EmployeeInformation();
        emp.Id = 1;
        emp.Name = "Ram";
        emp.Salary = 20000;
        emp.Display();
    }
}