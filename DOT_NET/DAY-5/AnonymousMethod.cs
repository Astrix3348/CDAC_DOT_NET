namespace AnonymousMethod;

public delegate string GetMessage(string name);
class Program
{
    //anonymous methods are created using the delegate keyword
    static void Main(string[] args)
    {
        //lambda expression
        GetMessage gm = (name) =>
        {
            return "Hello " + name + " Welcome to Delhi!";
        };

        string Message = gm.Invoke("aakash");
        Console.WriteLine(Message);
    }
}

