using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPeliculas.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string nombre, string apellido, int numVeces=1)
        {
            ViewBag.nombre = nombre;
            ViewBag.apellido = apellido;
            ViewBag.NumVeces = numVeces;
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido + ", veces mostrado: ";
            return View();
        }
    }
}