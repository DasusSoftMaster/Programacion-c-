using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Usuario objCOnsulta = new CN_Usuario();
            SqlDataReader Loguear;
            objCOnsulta.Usuario =txtUsuario.Text;
            objCOnsulta.Contraseña = txtContrasea.Text;
            Loguear = objCOnsulta.IniciarSesion();
            if (Loguear.Read()==true)
            {
                this.Hide();
                MessageBox.Show("Bienvenido");
            }

        }

     

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SplashScreen mp = new SplashScreen();

            CN_Usuario objCOnsulta = new CN_Usuario();
            SqlDataReader Loguear;
            objCOnsulta.Usuario = txtUsuario.Text;
            objCOnsulta.Contraseña = txtContrasea.Text;
            Loguear = objCOnsulta.IniciarSesion();
            if (Loguear.Read() == true)
            {
                mp.Show();
                this.Hide();
            }
            mp.Show();
            this.Hide();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;

            txtContrasea.isPassword = true;
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString ();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
