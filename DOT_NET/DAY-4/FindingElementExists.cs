namespace FindingElement;

class Program
{
    static void Main(string[] args)
    {
        List<int> marks = new List<int>() { 4, 5, 6, 2, 6, 9};

        //checking if a student has failed or not
        bool check = marks.Exists(m => m == 8);

        if(check == true)
        {
            Console.WriteLine("Yes he has passed!");
        }
        else
        {
            Console.WriteLine("does not exist");
        }

        //finding the first failed marks
        int firstFail = marks.Find(m => m < 5);
        Console.WriteLine("First failed marks is: " + firstFail);
    }
}

