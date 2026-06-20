using System;

class Program
{
    static Product LinearSearch(Product[] products, int searchId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == searchId)
                return product;
        }

        return null;
    }

    static Product BinarySearch(Product[] products, int searchId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == searchId)
                return products[mid];

            if (products[mid].ProductId < searchId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shoes", "Fashion"),
            new Product(103, "Mobile", "Electronics"),
            new Product(104, "Watch", "Accessories"),
            new Product(105, "Book", "Education")
        };

        int searchId = 104;

        Console.WriteLine("Linear Search Result:");
        Product linearResult = LinearSearch(products, searchId);

        if (linearResult != null)
            linearResult.DisplayProduct();

        Console.WriteLine();

        Console.WriteLine("Binary Search Result:");
        Product binaryResult = BinarySearch(products, searchId);

        if (binaryResult != null)
            binaryResult.DisplayProduct();
    }
}