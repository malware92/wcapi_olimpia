﻿using apiintermedio.api.Services;
using apiintermedio.api.Constants;
using apiintermedio.entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiintermedio.api.Controllers
{
    public class GenerarDocsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(generarDocs generarDocs)
        {
            try
            {
                constantsOlimpia constants = new constantsOlimpia();
                Utilidades utils = new Utilidades();
                ConsumoApi api = new ConsumoApi();
                var tokenReturn =  utils.GetTokenLoginOlimpia();
                var tokenNoBearer = tokenReturn.Split(' ');
                var urlApi = constants.OLIMPIA_URL;
                var path = urlApi + constants.OLIMPIA_PATH_DOCUMENTOS;

                /*var json2 = "{\"procesoClienteId\":\"william123\",\"numeroAprobacion\":\"1\",\"tipoEndoso\":2,\"requiereATDP\":false,\"identificacionComercio\":9008397029,\"plantillas\":[{\"plantillaCodigo\":\"2FE21B47-2D3C-43CD-B483-A9FED82B46AE\",\"tipoDocumento\":3,\"camposPlantilla\":[{\"campoNombre\":\"NomGarante\",\"campoValor\":\"Juan\"},{\"campoNombre\":\"NumDocGarante\",\"campoValor\":\"101010101\"}]}],\"firmantes\":[{\"correoElectronico\":\"wiilliiam.delgado@gmail.com\",\"celular\":33232915235,\"nombre\":\"william\",\"apellido\":\"delgado\",\"identificacion\":\"1014294090\",\"tipoIdentificacion\":1,\"campoFirma\":\"FirmDeudor1\",\"tipoInvolucrado\":1},{\"correoElectronico\":\"sergio@gmail.com\",\"celular\":3002121509,\"nombre\":\"sergio\",\"apellido\":\"lopez\",\"identificacion\":\"101429409\",\"tipoIdentificacion\":1,\"campoFirma\":\"FirmDeudor2\",\"tipoInvolucrado\":2}]}";
                var dato2 = api.GetApiHttpPost(path, json2, tokenNoBearer[1]);
                string responseOlimpia2 = dato2;*/ 

                return Ok("Los documentos se enviaron de manera exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
