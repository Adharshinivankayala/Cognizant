// Exercise 16: Handle Null References Safely
using System;

class Person
{
    public string?  Name    { get; set; }
    public Address? Address { get; set; }
}

class Address
{
    public string? City { get; set; }
}

class Program
{
    static void Main()
    {
        Person? p = null;
        Console.WriteLine(p?.Name ?? "No name (person is null)");

        p = new Person { Name = "Bob", Address = null };
        Console.WriteLine(p?.Name ?? "No name");
        Console.WriteLine(p?.Address?.City ?? "No city (address is null)");

        p.Address = new Address { City = "Hyderabad" };
        Console.WriteLine(p?.Address?.City ?? "No city");
    }
}
