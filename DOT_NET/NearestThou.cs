using System;
namespace Nearesthou;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int Nearesthousand = (int)Math.Round(num / 1000.0) * 1000;

        Console.WriteLine("nearest thousand is: " + Nearesthousand);
    }
}
