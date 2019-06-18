using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos

{
    public class CD_Alumnos
    {
        private CD_Conexion Conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarAlumnos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//Devuelve Filas
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla; 
        }
        
        public void Insertar(string nombre, string apPater, string apMater,string direcc,string telf)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "InsertarAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apPater", apPater);
            comando.Parameters.AddWithValue("@apMater", apMater);
            comando.Parameters.AddWithValue("@direcc", direcc);
            comando.Parameters.AddWithValue("@telf", telf);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

       public void Editar( string nombre, string apPater, string apMater, string direcc, string telf,int id)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EditarAlumno";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apPater", apPater);
            comando.Parameters.AddWithValue("@apMater", apMater);
            comando.Parameters.AddWithValue("@direcc", direcc);
            comando.Parameters.AddWithValue("@telf", telf);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
