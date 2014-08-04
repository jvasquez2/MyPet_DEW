using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPet.Models;
namespace MyPet.Controllers
{
    public class UsuarioController : Controller
    {
        mypetEntities mp = new mypetEntities();
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }

        public List<estado> Estado() 
        {
            var lista = from e in mp.estado select e;
            return lista.ToList();
        }

        public List<tipo_usuario> TipoUsuario() 
        {
            var lista = from tu in mp.tipo_usuario select tu;
            return lista.ToList();
        }

        public List<sexo> Sexo()
        {
            var lista = from s in mp.sexo select s;
            return lista.ToList();
        }

        public List<tabla_postal> Tabla_postal() 
        {
            var lista = from tp in mp.tabla_postal select tp;
            return lista.ToList();
        }

        public ActionResult RegistrarUsuario() 
        {
            ViewBag.estado = new SelectList(Estado(), "ID", "DESCRIPCION");
            ViewBag.tipousuario = new SelectList(TipoUsuario(), "ID", "DESCRIPCION");
            ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
            ViewBag.tablapostal = new SelectList(Tabla_postal(), "CODIGO", "DESCRIPCION");
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUsuario(Usuario reg) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.estado = new SelectList(Estado(), "ID", "DESCRIPCION");
                ViewBag.tipousuario = new SelectList(TipoUsuario(), "ID", "DESCRIPCION");
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
                ViewBag.tablapostal = new SelectList(Tabla_postal(), "CODIGO", "DESCRIPCION");
                return View();
            }

            try
            {
                usuario usu = new usuario();
                usu.DNI = reg.DNI;
                usu.CONTRASENA = reg.CONTRASENA;
                usu.NOMBRE = reg.NOMBRE;
                usu.APELLIDO_PATERNO = reg.APELLIDO_PATERNO;
                usu.APELLIDO_MATERNO = reg.APELLIDO_MATERNO;
                usu.EMAIL = reg.EMAIL;
                usu.FECHA_INGRESO = reg.FECHA_INGRESO;
                usu.ESTADO = reg.ESTADO;
                usu.TIPO_USUARIOS = reg.TIPO_USUARIOS;
                usu.ID_SEXO = reg.ID_SEXO;
                usu.TELEFONO = reg.TELEFONO;
                usu.CODIGO_POSTAL = reg.CODIGO_POSTAL;
                usu.DIRECCION = reg.DIRECCION;
                mp.usuario.Add(usu);
                mp.SaveChanges();
                return RedirectToAction("../Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.estado = new SelectList(Estado(), "ID", "DESCRIPCION");
                ViewBag.tipousuario = new SelectList(TipoUsuario(), "ID", "DESCRIPCION");
                ViewBag.sexo = new SelectList(Sexo(), "ID", "DESCRIPCION");
                ViewBag.tablapostal = new SelectList(Tabla_postal(), "CODIGO", "DESCRIPCION");
                return View();
            }
        }

       

    }
}
