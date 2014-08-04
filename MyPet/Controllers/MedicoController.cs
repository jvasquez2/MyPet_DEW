using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPet.Models;

namespace MyPet.Controllers
{
    public class MedicoController : Controller
    {
        mypetEntities mp = new mypetEntities();
        //
        // GET: /Medico/

        public ActionResult Index()
        {
            return View();
        }

        public List<especialidad> Especialidad()
        {
            var lista = from e in mp.especialidad select e;
            return lista.ToList();
        }

        public ActionResult RegistrarMedico()
        {
            ViewBag.especialidad = new SelectList(Especialidad(), "ID", "DESCRIPCION");
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarMedico(Medico reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.especialidad = new SelectList(Especialidad(), "ID", "DESCRIPCION");
                return View();
            }

            try
            {
                medico med = new medico();
                med.DNI = reg.DNI;
                med.NOMBRE = reg.NOMBRE;
                med.APELLIDO_PATERNO = reg.APELLIDO_PATERNO;
                med.APELLIDO_MATERNO = reg.APELIIDO_MATERNO;
                med.ID_ESPECIALIDAD = reg.ID_ESPECIALIDAD;
                med.FECHA_NACIMIENTO = reg.FECHA_NACIMIENTO;
                mp.medico.Add(med);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.especialidad = new SelectList(Especialidad(), "ID", "DESCRIPCION");
                return View();
            }
        }

    }
}
