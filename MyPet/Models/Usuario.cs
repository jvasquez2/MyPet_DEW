using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Usuario
    {
        public string CODIGO { get; set; }
        public string CONTRASENA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELIDO_MATERNO { get; set; }
        public string EMAIL { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public int ESTADO { get; set; }
        public int TIPO_USUARIOS { get; set; }
    }
}