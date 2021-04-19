using API.Data.Migrations;
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
    public class MealController : BaseApiController 
    {
        private readonly IMealRepository repo;
        public MealController(IMealRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<MealModel>>> GetAllMeals()
        {
            var meals = await repo.GetAllMealsAsync();
            return Ok(meals);
        }

        [HttpPost("add")]
        public async Task<ActionResult<MealModel>> AddProduct(MealModelDto dto)
        {
            if (await MealExists(dto.Name))
            {
                return BadRequest("Meal already exists.");
            }
            return await repo.AddMeal(dto);
        }

        private async Task<bool> MealExists(string name)
        {
            return await repo.MealExists(name);
        }
    }
}
