using Packt.Shared;
class PeopleApp
{
    public static void Main(string[] args)
    {

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
        // Calling method using Delegate
        Person p1 = new();
        int answer = p1.MethodToCall("Frog");
        WriteLine($"answer : {answer}");

        // create delegate instance that points to the method
        DelegateWithMatchingSignature d = p1.MethodToCall;
        // call the delegate, who then calls the method
        int answer2 = d("Frog");
        WriteLine($"answer2 : {answer2}");
    }
        delegate int DelegateWithMatchingSignature(string s);
}