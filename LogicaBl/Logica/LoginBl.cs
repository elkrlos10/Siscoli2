using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBl.Logica
{
    public class LoginBl
    {

        public Usuario ConsultarUsuario(Usuario oUsuario)
        {
            Model1 entity = new Model1();
            var usuario = (from i in entity.Usuario
                           where i.NombreUsuario == oUsuario.NombreUsuario && i.Contrasena == oUsuario.Contrasena
                           select i).FirstOrDefault();

            return usuario;
        }
    }
}
