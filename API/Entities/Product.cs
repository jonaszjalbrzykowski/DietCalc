using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Fats { get; set; }
        public decimal Sugars { get; set; }
        public decimal Proteins { get; set; }        
    }
}
