namespace CapaPresentacion
{
    partial class Notas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.CbxCurso = new System.Windows.Forms.ComboBox();
            this.dGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxEditar = new System.Windows.Forms.GroupBox();
            this.btnEditarNotas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtTRItres = new System.Windows.Forms.TextBox();
            this.txtTRIdos = new System.Windows.Forms.TextBox();
            this.txtTRIuno = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView1)).BeginInit();
            this.gBoxEditar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.CbxCurso);
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(487, 121);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(188, 53);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Seleccione Materia";
            // 
            // CbxCurso
            // 
            this.CbxCurso.FormattingEnabled = true;
            this.CbxCurso.Location = new System.Drawing.Point(11, 26);
            this.CbxCurso.Name = "CbxCurso";
            this.CbxCurso.Size = new System.Drawing.Size(162, 21);
            this.CbxCurso.TabIndex = 0;
            this.CbxCurso.Text = "Seleccione";
            this.CbxCurso.SelectedIndexChanged += new System.EventHandler(this.CbxCurso_SelectedIndexChanged);
            // 
            // dGridView1
            // 
            this.dGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridView1.EnableHeadersVisualStyles = false;
            this.dGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dGridView1.Location = new System.Drawing.Point(34, 60);
            this.dGridView1.Name = "dGridView1";
            this.dGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView1.Size = new System.Drawing.Size(432, 321);
            this.dGridView1.TabIndex = 15;
            // 
            // gBoxEditar
            // 
            this.gBoxEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxEditar.Controls.Add(this.btnEditarNotas);
            this.gBoxEditar.Controls.Add(this.label5);
            this.gBoxEditar.Controls.Add(this.label4);
            this.gBoxEditar.Controls.Add(this.label3);
            this.gBoxEditar.Controls.Add(this.lblNombreAlumno);
            this.gBoxEditar.Controls.Add(this.txtTRItres);
            this.gBoxEditar.Controls.Add(this.txtTRIdos);
            this.gBoxEditar.Controls.Add(this.txtTRIuno);
            this.gBoxEditar.ForeColor = System.Drawing.Color.White;
            this.gBoxEditar.Location = new System.Drawing.Point(487, 180);
            this.gBoxEditar.Name = "gBoxEditar";
            this.gBoxEditar.Size = new System.Drawing.Size(189, 201);
            this.gBoxEditar.TabIndex = 4;
            this.gBoxEditar.TabStop = false;
            this.gBoxEditar.Text = "Ingrese";
            // 
            // btnEditarNotas
            // 
            this.btnEditarNotas.ForeColor = System.Drawing.Color.Black;
            this.btnEditarNotas.Location = new System.Drawing.Point(53, 168);
            this.btnEditarNotas.Name = "btnEditarNotas";
            this.btnEditarNotas.Size = new System.Drawing.Size(75, 23);
            this.btnEditarNotas.TabIndex = 18;
            this.btnEditarNotas.Text = "OK";
            this.btnEditarNotas.UseVisualStyleBackColor = true;
            this.btnEditarNotas.Click += new System.EventHandler(this.btnEditarNotas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trimestre 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Trimestre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trimestre 1";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(17, 32);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAlumno.TabIndex = 14;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // txtTRItres
            // 
            this.txtTRItres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRItres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTRItres.Location = new System.Drawing.Point(96, 129);
            this.txtTRItres.Name = "txtTRItres";
            this.txtTRItres.Size = new System.Drawing.Size(46, 20);
            this.txtTRItres.TabIndex = 13;
            this.txtTRItres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTRIdos
            // 
            this.txtTRIdos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRIdos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTRIdos.Location = new System.Drawing.Point(96, 95);
            this.txtTRIdos.Name = "txtTRIdos";
            this.txtTRIdos.Size = new System.Drawing.Size(46, 20);
            this.txtTRIdos.TabIndex = 12;
            this.txtTRIdos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTRIuno
            // 
            this.txtTRIuno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRIuno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTRIuno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRIuno.Location = new System.Drawing.Point(96, 61);
            this.txtTRIuno.Name = "txtTRIuno";
            this.txtTRIuno.Size = new System.Drawing.Size(46, 22);
            this.txtTRIuno.TabIndex = 11;
            this.txtTRIuno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(486, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Editar Calificacion";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(40, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Notas";
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(686, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gBoxEditar);
            this.Controls.Add(this.dGridView1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas";
            this.Text = "NOTAS";
            this.Load += new System.EventHandler(this.NOTAS_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridView1)).EndInit();
            this.gBoxEditar.ResumeLayout(false);
            this.gBoxEditar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox CbxCurso;
        public System.Windows.Forms.DataGridView dGridView1;
        internal System.Windows.Forms.GroupBox gBoxEditar;
        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox txtTRItres;
        internal System.Windows.Forms.TextBox txtTRIdos;
        internal System.Windows.Forms.TextBox txtTRIuno;
        private System.Windows.Forms.Button btnEditarNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreAlumno;
    }
}