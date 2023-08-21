namespace Packt.Shared;

public class Person
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    
    //making field constant
    public const string Species = "Homo Sepiens";
    
    // making field readonly
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    // constructors
    public Person()
    {
        // set default values for fields
        // including readonly fields
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string Name, string HomePlanet)
    {
        this.Name = Name;
        this.HomePlanet = HomePlanet;
        Instantiated = DateTime.Now;
    }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth}");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    // Returning multiple values i.e. Tuple
    public (string Name, int Number) GetFruit()
    {
        return ("Apples", 5);
    }

    // Deconstructors i.e. deconstructing types
    public void Deconstruct(out string? name, out DateTime dob) {
        name = Name;
        dob = DateOfBirth;
    }
    public void Deconstruct(out string? name, out DateTime dob, out WondersOfTheAncientWorld fav) {
        name = Name;
        dob = DateOfBirth;
        fav = FavoriteAncientWonder;
    }

    //Overloading methods
    public string SayHello()
    {
        return $"{Name} say's 'Hello!'";
    }
    public string SayHello(string name)
    {
        return $"{Name} say's 'Hello!', {name}";
    }
}
