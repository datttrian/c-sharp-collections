using System.Collections.Specialized;

// define an initial set of strings
string[] colors = { "red", "orange", "yellow", "green", "blue", "violet" };

// create the string collection
StringCollection strcoll = new();
// Add an existing set of strings
strcoll.AddRange(colors);

// add some individual items
strcoll.Add("black");
strcoll.Insert(0, "white");

// Use the Count property to see how many there are
Console.WriteLine($"There are {strcoll.Count} strings");

// Iterate over each string in the collection
foreach (string str in strcoll)
{
    Console.Write($"{str} ");
}
Console.WriteLine();
Console.WriteLine("-------");

// Access an individual item
Console.WriteLine($"Item at 3 is {strcoll[3]}");

// Search for a string
Console.WriteLine($"Collection contains 'blue': {strcoll.Contains("blue")}");
Console.WriteLine($"Green is at location: {strcoll.IndexOf("green")}");

// Clear all the contents
strcoll.Clear();
Console.WriteLine($"There are {strcoll.Count} strings");
