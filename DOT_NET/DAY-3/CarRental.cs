using System.Collections;

namespace Car_Rental;

class Car
{
    string name;
    string brand;
    int rental_price;
    bool stat;

    public Car(string name, string brand, int rental_price, bool stat)
    {
        this.name = name;
        this.brand = brand;
        this.rental_price = rental_price;
        this.stat = stat;
    }

    public Car()
    {

    }

    public void display(List<Car> ls)
    {
        foreach (Car c in ls)
        {
            if(c.stat == true)
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + c.name);
                Console.WriteLine("brand: " + c.brand);
                Console.WriteLine("rental price: " + c.rental_price);
                Console.WriteLine("status: " + c.stat);
                Console.WriteLine();
            }       
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of cars you want to add. ");
        int n = int.Parse(Console.ReadLine());
        List<Car> ls = new List<Car>();


        while (n > 0)
        {
            Console.Write("\nEnter the name of the car: ");
            string name = Console.ReadLine();
            Console.Write("\nEnter the brand of the car: ");
            string brand = Console.ReadLine();
            Console.Write("\nEnter the rental price of the car: ");
            int rental_price = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the avalability of the car(true/false): ");
            bool status = bool.Parse(Console.ReadLine());

            Car c = new Car(name, brand, rental_price, status);
            ls.Add(c);
            n--;
            
        }
        Console.WriteLine("\nDo you Want to display the cars available?(yes/no)");
        string ans = Console.ReadLine();
        Car ch = new Car();

        if (ans.Equals("yes"))
        {
            ch.display(ls);
        }
        else
        {
            Console.WriteLine("exiting...");
        }


        
    }
}

