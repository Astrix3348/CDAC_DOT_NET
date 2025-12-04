namespace HashSet;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> hs = new HashSet<int>();
        hs.Add(42);
        hs.Add(102);
        hs.Add(22);
        hs.Add(32);

        hs.Remove(22);

        Console.WriteLine("=====Displaying=====");
        foreach (int i in hs)
        {
            Console.Write(i + "--");
        }
    }
}

