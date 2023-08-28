using Packt.Shared;
partial class Program
{
    static void Harry_shout(object? sender, EventArgs e)
    {
        if (sender == null) return;
        Person? p = sender as Person;
        if (p == null) return;
        WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }
}