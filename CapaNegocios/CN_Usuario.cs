using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class CN_Usuario
    {
        private CD_Usuario objDato = new CD_Usuario();

        private String _Usuario;
        private String _Contraseña;

        public String Usuario
        {
            set { _Usuario = value; }
            get { return _Usuario; }
        }
        public String Contraseña
        {
            set { _Contraseña = value; }
            get { return _Contraseña; }
        }

        public CN_Usuario()
        {
        }


        //Metodos
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSesion(Usuario,Contraseña);
            return Loguear;
        }

    }
}
