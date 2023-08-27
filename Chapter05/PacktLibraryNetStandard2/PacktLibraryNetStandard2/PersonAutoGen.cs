using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System;

namespace Packt.Shared;
public partial class Person
{
            // Controlling the access with properties and indexers

        // Defining read-only properties

    // a read only property defined using C# 1-5 syntax
    public string Origin
    {
        get
        {
            return string.Format(format: "{0} was born on {1}",
                arg0: Name,
                arg1: HomePlanet);
        }
    }

    // two readonly properties defined using C# 6+ lambda expression body
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

        // Defining settable properties

    // a read write property defined using C# 3.0 syntax
    public string? FavioriteIceCream { get; set; } // auto syntax

    // a private field to store the property value
    private string? favioritePrimaryColor;

    // a public property to read and write to the field
    public string? FavoritePrimaryColor
    {
        get
        {
            return favioritePrimaryColor;
        }
        set
        {
            switch(value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favioritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a Primary color. " +
                        "Choose from: red, green, blue.");
            }
        }
    }

    //indexers
    public Person this[int index]
    {
        get
        {
            return Children[index]; // pass on to the List<T> indexer
        }
        set
        {
            Children[index] = value;
        }
    }
    public Person this[string name]
    {
        get
        {
            return Children.Find(x => x.Name == name);
        }
        set
        {
            Person found = Children.Find(x=> x.Name == name);
            if (found != null) found = value;
        }
    }

    // Impleting functionality using methods
    private bool married = false;
    public bool Married => married;

    private Person? spouse = null;
    public Person? Spouse => spouse;

    // static method to marry

    /// <summary>
    /// In the static method named Marry , the Person objects are passed as parameters named p1, p2 to the instance Method Marry.<br>
    /// In the instance method Marry, the spouse is set to the partner passed as a parameteer, and the married Boolean is set to true.
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    public static void Marry(Person p1,  Person p2)
    {
        p1.Marry(p2);
    }
    public void Marry(Person partner)
    {
        if (married) return;
        spouse = partner;
        married = true;
        partner.Marry(this); // this is the current object
    }
/*NOTE
 * In the static method named Marry , the Person objects are passed as parameters named p1, p2 to the instance Method Marry.
 * In the instance method Marry, the spouse is set to the partner passed as a parameteer, and the married Boolean is set to true.
 */

    // static method to "multiply"
    
    /// <summary>
    /// In the static method named Procreate, the Person objects that will procreate are p1, p2 passed as parameters <br>
    /// A new Person class named baby is created with a name composed of combination of two people who have procreated.This could be changed later by setting the returned baby variable's Name property <br>
    /// The baby object is added to the children collection of both parents and then  returned.Classes are reference type, meaning the reference to the baby object stored in memory is added, not a clone of the baby object. <br>
    /// In the instance method named ProcreateWith, the Person object to procreate with i spassed as a parameter named partner, and it, along with this, is passed to the static Procreate method to reuse the method implementation. this is a keyword that references the current instance of the class.
    /// </summary>
    /// <param name="partner"></param>
    /// <returns>A Person object</returns>
    public static Person Procreate(Person p1, Person p2)
    {
        if(p1.Spouse != p2)
        {
            throw new ArgumentException("You must be married to procreate");
        }
        Person baby = new()
        {
            Name = $"Baby of {p1} and {p2}",
            DateOfBirth = DateTime.Now
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    // instance method to "multiply"
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
/*NOTE
 * In the static method named Procreate, the Person objects that will procreate are p1, p2 passed as parameters
 * A new Person class named baby is created with a name composed of combination of two people who have procreated. This could be changed later by setting the returned baby variable's Name property
 * The baby object is added to the children collection of both parents and then  returned.Classes are reference type, meaning the reference to the baby object stored in memory is added, not a clone of the baby object.
 * In the instance method named ProcreateWith, the Person object to procreate with i spassed as a parameter named partner, and it, along with this, is passed to the static Procreate method to reuse the method implementation. this is a keyword that references the current instance of the class.
 */

    // Implementing functionality using operators

    // operator to "marry"
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        return p1.Married && p2.Married;
    }

    // operator to "multiply"
    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }
}