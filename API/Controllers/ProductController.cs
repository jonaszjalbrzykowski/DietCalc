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

        [HttpPost("add")]
        public async Task<ActionResult<Product>> AddProduct(ProductDto dto)
        {
            return await repo.AddProduct(dto);
        }
 
    }
}
