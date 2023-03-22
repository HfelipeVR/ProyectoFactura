using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace FACTURACION.Modelos.DAO
{
    public class Conexion
    {
        //Creación de Ojeto: MiConexion
        protected SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["UsuarioDAO"].ConnectionString);


    }
}
