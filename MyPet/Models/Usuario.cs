using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Usuario
    {
        public string DNI { get; set; }
        public string CONTRASENA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string EMAIL { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public int ESTADO { get; set; }
        public int TIPO_USUARIOS { get; set; }
        public int ID_SEXO { get; set; }
        public string TELEFONO { get; set; }
        public string CODIGO_POSTAL { get; set; }
        public string DIRECCION { get; set; }
    }
}