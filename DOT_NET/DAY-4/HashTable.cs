using System.Collections;
namespace HashTableEx;

class Program
{
    static void Main(string[] args)
    {
        //creating a hashtable
        Hashtable employees = new Hashtable()
        {
            {101, "scott" },
            {102, "allen" },
            {103, "james" }
        };

        
        employees.Add(108, "aakash");
        employees.Remove(101);

        foreach(var item in employees)
        {
            Console.WriteLine(item);
        }
    }
}

