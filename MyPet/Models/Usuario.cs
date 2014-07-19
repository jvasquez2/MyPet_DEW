using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Usuario
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string email { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public int estado { get; set; }
        public int tipo_usuarios { get; set; }
    }
}