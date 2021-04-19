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
                ProductModel = dto.ProductModel,
                Weight = dto.Weight
            };
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return product;
        } 
    }
}
