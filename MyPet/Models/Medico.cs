using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Medico
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String apellido_paterno { get; set; }
        public String apellido_materno { get; set; }
        public int id_especialidad { get; set; }
        public DateTime fecha_nacimiento { get; set; }
    }
}