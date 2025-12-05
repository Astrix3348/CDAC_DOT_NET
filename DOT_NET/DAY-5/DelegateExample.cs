namespace DelegateExample;


//example of a multicast delegate
class Program
{
    //create a delegate type
    public delegate void Test(int x, int y);

    static void Main(string[] args)
    {
        //create a delegate
        Test obj1 = new Test(Addnumbers);
        obj1 += new Test(Multiply);

        obj1(10, 4);
    }
    //create a target method
    static void Addnumbers(int x, int y)
    {
        Console.WriteLine("Addition is: " + (x + y));

    }

    //create another target method
    static void Multiply(int x, int y)
    {
        Console.WriteLine("Multiplication is: " + (x * y));
    }
}

