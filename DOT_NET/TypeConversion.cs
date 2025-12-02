namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int x = int.Parse(Console.ReadLine());
        int y = Convert.ToInt32(x);
        double z = Convert.ToDouble(y);
        string z2 = Convert.ToString(y);
        Console.WriteLine(z2);
    }
}

