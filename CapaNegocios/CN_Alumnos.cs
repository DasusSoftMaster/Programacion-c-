using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
   public class CN_Alumnos
    {
        private CD_Alumnos objetoCD = new CD_Alumnos(); 

        public DataTable MostrarAlum()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarAlum( string nombre, string apPater, string apMater, string direcc, string telf)
        {
            objetoCD.Insertar(nombre,apPater,apMater,direcc,telf);
        }

        public void EditarAlum( string nombre, string apPater, string apMater, string direcc, string telf,string id)
        {
            objetoCD.Editar( nombre, apPater, apMater, direcc, telf, Convert.ToInt32(id));
        }
    }
}
