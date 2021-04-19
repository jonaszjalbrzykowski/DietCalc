using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class MealModel
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> ProductLines { get; set; }
        public DateTime Date { get; set; }
    }
}
