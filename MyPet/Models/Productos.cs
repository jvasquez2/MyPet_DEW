using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Productos
    {
        public int id_prod { get; set; }
        public string nombre_prod { get; set; }
        public string descripcion { get; set; }
        public string peso { get; set; }
        public string precio { get; set; }
        public string dimensiones { get; set; }

    }
}