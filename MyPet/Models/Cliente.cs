using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Cliente
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese nombre")]
        public string apelido_materno { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese apellido")]
        public string direccion { get; set; }
        public string codigo_postal { get; set; }
        public int id_sexo { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    }
}