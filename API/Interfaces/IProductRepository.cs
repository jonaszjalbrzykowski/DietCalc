using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IProductRepository
    {
        public Task<Product> GetProductByIdAsync(int id);
        public Task<Product> GetProductByNameAsync(string name);
        public Task<IEnumerable<Product>> GetAllProductsAsync();
        public Task<ActionResult<Product>> AddProduct(ProductDto dto);
        public Task<bool> ProductExists(string name);



    }
}
