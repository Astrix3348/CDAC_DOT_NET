namespace PolyMorphismInterface;

interface Animal
{
    //these are the properties of the interface
    string Name { get; set; }
    string Breed { get; set; }

    //this is an abstract method so since we are doing this in an interface there is no need for the abstract keyword
    void animalDetails();
}

//this is a child class
class Dog : Animal
{
    //properties
    public string Name { get; set; }
    public string Breed { get; set; }

    //implementing this function coming from the abstract function in the interface
    public void animalDetails()
    {
        Console.WriteLine("Dog Name: " + Name);
        Console.WriteLine("Dog Breed: " + Breed);
    }

}

class Cat : Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public void animalDetails()
    {
        Console.WriteLine("Cat's name is " + Name);
        Console.WriteLine("Cat's breed is " + Breed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Dog();
        a.Name = "fluffy";
        a.Breed = "labra";

        a.animalDetails();
        Console.WriteLine("\n");

        /***************Creating the object for the second inherited class*************/
        a = new Cat();
        a.Name = "bow";
        a.Breed = "orange";
        a.animalDetails();
    }
}

