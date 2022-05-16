using System;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace Negocio.Logica
{
    public class UsuarioLogica
    {
        static Model1 dbContext = new Model1();

        public static Usuario ValidarLogin(String user, String password)
        {
            Usuario usuario = new Usuario();
            usuario = dbContext.Usuarios.FirstOrDefault(u => u.Email == user && u.Clave == password);
            return usuario;
        }

        public static void getPermisos(int idUsuario)
        {
            Usuario usuario = dbContext.Usuarios.Where(u => u.IdUsuario == idUsuario).First();
            var permisos = usuario.Permiso.Descripcion;


            return;
        }

        public static List<Accione> ObtenerAcciones(int idUsuario)
        {
            Usuario usuario = dbContext.Usuarios.Where(u => u.IdUsuario == idUsuario).FirstOrDefault();
            
            var temp = dbContext.PermisosAcciones.Where(pa => pa.IdPermiso == usuario.IdPermiso).Select(p => p.IdAccion).ToList();

            var acciones = dbContext.Acciones.Where(a => temp.Contains(a.IdAccion)).ToList();


             return acciones;
        }
    }
}
