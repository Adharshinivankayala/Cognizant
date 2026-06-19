// Exercise 19: Lists and Dictionaries
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var fruits = new List<string> { "Apple", "Banana", "Cherry" };
        fruits.Add("Date");
        fruits.Remove("Banana");
        Console.WriteLine("List<string>:");
        foreach (var f in fruits) Console.WriteLine($"  {f}");

        var dict = new Dictionary<int, string> { {1,"One"},{2,"Two"},{3,"Three"} };
        dict[4] = "Four";
        dict.Remove(2);
        Console.WriteLine("Dictionary<int,string>:");
        foreach (var kv in dict) Console.WriteLine($"  {kv.Key} => {kv.Value}");
    }
}
