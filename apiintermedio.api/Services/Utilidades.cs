using apiintermedio.api.Constants;
using apiintermedio.core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiintermedio.api.Services
{
    public class Utilidades
    {
        public string GetTokenLoginOlimpia()
        {
            try
            {
                constantsOlimpia constants = new constantsOlimpia();
                CoreLogin coreLogin = new CoreLogin();
                ConsumoApi api = new ConsumoApi();
                var datos = coreLogin.traerInfoLogin();
                var urlApi = constants.OLIMPIA_URL;
                var path = urlApi + constants.OLIMPIA_PATH_LOGIN;
                var json = JsonConvert.SerializeObject(datos);
                var dato = api.ConsumePostNoToken(path, json);
                string responseOlimpia = dato;
                return responseOlimpia;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}