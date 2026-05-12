using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProductCatalogApp.Data;
using ProductCatalogApp.Models;

namespace ProductCatalogApp.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService() => _context = new AppDbContext();

        public List<Product> GetAllProducts() => _context.Products.Include(p => p.Category).ToList();
        
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        
        // Additional CRUD methods...
    }
}
