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

WriteLine("\n// Optional parameters");// Optional Parameters
WriteLine(bob.OptionalParameter());
WriteLine(bob.OptionalParameter("Jump!",98.5));

WriteLine("\n// Naming parameters while calling");// Naming parameter while calling
WriteLine(bob.OptionalParameter(number:51.3, command:"Hide!"));
WriteLine(bob.OptionalParameter("Poke!",active:false));

WriteLine("\n// Controlling how parameters are passed"); // Controlling how parameters are passed
int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

WriteLine("\n// Simplified out parameters"); // Simplified out parameters for C#7 or later
int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f dosn't exist yet");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

// Controlling access with properties and indexers

WriteLine("\n// read only properties"); // read only properties
Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

WriteLine("\n// settable properties"); // settable properties
sam.FavioriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavioriteIceCream}.");

string color = "blisk";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch(Exception ex)
{
    WriteLine("Tried to set {0} to '{1}' : {2}",
        nameof(sam.FavoritePrimaryColor),color, ex.Message);
}

WriteLine("\n// requiring properties to be set during instantiation"); // requiring properties to be set during instantiation

Book book1 = new()
{
    Isbn = "978-1803237800",
    Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
};
Book book = new(auth:"Mark")
{
  Isbn= "978-1803237800",
Title= "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"

};


WriteLine("{0} : {1} written by {2} has {3:N0} pages.",
    book.Isbn,book.Title,book.Author,book.PageCount);

WriteLine("\n// Using Indexers");// Using Indexers
sam.Children.Add(new() { Name = "Charlie",DateOfBirth= new(2010,6, 25) });
sam.Children.Add(new() { Name = "Ella",DateOfBirth = new(2020,12,24) });

WriteLine("\n// get using children list");// get using children list
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

WriteLine("\n// get using integer position indexer");// get using integer position indexer
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

WriteLine("\n// get using name indexer");// get using name indexer
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

WriteLine("\n// More About methods");// More About methods
WriteLine("\n// Using methods to implement funtionality");// Using methods to implement functionality
Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adha" };
Person zillah = new() { Name = "Zillah" };
lamech.Marry(adah);
//Person.Marry(zillah, lamech);

WriteLine("\n// Using operator to implement funtionality");// Using operator to implement functionality
if (zillah + lamech) // implementing functionality using operators
{
    WriteLine($"{zillah.Name} and {lamech.Name} got married successfully.");
}

WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name ?? "nobody"}");
WriteLine($"{adah.Name} is married to {adah.Spouse?.Name ?? "nobody"}");
WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name ?? "nobody"}");

WriteLine("\n// call instance method");// call instance method
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Sittu";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");

WriteLine("\n//call static method");//call static method
Person baby2 = Person.Procreate(zillah,lamech);
baby2.Name = "Soni";

WriteLine("\n// use operrator to \"multiply\"");// use operrator to "multiply"
Person baby3 = lamech * adah;
baby3.Name = "Sweety";
Person baby4 = zillah * lamech;
baby4.Name = "Sonu";

WriteLine($"{lamech.Name} has children count : {lamech.Children.Count()} children");
WriteLine($"{adah.Name} has children count : {adah.Children.Count()} children");
WriteLine($"{zillah.Name} has children count : {zillah.Children.Count()} children");

for (int i = 0; i< lamech.Children.Count; i++)
{
    WriteLine(format: "{0}'s child #{1} is nameed \"{2}\".",
        arg0:lamech.Name,
        arg1:i,
        arg2: lamech[i].Name);
}

WriteLine("\n// Implementing functionality using local funciton");// Implementing functionality using local funciton
int number = 5;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType} says : {ex.Message} number was {number}.");
}

WriteLine("\n// Pattern Matching with Objects");// Pattern Matching with Objects
Passenger[] passengers =
{
    new FirstClassPassenger{AirMiles = 1_419, Name= "Suman" },
    new FirstClassPassenger{AirMiles = 16_562, Name= "Lucy" },
    new BusinessClassPassenger{Name= "Janice" },
    new CoachClassPassenger{CarryOnKG = 25.7, Name= "Dave" },
    new CoachClassPassenger{CarryOnKG = 0, Name= "Amit" }
};
WriteLine("\n// Enhancement to pattern matching in C#9 or later");// Enhancement to pattern matching in C#9 or later
foreach(Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // C#8.0 syntax
        //FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        //FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        //FirstClassPassenger _ => 2000M,

        // C#9.0 or later syntax

        //FirstClassPassenger p => p.AirMiles switch
        //{
        //    >35000=>1500M,
        //    >15000=>1750M,
        //    _     =>2000M
        //},

        // we could also use relational pattern in combination with the property pattern to avoid the nested
        FirstClassPassenger { AirMiles: >3500 }         =>1500M,
        FirstClassPassenger { AirMiles: >1500 }         =>1750M,
        FirstClassPassenger                             =>2000M,

        BusinessClassPassenger _                        => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0   => 500M,
        CoachClassPassenger _                           => 650M,
        _                                               => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}.");
}

WriteLine("\n// Init only proprty");// Init only property
ImmutablePerson jeff = new()
{
    firstName = "Jeff",
    lastName = "Winger"
};
WriteLine(jeff.firstName + jeff.lastName+" is a Immutable Person");
WriteLine("\n// Using Records");// Using Records
ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Mettalic",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car with
{
    Color = "Polymetal Grey Mettalic"
};
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

WriteLine("\n// Using Positional Records");// Using Positional Records
ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar;
WriteLine($"{who} is a {what}.");