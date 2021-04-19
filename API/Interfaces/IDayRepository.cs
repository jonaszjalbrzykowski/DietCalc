using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    interface IDayRepository
    {
        public Task<Day> GetDayByIdAsync(int id);
        public Task<Day> GetDayByNameAsync(string name);
        public Task<IEnumerable<Day>> GetAllDaysAsync();
        public Task<ActionResult<Day>> AddDay(DayDto dto);
        public Task<bool> DayExists(string name);
    }
}
