using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPet.Models;

namespace MyPet.Controllers
{
    public class MascotaController : Controller
    {
        mypetEntities mp = new mypetEntities();
        // GET: /Mascota/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarMascota() 
        {
            var lista = mp.especie;
            var mas = new Mascota();
            mas.especie = lista;
            return View(mas);
        }

        [HttpPost]
        public ActionResult RegistrarMascota(Mascota reg) 
        {
            if (reg.id_especie != 0 && reg.id_raza == 0) 
            {
                reg.especie = mp.especie;
                reg.raza = mp.raza.Where(c => c.ID_ESPECIE == reg.id_especie);
                return View(reg);
            }

            var id = reg.id_raza;
            var nombreRaza = mp.raza.FirstOrDefault(c => c.ID == id);
            try
            {
                mascota masc = new mascota();
                masc.DNI = reg.dni;
                masc.ID = reg.id;
                masc.NOMBRE = reg.nombre;
                masc.ID_ESPECIE = reg.id_especie;
                masc.ID_RAZA = reg.id_raza;
                masc.FECHA_NACIMIENTO = reg.fecha_nacimiento;
                mp.mascota.Add(masc);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                reg.especie = mp.especie;
                reg.raza = mp.raza.Where(c => c.ID_ESPECIE == reg.id_especie);
                return View(reg);
            }
        }

    }
}
