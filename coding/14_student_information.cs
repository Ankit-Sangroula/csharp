using System;

class StudentInformation  
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Faculty { get; set; }

    public StudentInformation(int rollNo, string name, string faculty)   
    {
        RollNo = rollNo;
        Name = name;
        Faculty = faculty;
    }

    // Method
    public void Display()   
    {
        Console.WriteLine($"RollNo: {RollNo}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Faculty: {Faculty}");
    }
}

class StudentDetails   
{
    static void Main(string[] args)
    {
        StudentInformation student1 = new StudentInformation(1, "Pranish", "Bsc.CSIT");
        StudentInformation student2 = new StudentInformation(2, "Bipin", "BBS");

        student1.Display();
        student2.Display();
    }
}