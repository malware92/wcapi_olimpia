
using apiintermedio.dbo.Selects;
using apiintermedio.entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiintermedio.core
{
    public class CoreLogin
    {
        public fe_login traerInfoLogin()
        {
            fe_login login = new fe_login();
            DatosLogin datosLogin = new DatosLogin();
            login = datosLogin.DataLogin();
            return login;
        }
    }
}
