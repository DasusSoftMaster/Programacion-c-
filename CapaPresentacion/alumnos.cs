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
    public partial class alumnos : Form
    {
        CN_Alumnos objetoCN = new CN_Alumnos();
        private bool Editar = false;
        public string id = null;
        public string idAlumno = null;
        public alumnos()
        {
            InitializeComponent();
        }

        private void alumnos_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();



        }

        public void MostrarAlumnos()
        {
            CN_Alumnos objeto = new CN_Alumnos();
            dataGridView1.DataSource = objeto.MostrarAlum();
        }

       


        private void btnEditar_Click_1(object sender, EventArgs e)
        {


            FormAlumno frm = new FormAlumno();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.Editar = true;
                
                frm.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.txtApPater.Text = dataGridView1.CurrentRow.Cells["Ap_Paterno"].Value.ToString();
                frm.txtApMater.Text = dataGridView1.CurrentRow.Cells["Ap_Materno"].Value.ToString();
                frm.txtDirecc.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.txtTelef.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                //txtDni.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                //txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                //txtApPater.Text = dataGridView1.CurrentRow.Cells["Ap_Paterno"].Value.ToString();
                //txtApMater.Text = dataGridView1.CurrentRow.Cells["Ap_Materno"].Value.ToString();
                //txtDirecc.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                //txtTelef.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                //idAlumno = dataGridView1.CurrentRow.Cells["IdAlumno"].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("SELECCIONE UNA FILA");
        
    }

       


       
    
   

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAlumno obj = new FormAlumno();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }
    }
}
