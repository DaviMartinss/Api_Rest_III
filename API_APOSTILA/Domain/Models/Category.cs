using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_APOSTILA.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
