﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace API_APOSTILA.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]

        public string Name { get; set; }
    }
}
