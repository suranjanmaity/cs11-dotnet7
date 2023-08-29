namespace Packt.Shared;

public class Person : object
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    public int MethodToCall(string message)
    {
        return message.Length;
    }
    // Defining and handling events
    //delegate field
    public event EventHandler? Shout;
    //data field
    public int AngerLevel;
    //method
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening...
            if (Shout != null)
            {
                // ...then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }
}