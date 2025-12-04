namespace JaggedArray;

/*-jagged array is an array of arrays
  -meaning at each row there will be another array
  -difference between multidimensional and jagged is that in multidimen
   number of columns for all the rows must be same
  -in case of jagged the number of columns can be different for each row
 */

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[5][];
        arr[0] = new int[] { 1, 2, 3, 4, 5 };
        arr[1] = new int[] { 1, 2, 3, 4 };
        arr[2] = new int[] { 1, 2, 3 };
        arr[3] = new int[] { 1, 2 };
        arr[4] = new int[] { 1 };

        //displaying the array
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + "->");
                
            }
            Console.WriteLine();
        }
    }
}

