using System.Collections;
namespace UsageOfInterface;

public interface Person
{
    string name { get; set; }
    

    void display();
}

class Employee : Person
{
    public string name { get; set; }
    public int salary;

    public Employee(string name, int salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void display()
    {
        Console.WriteLine("Name is: " + name);
        Console.WriteLine("Salary is: " + salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> ls = new List<Employee>();
        Console.Write("Enter the number of employees to enter: ");
        int n = int.Parse(Console.ReadLine());

        while(n > 0)
        {
            Console.WriteLine("\nDetails of the " + (ls.Count() + 1) + " th employee");
            Console.Write("\nName of the Employee: ");
            string name = Console.ReadLine();
            Console.Write("\nEnter the salary of the employee: ");
            int salary = int.Parse(Console.ReadLine());

            Employee e = new Employee(name, salary);
            ls.Add(e);
            n--;  
        }

        Console.WriteLine("\nDisplaying the employees");

        foreach(Employee es in ls)
        {
            Console.WriteLine("\nName is: " + es.name);
            Console.WriteLine("\nSalary is: " + es.salary);
        }
    }
}

