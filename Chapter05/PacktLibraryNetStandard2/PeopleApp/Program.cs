using Packt.Shared;
using System.Globalization;
using Env = System.Environment;
//WriteLine(Env.OSVersion);
//WriteLine(Env.MachineName);
//WriteLine(Env.CurrentDirectory);

//Person p = new Person(); // C# 1.0 or later
//var bob = new Person(); // C# 3.0 or later
Person bob = new(); // C# 9.0 or later
WriteLine(bob.ToString());
bob.Name = "Bob Smith";
//bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.DateOfBirth = new (1965, 12, 22);
WriteLine(format:"{0} was born on {1:dddd, d MMMM yyyy}",
    arg0:bob.Name,
    arg1:bob.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 or later
bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 or later
WriteLine($"{bob.Name} has {bob.Children.Count} children :");
foreach (Person Children in bob.Children)
{
    WriteLine($"> {Children.Name}");
}


// to change the culture that is responsible for :C format
//Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

WriteLine("\n// making field static");// making field static
BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format:"{0} earned {1:C} interest",
    arg0: jonesAccount.AccountName, arg1: jonesAccount.Balance*BankAccount.InterestRate);

BankAccount gerrierAccount = new();                                                      
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format:"{0} earned {1:C} interest",
    arg0: gerrierAccount.AccountName, arg1: gerrierAccount.Balance*BankAccount.InterestRate);

WriteLine("\n// making field constant");// making field constant
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine("\n// making field readonly");// making field readonly
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

WriteLine("\n// Initializing fields with Constructor");// Initializing fields with Constructor
Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0:blankPerson.Name,
    arg1:blankPerson.HomePlanet,
    arg2:blankPerson.Instantiated) ;

WriteLine("\n// Using parameterized constructor");// Using parameterized constructor
Person gunny = new("Gunny", "Mars");
WriteLine(format:"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0:gunny.Name,
    arg1:gunny.HomePlanet,
    arg2:gunny.Instantiated) ;

WriteLine("\n// Using methods");// Using methods
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine("\n// tuples");// tuples
(string Name,int Count ) fruit = bob.GetFruit();
WriteLine($"{fruit.Name}, {fruit.Count} there are");

WriteLine("\n// deconstructing tuples");// deconstructing tuples
(string Name, int Count) = bob.GetFruit();
WriteLine($"{Name} and there are {Count}");

WriteLine("\n// Deconstruct methods i.e. deconstructing types");// Deconstructors i.e. deconstructing types
var (name1, dob1) = bob;
WriteLine($"{name1} was born on {dob1:g}");
(string? name2, DateTime dob2) = bob.Children[0];
WriteLine($"{name2} was born on {dob2}");

WriteLine("\n//Overloading methods");//Overloading methods
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emilly"));