using System.Runtime.CompilerServices;
namespace Packt.Shared;
public class ImmutablePerson
{
    public string? firstName { get; init; }
    public string? lastName { get; init; }
}

// Understanding records
public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}

// simplifying data members in records
//public record ImmutableAnimal
//{
//    public string Name { get; init; }
//    public string Species { get; init; }
//    public ImmutableAnimal(string name, string species)
//    {
//        Name = name;
//        Species = species;
//    }
//    public void Deconstruct(out string name, out string species)
//    {
//        name = Name;
//        species = Species;
//    }
//}
// The properties, constructor, and deconstructor can be generated for you using simplified syntax known as positional records,
public record ImmutableAnimal(string Name, string Species);