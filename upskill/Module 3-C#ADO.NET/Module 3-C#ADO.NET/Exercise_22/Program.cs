// Exercise 22: Tuples
using System;

class Program
{
    static (int Id, string Name) GetUser() => (1, "Alice");

    static void Main()
    {
        var user = GetUser();
        Console.WriteLine($"Id: {user.Id}, Name: {user.Name}");

        // Deconstruct
        (int id, string name) = GetUser();
        Console.WriteLine($"Deconstructed -> Id: {id}, Name: {name}");
    }
}
