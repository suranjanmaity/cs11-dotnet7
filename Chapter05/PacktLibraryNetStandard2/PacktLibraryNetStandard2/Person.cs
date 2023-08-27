namespace Packt.Shared;

public partial class Person
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

    // Optional Paramenter and named parameter
    public string OptionalParameter(string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(format: "command is {0}, number is {1}, active is {2}",
            arg0:command,
            arg1:number,
            arg2:active);
    }

    // Controlling how parameters are passed
    public void PassingParameters(int x, ref int y, out int z)
    {
        // out parameters cannot have a default =
        // AND must be initialized inside the method 
        z = 99;
        // increment each parameter
        x++;
        y++;
        z++;
    }

    // Implementing functionality using local functions
    //method with a local fucntion
    public static int Factorial(int number)
    {
        if(number<0) throw new ArgumentOutOfRangeException($"{nameof(number)} cannot be less than zero.");
        return localFactorial(number);
        // local function
        int localFactorial(int number)
        {
            if (number == 0) return 1;
            return number * localFactorial(number - 1);
        }
    }
}
