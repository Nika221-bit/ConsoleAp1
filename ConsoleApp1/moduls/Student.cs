namespace ConsoleApp1.moduls;

public class Student
{
    
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password {get;private set;}
    
    public Student(string name, string lastname, int age, string email)
    {
        Name = name;
        Lastname = lastname;
        Age = age;
        Email = email;
    }
<<<<<<< HEAD

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Lastname: {Lastname}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
    }
}
=======
>>>>>>> 4913c813f6164ee45a4be1604828d894eb3f7cc2

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Lastname: {Lastname}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
    }
}
