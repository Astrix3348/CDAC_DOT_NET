namespace FunctionOverloading;

public class TestingOverload
{
    public void add(int x, int y)
    {
        Console.WriteLine((x + y));
    }

    public void add(int x, int y, int z)
    {
        Console.WriteLine(x + y + z);
    }

    public void add(string x, string y)
    {
        Console.WriteLine("Concatenation of the two strings is: " + x + y);
    }

    public void add(double x, double y)
    {
        double z = x + y;
        Console.WriteLine("Adding two Decimals: " + z.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestingOverload to = new TestingOverload();
        to.add(4, 5);
        to.add(5, 6, 7);
        to.add(4.5, 7.7);
        to.add("hello ", "world");

        int x = Convert.ToInt32(Console.ReadLine());
        double z = (double)x;
        int y = Convert.ToInt32(Console.ReadLine());

        to.add(z, y);
    }
}

