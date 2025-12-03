using System.Collections;
namespace LargeNumbers;

class Program
{
    static void Main(string[] args)
    {
        List<int> ls = new List<int>();
        Console.Write("How many numbers you want to add?: ");
        int n = int.Parse(Console.ReadLine());
        int max = 0;

        while(n > 0)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if(num > max)
            {
                max = num;
            }
            ls.Add(num);

            n--;
        }
        Console.WriteLine("The maximum number is: " + max);
    }
    
}

