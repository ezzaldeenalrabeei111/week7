using System;
using System.Linq;
using BlogEngineDataLayer.Data;
using BlogEngineDataLayer.Models;
using System.Collections.Generic;

namespace BlogEngineDataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Blog Engine Data Layer Demo ===");
            
            using (var context = new BlogDbContext())
            {
                Console.WriteLine("Initializing database connection...");
                
                // This is a demonstration of how to use the Data Layer
                // In a real scenario, you would run migrations first.
                
                var demoPost = new Post 
                { 
                    Title = "Learning EF Core 10", 
                    Content = "SOLID principles are great!",
                    PublishedDate = DateTime.Now 
                };

                Console.WriteLine($"Created Post: {demoPost.Title}");
                Console.WriteLine("Data Layer is ready for M:N relationships and Fluent API.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
