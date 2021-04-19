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
    public class ProductModelController : BaseApiController
    {
        private readonly IProductModelRepository repo;
        public ProductModelController(IProductModelRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAllProducts()
        {
            var products = await repo.GetAllProductModelsAsync();
            return Ok(products);
        }

        [HttpPost("add")]
        public async Task<ActionResult<ProductModel>> AddProductModel(ProductModelDto dto)
        {
            if (await ProductExists(dto.Name))
            {
                return BadRequest("Product already exists.");
            }
            return await repo.AddProductModel(dto);
        }

        private async Task<bool> ProductExists(string name)
        {
            return await repo.ProductModelExists(name);
        }

    }
}
