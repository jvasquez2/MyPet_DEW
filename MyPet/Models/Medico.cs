using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Medico
    {
        public string DNI { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELIIDO_MATERNO { get; set; }
        public int ID_ESPECIALIDAD { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }

    }
}