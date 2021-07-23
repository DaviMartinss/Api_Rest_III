using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Helpers;

namespace API_APOSTILA.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EunitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
