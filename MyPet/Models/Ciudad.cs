using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyPet.Models
{
    public class Ciudad
    {
        [MinLength(8)]
        [MaxLength(8)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese código")]
        public string id_ciudad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese nombre")]
        public string descrip_ciudad { get; set; }
    }
}