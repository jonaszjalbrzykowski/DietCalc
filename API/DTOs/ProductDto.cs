﻿using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class ProductDto
    {
        public ProductModel ProductModel { get; set; }
        public decimal Weight { get; set; }
    }
}
