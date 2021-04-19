using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IMealRepository
    {
        public Task<MealModel> GetMealByIdAsync(int id);
        public Task<MealModel> GetMealByNameAsync(string name);
        public Task<IEnumerable<MealModel>> GetAllMealsAsync();
        public Task<ActionResult<MealModel>> AddMeal(MealModelDto dto);
        public Task<bool> MealExists(string name);
    }
}
