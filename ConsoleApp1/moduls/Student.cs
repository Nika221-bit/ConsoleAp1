namespace ConsoleApp1.moduls;

public class Student
{
    
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    
    public Student(string name, string lastname, int age, string email)
    {
        Name = name;
        Lastname = lastname;
        Age = age;
        Email = email;
    }
    
}

