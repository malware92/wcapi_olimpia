using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiintermedio.dbo
{
    public class Conexiones
    {
        public string _conexion { get; set; } = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL= TCP)(HOST=10.238.68.146)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=COLQA)));User Id=CREDITOSMAFCO;Password=CREDITOSMAFCO;";
        /*public Conexiones() //string conexion
        {
            //_conexion = conexion;
            _conexion = "(DESCRIPTION =(ADDRESS_LIST =(ADDRESS =(COMMUNITY=tcp.world)(PROTOCOL=TCP)(Host = 10.238.68.146)(Port = 1521)))(CONNECT_DATA = (SID=COLQA)))";
        }*/
        public void abrirConexion(){
            var conexion = new OracleConnection();
            conexion.ConnectionString = _conexion;
            conexion.Open();
        }
    }
}
