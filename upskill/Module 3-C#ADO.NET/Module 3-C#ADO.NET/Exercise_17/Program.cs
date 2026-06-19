// Exercise 17: Null-Conditional Chaining in a Contact App
using System;
using System.Collections.Generic;

class Contact
{
    public string? Name        { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        var contacts = new List<Contact?>
        {
            new Contact { Name = "Alice", PhoneNumber = "9876543210" },
            new Contact { Name = null,    PhoneNumber = "1234567890" },
            null
        };

        foreach (var contact in contacts)
        {
            string display = contact?.Name ?? "(no name)";
            Console.WriteLine($"Contact: {display}  Phone: {contact?.PhoneNumber ?? "N/A"}");
        }
    }
}
