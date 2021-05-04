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
                CoreLogin coreLogin = new CoreLogin();
                ConsumoApi api = new ConsumoApi();
                var datos = coreLogin.traerInfoLogin();
                var urlApi = "https://reconoserpruebas.olimpiait.com:6407";
                var path = urlApi + "/Login";
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