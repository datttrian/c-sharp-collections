using System.Collections;
using System.Collections.Specialized;

// Create the hybrid dictionary
HybridDictionary myHbd = new HybridDictionary(20, false);

// Add some initial items
myHbd.Add("item1", "value 1");
myHbd.Add("item2", "value 2");
myHbd.Add("item3", "value 3");
myHbd.Add("item4", "value 4");

Console.WriteLine($"Dictionary size: {myHbd.Count}");

// Contains
Console.WriteLine(myHbd.Contains("item1"));

// Remove
myHbd.Remove("item3");
foreach (DictionaryEntry de in myHbd)
{
    Console.WriteLine($"{de.Key}, {de.Value}");
}

// Clear
myHbd.Clear();

// Print the number of items
Console.WriteLine($"Dictionary size: {myHbd.Count}");
