using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPet.Models;

namespace MyPet.Controllers
{
    public class ClienteController : Controller
    {
        mypetEntities1 mp = new mypetEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public List<sexo> Sexo()
        {
            var lista = from p in mp.sexo select p;
            return lista.ToList();
        }

        public List<tabla_postal> TablaPostal()
        {
            var lista = from p in mp.tabla_postal select p;
            return lista.ToList();
        }

     
        public ActionResult RegistroCliente()
        {
            ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
            ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION");
            return View();
        }

        [HttpPost]
        public ActionResult RegistroCliente(Cliente reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION", reg.id_sexo);
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION", reg.codigo_postal);
                return View();
            }
            try
            {
                cliente cli = new cliente();

                cli.DNI= reg.dni;
                cli.NOMBRE = reg.nombre;
                cli.APELLIDO_PATERNO = reg.apellido_paterno;
                cli.APELLIDO_MATERNO = reg.apelido_materno;
                cli.DIRECCION = reg.direccion;
                cli.CODIGO_POSTAL = reg.codigo_postal;
                cli.ID_SEXO = reg.id_sexo;
                cli.EMAIL = reg.email;
                cli.TELEFONO = reg.telefono;
                mp.cliente.Add(cli);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION", reg.id_sexo);
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION", reg.codigo_postal);
                return View();
            }
            
        }

        public ActionResult ActualizarCliente() 
        {
            ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
            ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION");
            return View();
        }

        [HttpPost]
        public ActionResult ActualizarCliente(Cliente reg) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION");
                return View();
            }
            try
            {
                cliente cli = mp.cliente.Find(reg.dni);
                cli.DNI = reg.dni;
                cli.NOMBRE = reg.nombre;
                cli.APELLIDO_PATERNO = reg.apellido_paterno;
                cli.APELLIDO_MATERNO = reg.apelido_materno;
                cli.DIRECCION = reg.direccion;
                cli.CODIGO_POSTAL = reg.codigo_postal;
                cli.ID_SEXO = reg.id_sexo;
                cli.EMAIL = reg.email;
                cli.TELEFONO = reg.telefono;
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION");
                return View();
                
            }
        }

    }
}
