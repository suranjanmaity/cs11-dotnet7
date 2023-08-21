using static System.Console;

// formatting using numbered positional arguments
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
    format:"{0} apples cost {1:C}",
    arg0:numberOfApples,
    arg1:pricePerApple*numberOfApples
    );
/* these arg0...arg3 can have only upto 4 arguments
    if you want more arguments then you can do like this */
WriteLine("{0}, {1} lived in {2}, {3} and worked in the {4} team at {5}.",
    "Suranjan", "Shivendra", "Ghaziabad", "Noida", "Manish Pathak", "Intelegencia");
WriteLine($"{numberOfApples} apples cost {pricePerApple*numberOfApples:C}");


// getting user input from ReadLine()

Write("Enter your name and press enter : ");
String firstName = ReadLine()!;
Write("Enter your age and press enter :");
String age = ReadLine()!;
Write($"{firstName} you look good for {age}");

// getting keyinput from user
Write("Press any key combination: ");
ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
WriteLine();
WriteLine("Key: {0}, Char:{1}, Modifiers:{2}",
    arg0: consoleKeyInfo.Key,
    arg1: consoleKeyInfo.KeyChar, arg2: consoleKeyInfo.Modifiers);

int a = 10;
int b = 20;

Console.WriteLine(sizeof(decimal));

int age2 = 50;
Console.WriteLine(age2.ToString()[0]);


object o = 3;
int j = 4;
if(o is int i)
{
    Console.WriteLine($"{i}*{j} = {i*j}");
}
else
{
    Console.WriteLine("o is not an object so it cannot multiply");
}

