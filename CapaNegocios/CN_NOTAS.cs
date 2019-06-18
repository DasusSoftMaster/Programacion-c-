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
    
    public class CN_NOTAS
    {
        private CD_NOTAS objetoCD = new CD_NOTAS();

        

       public DataTable MostrarNotas(string materia)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(materia);
            return tabla;
        }

        public void EditarNotas(string triUNO, string triDOS, string triTRES, string Materia, string id)
        {
            objetoCD.Editar (Convert.ToDecimal(triUNO),Convert.ToDecimal(triDOS),Convert.ToDecimal(triTRES), Materia, Convert.ToInt32(id));
        }
 

    }

    
}
