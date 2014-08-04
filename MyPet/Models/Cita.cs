using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Cita
    {
        public int id { get; set; }
        public string codigo_medico { get; set; }
        public string dni_cliente { get; set; }
        public int id_mascota { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public int estado { get; set; }
    }
}