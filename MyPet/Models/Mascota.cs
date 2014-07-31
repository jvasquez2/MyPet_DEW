using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Mascota
    {
        public String dni { get; set; }
        public int id { get; set; }
        public String nombre { get; set; }
        public int id_especie { get; set; }
        public int id_raza { get; set; }
        public DateTime fecha_nacimiento { get; set; }

}
}