namespace AreaOfCircle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the radius: ");
        int radius = int.Parse(Console.ReadLine());
        float area = (float)(3.14 * radius * radius);
        Console.WriteLine("Area of the circle is: " + area);
    }
}
