using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Cliente
    {
        public string id_cliente { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese nombre")]
        public string nombre { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese apellido")]
        public string apellido_paterno { get; set; }

       // [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese apellido")]
        public string apellido_materno { get; set; }

      //  [MinLength(8)]
//[MaxLength(8)]
     //   [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese código")]
        public string dni { get; set; }

        public string id_sexo { get; set; }

        public string id_pais { get; set; }
        public string id_ciudad { get; set; }
        public string id_distrito { get; set; }
        public string direccion { get; set; }
        public string referencia_direccion { get; set; }
        public string telefono { get; set; }
        public string tipo_usuario { get; set; }
    }
}