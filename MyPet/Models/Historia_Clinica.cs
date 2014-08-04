using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPet.Models
{
    public class Historia_Clinica
    {
        public int dni_cliente { get; set; }
        public int id_mascota { get; set; }
        public int id { get; set; }
        public int cita { get; set; }
        public int receta { get; set; }
        public int descripcion { get; set; }
    }
}