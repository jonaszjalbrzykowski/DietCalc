﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public ProductModel ProductModel { get; set; }
        public decimal Weight { get; set; }
    }
}
