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
    public class MealRepository
    {
        private readonly DataContext context;
        public MealRepository(DataContext _context)
        {
            context = _context;
        }

        //public async Task<ActionResult<MealModel>> AddMeal(MealModelDto dto)
        //{
        //    var meal = new MealModel()
        //    {
        //        ProductLines = dto.Products,
        //        Date = dto.Date
        //    };
        //    context.Meals.Add(meal);
        //    await context.SaveChangesAsync();
        //    return meal;
        //}

        //public async Task<IEnumerable<MealModel>> GetAllMealsAsync()
        //{
        //    return await context.Meals.ToListAsync();
        //}

        //public async Task<MealModel> GetMealByIdAsync(int id)
        //{
        //    return await context.Meals.FindAsync(id);
        //}

        //public async Task<MealModel> GetMealByNameAsync(string name)
        //{
        //    return await context.Meals.SingleOrDefaultAsync(x => x.Name == name);
        //}

        //public async Task<bool> MealExists(string name)
        //{
        //    Task<bool> result = context.Meals.AnyAsync(x => x.Name.ToLower() == name.ToLower());
        //    return await result;
        //}
    }
}
