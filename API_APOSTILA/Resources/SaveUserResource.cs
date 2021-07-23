using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_APOSTILA.Resources
{
    public class SaveUserResource
    {
         [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }

        
    }
}