using static System.Console;

Write("How many eggs are there?");
string? input = ReadLine();

// Escaping the exception with the TryParse() method
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs");
}
else
{
    WriteLine("I could not parse the input.");
}

try
{
    /* 
     * Checked block will check for the error and throw exception at that particular line
     *                                  error because overflow size will n
     */
    checked
    {
        Write("inside cheked block");
        int i = int.MaxValue;
        WriteLine($"Value of i = {i}");
        WriteLine($"Incremented value of i = {++i}"); // incrementing the max value of int to generate overflow exception
        WriteLine($"Incremented value of i = {++i}");
        WriteLine($"Incremented value of i = {++i}");
    }
}
catch
{
    // unchecked block will not check for the error and will not throw the exception
    unchecked
    {
        Write("inside uncheked block");
        int i = int.MaxValue;
        WriteLine($"Value of i = {i}");
        WriteLine($"Incremented value of i = {++i}");
        WriteLine($"Incremented value of i = {++i}");
        WriteLine($"Incremented value of i = {++i}");
    }
}