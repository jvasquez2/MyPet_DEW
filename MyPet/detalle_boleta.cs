//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPet
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_boleta
    {
        public int NUMERO { get; set; }
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<decimal> BRUTO { get; set; }
        public Nullable<decimal> DESCUENTO { get; set; }
        public Nullable<decimal> IGV { get; set; }
        public Nullable<decimal> VALOR_VENTA { get; set; }
    
        public virtual boleta boleta { get; set; }
        public virtual producto producto { get; set; }
    }
}
