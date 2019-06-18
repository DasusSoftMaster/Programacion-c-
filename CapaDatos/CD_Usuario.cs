using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CD_Usuario
    {
        private CD_Conexion Conexion = new CD_Conexion();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user, string pass)
        {
            string sql = "SELECT * FROM Usuarios where Username='" + user + "' and Password='" + pass+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;

        }
    }
}
