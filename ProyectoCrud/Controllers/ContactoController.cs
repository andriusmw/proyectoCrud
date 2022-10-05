using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCrud.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        //crea una cadena de conexión para conectarte a SQL server

        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        //Se conecta al archivo Web.config

        public ActionResult Inicio()
        {
            return View();
        }
    }
}