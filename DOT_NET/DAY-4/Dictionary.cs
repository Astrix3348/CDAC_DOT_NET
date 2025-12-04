namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> employees = new Dictionary<int, string>() { { 1, "aakash" }, { 2, "aastha" } };

        foreach(KeyValuePair<int, string> check in employees)
        {
            Console.Write("\nEmpId is: " + check.Key);
            Console.Write(" EmpName is: " + check.Value);
        }
        Console.WriteLine();

        //For displaying only keys
        Dictionary<int, string>.KeyCollection keys = employees.Keys;

        Console.WriteLine("===== Keys =====");
        foreach(int item in keys)
        {
            Console.Write("\n" + item);
        }

        //For Values
        Dictionary<int, string>.ValueCollection values = employees.Values;

        Console.WriteLine("\n===== Values =====");
        foreach(string value in values)
        {
            Console.Write("\n" + value);
        }
    }
}

