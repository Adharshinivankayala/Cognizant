// Exercise 29: Sanitize Input and Prevent XSS
using System;
using System.Web;

class Program
{
    static string SanitizeInput(string input) => HttpUtility.HtmlEncode(input);

    static void Main()
    {
        string[] inputs = {
            "Hello, World!",
            "<script>alert('XSS Attack!')</script>",
            "<b>Bold</b> & <i>Italic</i>",
            "Normal text"
        };

        Console.WriteLine($"{"Raw Input",-45} | Sanitized Output");
        Console.WriteLine(new string('-', 90));
        foreach (var input in inputs)
            Console.WriteLine($"{input,-45} | {SanitizeInput(input)}");
    }
}
