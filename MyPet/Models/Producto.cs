using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Producto
    {
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public String stock_actual { get; set; }
        public String stock_disponible { get; set; }
        public decimal precio { get; set; }
    }
}