using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IProductModelRepository
    {
        public Task<ProductModel> GetProductModelByIdAsync(int id);
        public Task<ProductModel> GetProductModelByNameAsync(string name);
        public Task<IEnumerable<ProductModel>> GetAllProductModelsAsync();
        public Task<ActionResult<ProductModel>> AddProductModel(ProductModelDto dto);
        public Task<bool> ProductModelExists(string name);
    }
}
