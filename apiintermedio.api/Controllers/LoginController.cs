using apiintermedio.api.Services;
using apiintermedio.api.Constants;
using apiintermedio.core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace apiintermedio.api.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
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
                return Ok(responseOlimpia);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
