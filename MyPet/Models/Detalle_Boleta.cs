using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Detalle_Boleta
    {
        public int numero { get; set; }
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal bruto { get; set; }
        public decimal descuento { get; set; }
        public decimal igv { get; set; }
        public decimal valor_venta { get; set; }
    }
}