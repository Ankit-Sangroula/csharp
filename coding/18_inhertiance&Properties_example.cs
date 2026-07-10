using System;
class PersonExample
{
    public string Name { get; set; }
    public string Address { get; set; }

}
class Teacher : PersonExample
{
    public string Subject { get; set; }
    private double salary;
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
    public void DisplayTeacher()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"Salary: {Salary}");
    }
}
class schoolExample
{
    static void Main()
    {
        Teacher t = new Teacher();
        t.Name = "Mr. Sharma";
        t.Address = "Itahari";
        t.Subject = "Mathematics";
        t.Salary = -2000;   

        t.DisplayTeacher();
    }
}
 