using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class salir : Form
    {
        public salir()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        MenuPrincipal mp = new MenuPrincipal();
        public int cerrar;
        private void btnSi_Click(object sender, EventArgs e)
        {
            
            switch (cerrar)
            {
                case 1:
                    
                    mp.Close();
                    Application.Exit();
                    this.Close();
                    break;

            }
        }

        private void salir_Load(object sender, EventArgs e)
        {
           
        }

        private void salir_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
