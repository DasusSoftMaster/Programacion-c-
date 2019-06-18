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

namespace CapaPresentacion
{
    public partial class FormAlumno : Form
    {
        CN_Alumnos objetoCN = new CN_Alumnos();
        alumnos alum = new alumnos();
        public string id=null;
      

        public bool Editar =false;
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void InsertarAlumno_Load(object sender, EventArgs e)
        {

        }
   
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarAlum( txtNombre.Text, txtApPater.Text, txtApMater.Text, txtDirecc.Text, txtTelef.Text);
                    MessageBox.Show("Correctamente");
                    limpiar();
                    alum.MostrarAlumnos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo guardar" + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarAlum(txtNombre.Text, txtApPater.Text, txtApMater.Text, txtDirecc.Text, txtTelef.Text, id);
                    MessageBox.Show("Editado Correctamente");
                    Editar = false;
                        this.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar" + ex);
                }

            }


            
        }
        private void limpiar()
        {
            
            txtNombre.Text = "";
            txtApPater.Text = "";
            txtApMater.Text = "";
            txtDirecc.Text = "";
            txtTelef.Text = "";
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
          try
            {
                objetoCN.EditarAlum( txtNombre.Text, txtApPater.Text, txtApMater.Text, txtDirecc.Text, txtTelef.Text, id);
                MessageBox.Show("Editado Correctamente");
                Editar = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar" + ex);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
