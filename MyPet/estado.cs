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
    
    public partial class estado
    {
        public estado()
        {
            this.usuario = new HashSet<usuario>();
        }
    
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<usuario> usuario { get; set; }
    }
}