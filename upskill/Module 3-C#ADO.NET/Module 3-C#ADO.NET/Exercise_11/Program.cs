// Exercise 11: Access Modifiers
using System;

class Animal
{
    public    string Name      = "Animal";
    private   string secret    = "hidden";
    protected string family    = "Mammal";

    public void ShowAll() => Console.WriteLine($"Name={Name}, Secret={secret}, Family={family}");
}

class Dog : Animal
{
    public void ShowInherited() => Console.WriteLine($"Dog family: {family}"); // OK
    // Cannot access secret (private)
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        a.ShowAll();
        Console.WriteLine($"Public Name: {a.Name}");   // OK
        // a.secret   → compile error
        // a.family   → compile error

        Dog d = new Dog();
        d.ShowInherited();
    }
}
