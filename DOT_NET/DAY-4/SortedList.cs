namespace SortedList;

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> sl = new SortedList<int, string>()
        {
            {5, "scott" },
            {20, "allen" },
            {3, "james" }
        };
        //adding element
        sl.Add(6, "aakash");

        //removing
        sl.Remove(5);

        foreach(var items in sl)
        {
            Console.WriteLine(items);
        }
    }
}

