using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;
        public ProductRepository(DataContext _context)
        {
            context = _context;
        }
        public async Task<ActionResult<Product>> AddProduct(ProductDto dto)
        {
            var product = new Product()
            {
                Calories = dto.Calories,
                Fats = dto.Fats,
                Sugars = dto.Sugars,
                Proteins = dto.Proteins,
                Name = dto.Name
            };
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return product;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await context.Products.FindAsync(id);
        }

        public async Task<Product> GetProductByNameAsync(string name)
        {
            return await context.Products.SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> ProductExists(string name)
        {
            return await context.Products.AnyAsync(x => x.Name == name.ToLower());
        }
    }
}
