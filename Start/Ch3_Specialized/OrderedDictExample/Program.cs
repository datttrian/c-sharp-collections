using System.Collections;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        // Create a new OrderedDictionary object
        OrderedDictionary mod = new()
        {
            // Add some keys and values in a particular order
            { "item1", "value 1" },
            { "item2", "value 2" },
            { "item3", "value 3" },
            { "item4", "value 4" }
        };

        // Print the contents of the Dictionary
        PrintDictionary(mod);

        // Remove an existing item and add a new one
        mod.Remove("item3");
        mod.Add("item5", "value 5");

        // Modify the value of an item in the dict
        mod["item2"] = "new value 2";

        // Add one final new item
        mod.Add("item6", "value 6");

        PrintDictionary(mod);
    }

    static void PrintDictionary(OrderedDictionary theDict)
    {
        foreach (DictionaryEntry entry in theDict)
        {
            Console.WriteLine($"Key = {entry.Key}, Value = {entry.Value}");
        }
        Console.WriteLine("---------------");
    }
}
