using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datos;

namespace Presentacion1.Controllers
{
    public class PermisosController : Controller
    {
        // GET: Permisos
        public ActionResult Index()
        {
            return View();
        }
    }
}