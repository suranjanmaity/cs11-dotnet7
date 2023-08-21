WriteLine("hello there");
DoSomething();
unchecked
{
    TimesTable((byte)256);
}
TimesTable(number:255,size:100);
ParamVeerChakra();
for (int i = 0; i <= 100; i++)
{
    Write($"{CardinalToOrdinal(i)} ");
}
//WriteLine($"Enter any number to convert into Ordinal : {CardinalToOrdinal(int.Parse(ReadLine()!))}");


for (int i = -2; i <= 15; i++)
{
    try
    {
        WriteLine($"{i}! = {Factorial(i):N0}");
    }
    catch (OverflowException)
    {
        WriteLine($"{i}! is too big for a 32-bit integer.");
    }
    catch (Exception e)
    {
        WriteLine($"{i}! throws {e.GetType} : {e.Message}");
    }
}
