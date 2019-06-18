using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 50)
            {

                sidemenu.Visible = false;
                sidemenu.Width = 240;
                PanelAnimator.ShowSync(sidemenu);
                logoAnimator.ShowSync(logo);
            }
            else
            {
                logo.Hide();
                logoAnimator.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                PanelAnimator.ShowSync(sidemenu);

            }
        }

        public void alumnos_Click(object sender, EventArgs e)
        {
            alumnos fm = new alumnos();

            AbrirFormEnPanel(fm);
        }
        int LX, LY, SW, SH;

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Notas fm = new Notas();

            AbrirFormEnPanel(fm);
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }
           private void iconCerrar_Click(object sender, EventArgs e)
        {
            
            salir sl = new salir();
            sl.cerrar = 1;
            sl.ShowDialog();
           
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }
    }
}
