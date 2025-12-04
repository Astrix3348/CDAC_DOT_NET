namespace SystemClassArray;

class Program
{
    static void Main(string[] args)
    {
        double[] arr = { 1, 2, 3, 4, 5, 6 };

        //searching for an element
        int n = Array.IndexOf(arr, 3);
        Console.WriteLine(n);

        //resizing of the array
        int[] bArr = { 4, 6, 1 };
        Array.Sort(bArr);

        Array.Resize(ref bArr, 9);
        Console.WriteLine(bArr.Count());
        Console.WriteLine();
        foreach(int x in bArr)
        {
            Console.WriteLine(x);
        }
    }
}

