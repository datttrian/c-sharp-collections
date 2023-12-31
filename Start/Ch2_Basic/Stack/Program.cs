﻿// TODO: Create an empty stack
Stack<string> myStack = new();

// TODO: The Push function pushes new elements onto the stack
myStack.Push("one");
myStack.Push("two");
myStack.Push("three");
myStack.Push("four");
myStack.Push("five");

// TODO: The Count property indicates how many elements are on the stack
Console.WriteLine($"Item Count: {myStack.Count}");

// TODO: Stacks can be enumerated in place without changing the content
foreach (string s in myStack)
{
    Console.WriteLine(s);
}

// TODO: The Peek function examines the current top element but does not remove it
string top = myStack.Peek();
Console.WriteLine(top);

// TODO: The Pop function removes an element from the top
string item = myStack.Pop();
Console.WriteLine(item);
Console.WriteLine($"Item Count: {myStack.Count}");

// TODO: Search for an element using Contains
Console.WriteLine($"Item found: {myStack.Contains("five")}");
Console.WriteLine($"Item found: {myStack.Contains("four")}");
