using System;
using ProductCatalogApp.Models;
using ProductCatalogApp.Services;

namespace ProductCatalogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Product Catalog Management System ===");
                Console.WriteLine("1. View All Products");
                Console.WriteLine("2. Add New Product");
                Console.WriteLine("5. Exit");
                Console.Write("\nSelect an option: ");

                var input = Console.ReadLine();
                if (input == "1")
                {
                    var products = productService.GetAllProducts();
                    Console.WriteLine("\n--- Product List ---");
                    foreach (var p in products)
                        Console.WriteLine($"ID: {p.ProductId} | Name: {p.Name} | Price: {p.Price:C} | Category: {p.Category?.CategoryName}");
                }
                else if (input == "2")
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Category ID (1 for Electronics, 2 for Furniture): ");
                    int catId = int.Parse(Console.ReadLine());

                    productService.AddProduct(new Product { Name = name, Price = price, CategoryId = catId });
                    Console.WriteLine("Product added successfully!");
                }
                else if (input == "5")
                {
                    exit = true;
                }
            }
        }
    }
}
