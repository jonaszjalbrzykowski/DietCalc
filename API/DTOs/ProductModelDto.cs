using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class ProductModelDto
    {
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Fats { get; set; }
        public decimal Sugars { get; set; }
        public decimal Proteins { get; set; }
    }
}
