using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Notas : Form
    {

        CN_NOTAS objetoCN = new CN_NOTAS();
        public string id = null;

        public Notas()
        {
            InitializeComponent();
        }

        private void NOTAS_Load(object sender, EventArgs e)
        {
            //ListarAlumnos();
            //ListarTrimestres();
            ListarCursos();

           MostrarNotas ();


        }
        public void MostrarNotas()
        {
            CN_NOTAS objeto = new CN_NOTAS();
            dGridView1.DataSource = objeto.MostrarNotas(CbxCurso.SelectedValue.ToString());
        
        }

        /*  private void ListarAlumnos()
           {
               CD_NOTAS objCD = new CD_NOTAS();
               CbxAlumnos.DataSource = objCD.ListarAlumnos();
               CbxAlumnos.DisplayMember = "DNI";
               CbxAlumnos.ValueMember = "IdAlumno";
           }*/

    /*    private void ListarTrimestres()
        {
            CD_NOTAS objCD = new CD_NOTAS();
            CbxTrimestre .DataSource = objCD.ListarTrimestres();
            CbxTrimestre.DisplayMember = "Trimestre";
            CbxTrimestre.ValueMember = "IdTrimestre";
        }*/
        private void ListarCursos()
        {
            CD_NOTAS objCD = new CD_NOTAS();
            CbxCurso .DataSource = objCD.ListarCursos();
            CbxCurso.DisplayMember = "Materia";
            CbxCurso.ValueMember = "Liga";
        } 




        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarNotas();
        }

        private void CbxAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CN_NOTAS objNota = new CN_NOTAS();
            //dataGridView1.DataSource = objNota.ListarResultado(Convert.ToInt32(CbxAlumnos.SelectedValue));
        }

        private void CbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarNotas();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (dGridView1.SelectedRows.Count > 0)
            {
                gBoxEditar.Visible = true;
                txtTRIuno.Text = dGridView1.CurrentRow.Cells["TrimestreUno"].Value.ToString();
                txtTRIdos.Text = dGridView1.CurrentRow.Cells["TrimestreDos"].Value.ToString();
                txtTRItres.Text = dGridView1.CurrentRow.Cells["TrimestreTres"].Value.ToString();
                lblNombreAlumno.Text= dGridView1.CurrentRow.Cells["Nombre_Alumno"].Value.ToString();
                
                id = dGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");


        }
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio. 
        private void validar(GroupBox formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable. 
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje. 
            else
            {
                try
                {
                    objetoCN.EditarNotas(txtTRIuno.Text, txtTRIdos.Text, txtTRItres.Text, CbxCurso.SelectedValue.ToString(), id);
                    MessageBox.Show("Editado Correctamente");
                    MostrarNotas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar" + ex);
                }
            }
            vacio = false; // Devolvemos el valor original a nuestra variable. 
        }
        private void btnEditarNotas_Click(object sender, EventArgs e)
        {
            validar(gBoxEditar);
            
        }
    }
}
