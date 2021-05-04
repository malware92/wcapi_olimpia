using apiintermedio.api.Services;
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
                CoreLogin coreLogin = new CoreLogin();
                ConsumoApi api = new ConsumoApi();
                var datos = coreLogin.traerInfoLogin();
                var urlApi = "https://reconoserpruebas.olimpiait.com:6407";
                var path = urlApi + "/Login";
                var json = JsonConvert.SerializeObject(datos);
                var dato = api.ConsumePostNoToken(path, json);
                //var dato2 = api.GetApiHttpPost(path, json);
                //var infoData = JsonConvert.DeserializeObject<string>(dato);
                string responseOlimpia = dato;

                var path2 = urlApi + "/Documento/AprobacionMultiplesDocumentos";
                var json2 = "{\"procesoClienteId\":\"william123\",\"numeroAprobacion\":\"1\",\"tipoEndoso\":2,\"requiereATDP\":false,\"identificacionComercio\":9008397029,\"plantillas\":[{\"plantillaCodigo\":\"2FE21B47-2D3C-43CD-B483-A9FED82B46AE\",\"tipoDocumento\":3,\"camposPlantilla\":[{\"campoNombre\":\"NomGarante\",\"campoValor\":\"Juan\"},{\"campoNombre\":\"NumDocGarante\",\"campoValor\":\"101010101\"}]}],\"firmantes\":[{\"correoElectronico\":\"wiilliiam.delgado@gmail.com\",\"celular\":33232915235,\"nombre\":\"william\",\"apellido\":\"delgado\",\"identificacion\":\"1014294090\",\"tipoIdentificacion\":1,\"campoFirma\":\"FirmDeudor1\",\"tipoInvolucrado\":1},{\"correoElectronico\":\"sergio@gmail.com\",\"celular\":3002121509,\"nombre\":\"sergio\",\"apellido\":\"lopez\",\"identificacion\":\"101429409\",\"tipoIdentificacion\":1,\"campoFirma\":\"FirmDeudor2\",\"tipoInvolucrado\":2}]}";
                var dato2 = api.GetApiHttpPost(path2, json2, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ2NzdmNzRmLWI3ZDgtNGEyMC04ZDgyLWU2NTZmNjU5YmRmYyIsIm5iZiI6MTYxOTYyOTczOCwiZXhwIjoxNjE5NzE2MTM4LCJpYXQiOjE2MTk2Mjk3Mzh9.PdSKyJYJVjk5CTwR4Bi6kOV44DzbSidJE6dtEb6N7Eo");
                string responseOlimpia2 = dato2;
                var infoData = JsonConvert.DeserializeObject<string>(responseOlimpia2);
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
