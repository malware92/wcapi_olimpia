using apiintermedio.dbo.Selects;
using apiintermedio.entity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiintermedio.core
{
    public class BusquedaSolicitud
    {
        public fe_doc_contratogarantia ConsultaDatosSolicitud(string sol)
        {
            fe_doc_contratogarantia temp = new fe_doc_contratogarantia();
            DatosSolicitud datosSolicitud = new DatosSolicitud();
            temp = datosSolicitud.DatosSolicitudTemp(sol);
            return temp;
        }
    }
}
