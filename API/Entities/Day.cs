using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IList<Meal> Meals { get; set; }        
    }
}
