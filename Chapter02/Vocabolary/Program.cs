// See https://aka.ms/new-console-template for more information
using System.Xml;
using System.Xml.Serialization;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Object Datatype
        object height = 1.88;
        object name = "Amit";
        Console.WriteLine($"{name} is {height} meter tall.");
        //int length = name.Length;// gives compilation error because we have to typecast the object datatype to string datatype
        int length2 = ((string)name).Length;
        Console.WriteLine($"{name} has {length2} characters");

        // Dynamic datatype
        dynamic somthing = "Mohan";
        Console.WriteLine($"Length is {somthing.Length}");
        somthing = new[] { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine($"Length is {somthing.Length}");
        Console.WriteLine('5' + 5);

        // Inferring the type of local variable
        var someone = "Rakesh";
        var population = 78_000_000;
        var weight = 1.88;
        var price = 4.99M;
        var fruit = "Apples";
        var letter = 'Z';
        var happy = true;

        Console.WriteLine(someone + population + weight + letter + price + fruit + happy);

        var xml1 = new XmlDocument();
        XmlDocument xml2 = new XmlDocument();



        // using target-typed new() to instantiate objects

        Person kin = new();
        kin.BirthDate = new(1967, 12, 26);

        List<Person> list = new()
        {
            new() {FirstName ="alice" },
            new() {FirstName ="bob" },
            new() {FirstName ="charlie" }

        };
        foreach (var item in list)
        {
            Console.WriteLine(item.FirstName);
        }


        // Getting and Setting default values for type
        
        
        // args variable passing
        foreach (var arg in args)
        {
        Console.WriteLine(arg);
        }




        // Setting options with arguments
        if (args.Length < 3)
        {
            WriteLine("You must specify two colors and cursor size, e.g. \n" +
                "dotnet run red yellow 50\n");
            return;
        }
        ForegroundColor = (ConsoleColor)Enum.Parse(
            enumType: typeof(ConsoleColor),
            value: args[0],
            ignoreCase: true);
        BackgroundColor = (ConsoleColor)Enum.Parse(
            enumType: typeof(ConsoleColor),
            value: args[1],
            ignoreCase: true);
        CursorSize = int.Parse(args[2]);
        WriteLine($"From here on back ground color will be {args[1]} and text color will be {args[0]}. You can write anything,");
        string something = ReadLine()!;
    }
}

class Person
{
    public DateTime BirthDate;
    public string FirstName;
}