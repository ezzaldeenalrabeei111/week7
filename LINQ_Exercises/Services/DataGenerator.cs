using System.Collections.Generic;
using LINQ_Exercises.Models;

namespace LINQ_Exercises.Services
{
    public static class DataGenerator
    {
        public static List<Student> GetStudents() => new List<Student>
        {
            new Student { Id = 1, Name = "Ahmed", Age = 20, Grade = 85.5, Department = "IT" },
            new Student { Id = 2, Name = "Sara", Age = 22, Grade = 92.0, Department = "CS" },
            new Student { Id = 3, Name = "Ali", Age = 19, Grade = 78.0, Department = "IT" },
            new Student { Id = 4, Name = "Mona", Age = 21, Grade = 88.5, Department = "IS" },
            new Student { Id = 5, Name = "Omar", Age = 23, Grade = 95.0, Department = "CS" }
        };

        public static List<Product> GetProducts() => new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 25, Stock = 50 },
            new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 45, Stock = 30 }
        };
    }
}
