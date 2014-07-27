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
        mypetEntities mp = new mypetEntities();

        public ActionResult Index()
        {
            return View();
        }

        public List<sexo> Sexo()
        {
            var lista = from p in mp.sexo select p;
            return lista.ToList();
        }

        public List<pais> Pais()
        {
            var lista = from p in mp.pais select p;
            return lista.ToList();
        }

        public List<ciudad> Ciudad()
        {
            var lista = from p in mp.ciudad select p;
            return lista.ToList();
        }

        public List<distrito> Distrito()
        {
            var lista = from p in mp.distrito select p;
            return lista.ToList();
        }

        public ActionResult RegistroCliente()
        {
            ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
            ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
            ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
            ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
            return View();
        }

        [HttpPost]
        public ActionResult RegistroCliente(Cliente reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
                ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
                ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
                ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
                return View();
            }
            try
            {
                cliente cli = new cliente();
                cli.email = reg.email;
                cli.contrasena = reg.contrasena;
                cli.nombre = reg.nombre;
                cli.apellidoPat = reg.apellido_paterno;
                cli.apellidoMat = reg.apellido_materno;
                cli.dni = reg.dni;
                cli.id_sexo = reg.id_sexo;
                cli.id_pais = reg.id_pais;
                cli.id_ciudad = reg.id_ciudad;
                cli.id_distrito = reg.id_distrito;
                cli.direccion = reg.direccion;
                cli.referencia_direccion = reg.referencia_direccion;
                cli.telefono = reg.telefono;
                cli.tipo_usuario = "2";
                mp.cliente.Add(cli);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
                ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
                ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
                ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
                return View();
            }
            
        }

        public ActionResult ActualizarCliente() 
        {
            ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
            ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
            ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
            ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
            return View();
        }

        [HttpPost]
        public ActionResult ActualizarCliente(Cliente reg) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
                ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
                ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
                ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
                return View();
            }
            try
            {
                cliente cli = mp.cliente.Find(reg.id_cliente);
                cli.email = reg.email;
                cli.contrasena = reg.contrasena;
                cli.nombre = reg.nombre;
                cli.apellidoPat = reg.apellido_paterno;
                cli.apellidoMat = reg.apellido_materno;
                cli.dni = reg.dni;
                cli.id_sexo = reg.id_sexo;
                cli.id_pais = reg.id_pais;
                cli.id_ciudad = reg.id_ciudad;
                cli.id_distrito = reg.id_distrito;
                cli.direccion = reg.direccion;
                cli.referencia_direccion = reg.referencia_direccion;
                cli.telefono = reg.telefono;
                cli.tipo_usuario = "2";
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.sexo = new SelectList(Sexo(), "id_sexo", "descrip_sexo");
                ViewBag.pais = new SelectList(Pais(), "id_pais", "descrip_pais");
                ViewBag.ciudad = new SelectList(Ciudad(), "id_ciudad", "descripcion_ciu");
                ViewBag.distrito = new SelectList(Distrito(), "id_distrito", "descripcion_dist");
                return View();
                
            }
        }

    }
}
