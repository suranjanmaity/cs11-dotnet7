// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 5;
int b = a++;
Console.WriteLine($"a is {a} and b is {b}");

Type theTypeOfAnInteger = typeof(int);
string theNameOfAnInteger = nameof(a);
double theSizeOfAnInteger = sizeof(int);
Console.WriteLine(theTypeOfAnInteger);
Console.WriteLine(theNameOfAnInteger);
Console.WriteLine(theSizeOfAnInteger);

