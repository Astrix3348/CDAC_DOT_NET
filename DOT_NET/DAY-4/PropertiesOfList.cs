namespace PropertiesOfList;

class Program
{
    static void Main(string[] args)
    {
        List<int> ls = new List<int>();

        //adding new elements
        ls.Add(1);
        ls.Add(2);
        ls.Add(3);

        ls.Insert(1, 50);

        List<int> extra = new List<int>() { 8, 9, 6, 1 };

        ls.AddRange(extra);

        foreach (int e in ls)
        {
            Console.WriteLine(e);
        }
    }
}

