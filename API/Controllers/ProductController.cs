using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IProductRepository repo;
        public ProductController(IProductRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await repo.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost("add")]
        public async Task<ActionResult<Product>> AddProduct(ProductDto dto)
        {
            if (await ProductExists(dto.Name))
            {
                return BadRequest("Product already exists.");
            }
            return await repo.AddProduct(dto);
        }

        private async Task<bool> ProductExists(string name)
        {
            return await repo.ProductExists(name);
        }
            
    }
}
