using System.Reflection;
using System.Xml.Linq;

namespace MethodHiding;

//this is a parent class
public class Person
{
    public string name;
    public char gender;

    public void Display()
    {
        Console.WriteLine("Person name: " + name);
        Console.WriteLine("Person gender: " + gender);
    }
}

public class Student : Person
{
    public int studentId;
    public int marks;

    //the `new` keyword here is used so as to hide the method in the parent class called `Display` both methods have the same signature but the code varies.
    public new void Display()
    {
        Console.WriteLine("Student's name: " + name);
        Console.WriteLine("Student's gender: " + gender);
        Console.WriteLine("Students's marks: " + marks);
        Console.WriteLine("Student's id: " + studentId);
    }
}

//creating another child class
public class Employee : Person
{
    public int Empid;
    public int Salary;

    public new void Display()
    {
        Console.WriteLine("Emp's name: " + name);
        Console.WriteLine("Emp's gender: " + gender);
        Console.WriteLine("Emp's Salary: " + Salary);
        Console.WriteLine("Emp's id: " + Empid);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.studentId = 1;
        s.name = "aakash";
        s.marks = 100;
        s.gender = 'M';

        s.Display();

        Employee e = new Employee();
        e.name = "aakash gangwar";
        e.Salary = 200000;
        e.Empid = 2;
        e.Display();
    }
}

