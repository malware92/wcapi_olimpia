using apiintermedio.entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiintermedio.dbo.Selects
{
    public class DatosSolicitud
    {
        public fe_doc_contratogarantia DatosSolicitudTemp(string sol)
        {
            try
            {
                var data = new fe_doc_contratogarantia();
                data.nombreTest = "NombreTest "+ sol;
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
