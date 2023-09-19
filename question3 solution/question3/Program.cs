﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class EcommerceApp
{
    public List<Product> SortProductsByPrice(List<Product> products, bool ascending)
    {
        if (ascending)
        {
            return products.OrderBy(product => product.Price).ToList();
        }
        else
        {
            return products.OrderByDescending(product => product.Price).ToList();
        }
    }
}

class Program
{
    static void Main()
    {
        // Sample list of products
        List<Product> products = new List<Product>
        {
            new Product { Name = "Product A", Price = 19.99m },
            new Product { Name = "Product B", Price = 9.99m },
            new Product { Name = "Product C", Price = 29.99m }
        };

        EcommerceApp ecommerceApp = new EcommerceApp();

        // Sort products in ascending order of price
        List<Product> ascendingSortedProducts = ecommerceApp.SortProductsByPrice(products, ascending: true);
        Console.WriteLine("Ascending Order:");
        foreach (var product in ascendingSortedProducts)
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }

        // Sort products in descending order of price
        List<Product> descendingSortedProducts = ecommerceApp.SortProductsByPrice(products, ascending: false);
        Console.WriteLine("\nDescending Order:");
        foreach (var product in descendingSortedProducts)
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
    }
}
// would prepare test cases using the the test data representing different prices and names
// would then use the sortproductbyprice function to sort test data in either ascending or descending order
// then i would write assertions to validate whether the test data is sorted as per the condition
// would then aoutomate the test using test framework such as selenium to make it consistent in other similar test cases