﻿using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};
harry.WriteToConsole();

//non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");
int key = 2; // look up the value that has 2 as its key
WriteLine(format: "{0} has value: {1}",
    arg0: key, arg1: lookupObject[key]);
WriteLine(format: "{0} has value: {1}",
    arg0: harry, arg1: lookupObject[harry]);
//generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");
key = 3;
WriteLine(format:"key {0} has value: {1}",
    arg0:key, arg1: lookupIntString[key]);
       
//assign event handler methods to Shout event
harry.Shout += Harry_shout;
harry.Shout += Harry_shout2;

// call the Poke mehod that raises the Shout event
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

// Inplementing interface
Person?[] people =
{
    null,
    new(){Name= "Simon" },
    new(){Name = "Jenny" },
    new(){Name = "Adam" },
    new(){Name = null },
    new(){Name = "Richard" }
};
OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");
// Comparing objects using a swparate class
Array.Sort(people,new PersonComparer());
OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation");
//calling implicit and explicit implementation of Lose
Person p = new();
p.Lose();// calls implicit implementation of Losing a key
((IGamePlayer)p).Lose(); // calls explicit implementation of losing a game
IGamePlayer player = p as IGamePlayer;
player.Lose(); // calls explicit implementation of loosing a game
int a = 3;
int b = 3;
WriteLine($"a: {a}, b: {b}");
WriteLine($"a == b : {a==b}");
Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1 == p2 : {p1==p2}");
Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p1 == p3 : {p1==p3}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name : {p1.Name==p2.Name}");