using System;

public class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Category: {Category}");
    }
}