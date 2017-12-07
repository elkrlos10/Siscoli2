using Datos.Datos;
using LogicaBl.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Siscoli.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ConsultarUsuario(Usuario oUsuario)
        {
            try
            {
                LoginBl loginBl = new LoginBl();

                var usuario = loginBl.ConsultarUsuario(oUsuario);

                return Ok(new { success = true, usuario });
            }
            catch (Exception e)
            {

                return Ok(new { success = false });
            }

        }

    }
}