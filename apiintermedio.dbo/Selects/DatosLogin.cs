using apiintermedio.entity.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiintermedio.dbo.Selects
{
    public class DatosLogin : Conexiones
    {
        public fe_login DataLogin()
        {
            try
            {
                //var data = _ctx.Database.SqlQuery<sys_rol>("EXEC [dbo].[SP_INSERT_FLUJO_FACTURACION_PERFIL] @IDTIPOPERFIL, @IDTIPOESTADOFACTURA, @IDTIPOPERFILREDIRECCION",
                //    new SqlParameter("@IDTIPOPERFIL", idTipoPerfil),
                //    new SqlParameter("@IDTIPOESTADOFACTURA", idTipoEstadoFactura),
                //    new SqlParameter("@IDTIPOPERFILREDIRECCION", idTipoPerfilDireccion)).FirstOrDefault();
                var data = new fe_login();
                data.idAplicacion = "4677F74F-B7D8-4A20-8D82-E656F659BDFC";
                data.usuario = "usu_maf";
                data.contrasena = "Eg8Q0pkqGP";
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
