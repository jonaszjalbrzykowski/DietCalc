using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Meal
    {
        public int Id { get; set; }
        IList<ProductLine> ProductLines { get; set; }
        DateTime Date { get; set; }
    }
}
