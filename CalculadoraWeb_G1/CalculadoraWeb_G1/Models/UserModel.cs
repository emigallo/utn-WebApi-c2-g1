using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb_G1.Models
{
    public class UserModel
    {
        public UserModel()
        {
        }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}
