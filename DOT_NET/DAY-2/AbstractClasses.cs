namespace AbstractClasses;

public abstract class CDAC
{
    public CDAC()
    {
        Console.WriteLine("Welcome to CDAC");
        Console.ReadKey();
    }
    public void Courses()
    {
        Console.WriteLine("i have taken the course of DAC");
        Console.ReadKey();
    }
}

public class Student : CDAC
{
    public void study()
    {
        Console.WriteLine("i am currently working on a project");
        Console.ReadKey();
    }
    public void address()
    {
        Console.WriteLine("i live in Dwarka, New Delhi!");
        Console.ReadKey();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //CDAC c = new CDAC(); // cannot create an instance of an abstract class
        Student st = new Student();
        st.Courses();
        st.study();
        st.address();
        
    }
}

