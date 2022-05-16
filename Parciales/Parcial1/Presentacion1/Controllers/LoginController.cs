using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Logica;

namespace Presentacion1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            UsuarioLogica.ObtenerAcciones(2);
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string pass)
        { 
            var usuario = UsuarioLogica.ValidarLogin(user, pass);
            if (usuario == null)
                return View("Login");
            TempData["permisos"] = UsuarioLogica.ObtenerAcciones(usuario.IdUsuario);
            return RedirectToAction("Index", "Permisos");
        }
    }
}