using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using API_APOSTILA.Domain.Helpers;
using API_APOSTILA.Domain.Models;

namespace API_APOSTILA.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

         [Required]
        public short QuantityInPackage { get; set; }

        [Required]
        public EunitOfMeasurement UnitOfMeasurement { get; set; }

        [Required]
        public int CategoryId  { get; set; }
    }
}