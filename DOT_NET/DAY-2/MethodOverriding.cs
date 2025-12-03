namespace MethodOverriding;

public class Employee
{
    int empId;
    int salary;

    //virtual is necessary if you are overriding this method so the dev must say that this method may be overridden in the future
    public virtual void Display()
    {
        Console.WriteLine("id is: " + empId);
        Console.WriteLine("salary is: " + salary);
    }
}

public class department : Employee
{
    public int deptId;
    public string Dname;

    Employee e = new Employee();
    public override void Display()
    {
        Console.WriteLine("dept id: " + deptId);
        Console.WriteLine("dept name: " + Dname);

    }
}

class Program
{
    static void Main(string[] args)
    {
        department d = new department();
        d.Dname = "CS";
        d.deptId = 32;
        d.Display();
    }
}

