﻿using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MealModelDto
    {
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
        public DateTime Date { get; set; }
    }
}
