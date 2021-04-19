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
    public class ProductModelRepository : IProductModelRepository
    {
        private readonly DataContext context;
        public ProductModelRepository(DataContext _context)
        {
            context = _context;
        }
        public async Task<ActionResult<ProductModel>> AddProductModel(ProductModelDto dto)
        {
            var ProductModel = new ProductModel()
            {
                Name = dto.Name,
                Calories = dto.Calories,                
                Fats = dto.Fats,
                Proteins = dto.Proteins,
                Sugars = dto.Sugars
            };
            context.ProductModels.Add(ProductModel);
            await context.SaveChangesAsync();
            return ProductModel;
        }
        public async Task<IEnumerable<ProductModel>> GetAllProductModelsAsync()
        {
            return await context.ProductModels.ToListAsync();
        }

        public async Task<ProductModel> GetProductModelByIdAsync(int id)
        {
            return await context.ProductModels.FindAsync(id);
        }

        public async Task<ProductModel> GetProductModelByNameAsync(string name)
        {
            return await context.ProductModels.SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> ProductModelExists(string name)
        {
            return await context.ProductModels.AnyAsync(x => x.Name == name.ToLower());
        }
    }
}
