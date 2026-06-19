// Exercise 24: Serialize and Deserialize JSON
using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name  { get; set; } = "";
    public int    Age   { get; set; }
    public string Email { get; set; } = "";
}

class Program
{
    static void Main()
    {
        var user    = new User { Name = "Alice", Age = 30, Email = "alice@example.com" };
        string json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("Serialized JSON:\n" + json);

        File.WriteAllText("user.json", json);
        Console.WriteLine("Saved to user.json");

        string   loaded     = File.ReadAllText("user.json");
        User?    deserialized = JsonSerializer.Deserialize<User>(loaded);
        Console.WriteLine($"\nDeserialized -> Name: {deserialized?.Name}, Age: {deserialized?.Age}, Email: {deserialized?.Email}");
    }
}
