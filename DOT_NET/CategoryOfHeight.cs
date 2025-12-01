using System;
namespace CategoryOfHeight;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine()) * 2.54;

        if (height > 182)
        {
            Console.WriteLine("Your height is above 6 feet!");
        }
        else if (height < 182 && height > 152)
        {
            Console.WriteLine("your height is between 5 and 6 feet!");
        }
        else
        {
            Console.WriteLine("You are small!");
        }
    }
}
