using System;
using System.Collections.Generic;
using System.Linq;

//product class 
public class Product
{
    // product properties
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
        // product object
            List<Product> products = new List<Product>
        {
                    // Sample list of products

            new Product { Name = "Product A", Price = 1000 },
            new Product { Name = "Product B", Price = 501 },
            new Product { Name = "Product C", Price = 298 }
        };

        EcommerceApp ecommerceApp = new EcommerceApp();

        // Sort products in ascending order of price
        List<Product> ascendingSortedProducts = ecommerceApp.SortProductsByPrice(products, ascending: true);
        Console.WriteLine("Ascending Order:");
        foreach (var product in ascendingSortedProducts)
        {
            Console.WriteLine($"{product.Name}: {product.Price:C}");
        }
    }
}
// would prepare test cases using the test data (initially written) representing products with different prices and names
// would then use the sortproductbyprice function to sort test data in either ascending or descending order
// then i would write assertions to validate whether the test data is sorted as per the condition
// would then aoutomate the test using test framework such as selenium to make it consistent in other similar test cases