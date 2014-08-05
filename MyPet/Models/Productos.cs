using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Productos
    {
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public int STOCK_ACTUAL { get; set; }
        public int STOCK_DISPONIBLE { get; set; }
        public decimal PRECIO { get; set; }
    }
}