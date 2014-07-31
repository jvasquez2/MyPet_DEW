using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPet.Models;

namespace MyPet.Controllers
{
    public class IndexController : Controller
    {

        mypetEntities1 mp = new mypetEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Nosotros()
        {
            return View();
        }

        public ActionResult Servicios()
        {
            return View();
        }

        //public ActionResult Productos()
        //{
        //    var lista = from p in mp.ciudad
        //                 select new Ciudad
        //                 {
        //                     id_ciudad = p.id_ciudad,
        //                     descrip_ciudad = p.descripcion_ciu
        //                 };
        //
        //     return View(lista);
        //}



    }
}
