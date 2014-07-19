using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Boleta
    {
        public int numero { get; set; }
        public string dni { get; set; }
        public string razon_social { get; set; }
        public decimal brutos { get; set; }
        public decimal descuento { get; set; }
        public decimal igv { get; set; }
        public decimal valor_venta { get; set; }
    }
}