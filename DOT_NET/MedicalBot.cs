namespace MedicalBot;


class Program
{
    public string[] medication(string[] arr)
    {
        string[] medic = new string[2];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1].Equals("runny nose") || arr[i].Equals("soar throat"))
            {
                medic[0] = "what i will suggest is to take rest and ";
                medic[1] = "drink plenty of water";
            }
            else if (arr[i - 1].Equals("injury") || arr[i].Equals("sports"))
            {
                medic[0] = "what i will suggest is to do icing and ";
                medic[1] = "go to the doctor";
            }
        }
        return medic;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of diseases what you are going through?");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];

        for(int i = 0; i < n; i++)
        {
            if(i == 0)
            {
                int temp = i + 1;
                Console.WriteLine("enter the " + temp + "st symptom");
                arr[i] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("enter the " + (i + 1) + "th symptom");
                arr[i] = Console.ReadLine();
            }         
        }
        Program p = new Program();
        foreach (string result in p.medication(arr))
        {
        
            Console.Write(result);
        }
        
    }
}

