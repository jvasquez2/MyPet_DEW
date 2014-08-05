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

        public ActionResult Listar()
        {
            var lista = from c in mp.cliente
                        select new Cliente
                        {
                            dni = c.DNI,
                            nombre = c.NOMBRE,
                            apellido_paterno = c.APELLIDO_PATERNO,
                            apelido_materno = c.APELLIDO_MATERNO,
                            direccion = c.DIRECCION,
                            codigo_postal = c.CODIGO_POSTAL,
                            id_sexo = (Int32) c.ID_SEXO,
                            email = c.EMAIL,
                            telefono = c.TELEFONO
                        };
            return View(lista.ToList());
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
        public ActionResult RegistroCliente(Usuario reg)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION", reg.ID_SEXO);
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION", reg.CODIGO_POSTAL);
                return View();
            }
            try
            {
                DateTime Hoy = DateTime.Today;
                cliente cli = new cliente();
                usuario usu = new usuario();

                usu.DNI = reg.DNI;
                usu.CONTRASENA = reg.CONTRASENA;
                usu.NOMBRE = reg.NOMBRE;
                usu.APELLIDO_PATERNO = reg.APELLIDO_PATERNO;
                usu.APELLIDO_MATERNO = reg.APELLIDO_MATERNO;
                usu.DIRECCION = reg.DIRECCION;
                usu.CODIGO_POSTAL = reg.CODIGO_POSTAL;
                usu.ID_SEXO = reg.ID_SEXO;
                usu.EMAIL = reg.EMAIL;
                usu.TELEFONO = reg.TELEFONO;
                usu.ESTADO = 1;
                usu.TIPO_USUARIOS = 1;
                usu.FECHA_INGRESO = Hoy;
                mp.usuario.Add(usu);
                mp.SaveChanges();


                cli.DNI= reg.DNI;
                cli.NOMBRE = reg.NOMBRE;
                cli.APELLIDO_PATERNO = reg.APELLIDO_PATERNO;
                cli.APELLIDO_MATERNO = reg.APELLIDO_MATERNO;
                cli.DIRECCION = reg.DIRECCION;
                cli.CODIGO_POSTAL = reg.CODIGO_POSTAL;
                cli.ID_SEXO = reg.ID_SEXO;
                cli.EMAIL = reg.EMAIL;
                cli.TELEFONO = reg.TELEFONO;
                mp.cliente.Add(cli);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION", reg.ID_SEXO);
                ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION", reg.CODIGO_POSTAL);
                return View();
            }
            
        }

        public ActionResult ActualizarCliente(string dni = null) 
        {
            var registro = from c in mp.cliente
                           where c.DNI == dni
                           select new Cliente
                           {
                               dni = c.DNI,
                               nombre= c.NOMBRE,
                               apellido_paterno= c.APELLIDO_PATERNO,
                               apelido_materno = c.APELLIDO_MATERNO,
                               direccion = c.DIRECCION,
                               codigo_postal = c.CODIGO_POSTAL,
                               id_sexo = (Int32) c.ID_SEXO,
                               telefono = c.TELEFONO,
                               email = c.EMAIL
                           };

            ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
            ViewBag.tablapostal = new SelectList(TablaPostal(), "CODIGO", "DESCRIPCION");
            return View(registro.FirstOrDefault());
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
                usuario usu = mp.usuario.Find(reg.dni);
                usu.NOMBRE = reg.nombre;
                usu.APELLIDO_PATERNO = reg.apellido_paterno;
                usu.APELLIDO_MATERNO = reg.apelido_materno;
                usu.DIRECCION = reg.direccion;
                usu.CODIGO_POSTAL = reg.codigo_postal;
                usu.ID_SEXO = reg.id_sexo;
                usu.EMAIL = reg.email;
                usu.TELEFONO = reg.telefono;

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
                return RedirectToAction("Listar");
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
