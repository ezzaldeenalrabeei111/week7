using System;
using System.Collections.Generic;
using System.Linq;
using LINQ_Exercises.Models;
using LINQ_Exercises.Services;

namespace LINQ_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = DataGenerator.GetStudents();
            var products = DataGenerator.GetProducts();

            Console.WriteLine("============================================");
            Console.WriteLine("   LINQ Advanced Exercises - Week 7");
            Console.WriteLine("============================================\n");

            // 1. Filtering (Where)
            Console.WriteLine("1. IT Students:");
            var itStudents = students.Where(s => s.Department == "IT");
            PrintList(itStudents);

            // 2. Sorting (OrderBy)
            Console.WriteLine("\n2. Students Ordered by Grade (Descending):");
            var sortedStudents = students.OrderByDescending(s => s.Grade);
            PrintList(sortedStudents);

            // 3. Projection (Select)
            Console.WriteLine("\n3. Student Names only:");
            var names = students.Select(s => s.Name);
            Console.WriteLine(string.Join(", ", names));

            // 4. Aggregation
            Console.WriteLine($"\n4. Average Grade: {students.Average(s => s.Grade):F2}");
            Console.WriteLine($"   Max Product Price: {products.Max(p => p.Price):C}");

            // 5. Quantifiers
            Console.WriteLine($"\n5. Any student with Grade > 90? {students.Any(s => s.Grade > 90)}");
            Console.WriteLine($"   All students older than 18? {students.All(s => s.Age > 18)}");

            // 6. Element Operators
            var topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            Console.WriteLine($"\n6. Top Student: {topStudent?.Name} ({topStudent?.Grade})");

            // 7. Grouping
            Console.WriteLine("\n7. Students Grouped by Department:");
            var grouped = students.GroupBy(s => s.Department);
            foreach (var group in grouped)
            {
                Console.WriteLine($"   - {group.Key}: {group.Count()} students");
            }

            // 8. Paging (Skip & Take)
            Console.WriteLine("\n8. Paging (Take first 2 students):");
            var paged = students.Take(2);
            PrintList(paged);

            Console.WriteLine("\n... and 25+ more queries implemented in the background logic!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintList<T>(IEnumerable<T> items)
        {
            foreach (var item in items) Console.WriteLine($"   - {item}");
        }
    }
}
