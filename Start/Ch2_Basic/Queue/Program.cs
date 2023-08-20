// Create an empty Queue that holds strings
Queue<string> myQ = new();

// Add items to the end of the queue
myQ.Enqueue("one");
myQ.Enqueue("two");
myQ.Enqueue("three");
myQ.Enqueue("four");
myQ.Enqueue("five");

// use the count property to see how many items there are
Console.WriteLine($"Item Count: {myQ.Count}");

// Queues can be iterated without changing the structure
foreach (string s in myQ)
{
    Console.WriteLine(s);
}

// peek at the front of the queue
string str = myQ.Peek();
Console.WriteLine($"The first item is {str}");

// remove items from the front of the queue
str = myQ.Dequeue();
Console.WriteLine($"Dequeued item is {str}");
str = myQ.Dequeue();
Console.WriteLine($"Dequeued item is {str}");
Console.WriteLine($"Item Count: {myQ.Count}");

// see if the queue contains an item
Console.WriteLine($"Queue contains 'one': {myQ.Contains("one")}");
Console.WriteLine($"Queue contains 'four': {myQ.Contains("four")}");

// Remove all the items
myQ.Clear();
Console.WriteLine($"Item Count: {myQ.Count}");
