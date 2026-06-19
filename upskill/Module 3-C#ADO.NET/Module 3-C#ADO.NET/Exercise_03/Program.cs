// Exercise 3: Use Primary Constructors in C# 12
using System;

class Person(string firstName, string lastName, int age)
{
    public string FirstName { get; } = firstName;
    public string LastName  { get; } = lastName;
    public int    Age       { get; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        var person = new Person("Alice", "Smith", 30);
        person.DisplayInfo();
    }
}
