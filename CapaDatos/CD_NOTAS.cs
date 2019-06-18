using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_NOTAS
    {
        private CD_Conexion Conexion = new CD_Conexion();
        private SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        private SqlDataReader leer;

       

        public DataTable Mostrar(string materia)
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "MostrarNotas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Materia", materia);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            Conexion.CerrarConexion();
            return tabla;
        }

 

        public DataTable ListarTrimestres()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "ListarTrimestres";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ListarCursos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "ListarCursos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            Conexion.CerrarConexion();
            return tabla;
        }

        public int datos;
        public DataTable ListarResultado(int alumno,int trimestre, int materia)
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select Idnotas,Materia ,Trimestre,Calificacion, Nombre as Alumno from NOTAS INNER JOIN CURSOS ON NOTAS.IdMateria = CURSOS.IdMateria INNER JOIN TRIMESTRES ON NOTAS.IdTrimestre = TRIMESTRES.IdTrimestre INNER JOIN ALUMNO ON NOTAS.IdAlumno = ALUMNO.IdAlumno " +
                "where ALUMNO.IdAlumno='"+alumno+ "' AND TRIMESTRES.IdTrimestre='" + trimestre + "'  AND CURSOS.IdMateria='" + materia + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
        public void Editar(decimal triUNO, decimal triDOS,decimal triTRES,string Materia, int id)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "EditarNota";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@materia", Materia);
            comando.Parameters.AddWithValue("@tUNO", triUNO);
            comando.Parameters.AddWithValue("@tDOS",triDOS );
            comando.Parameters.AddWithValue("@tTRES", triTRES);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
