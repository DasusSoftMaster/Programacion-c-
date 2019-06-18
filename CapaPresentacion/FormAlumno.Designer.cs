namespace CapaPresentacion
{
    partial class FormAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumno));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApMater = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApPater = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelef = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirecc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(552, 38);
            this.BarraTitulo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "AGREGAR ALUMNO";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(514, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtNombre.BorderColorIdle = System.Drawing.Color.White;
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(49, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(452, 31);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(285, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "APELLIDO MATERNO";
            // 
            // txtApMater
            // 
            this.txtApMater.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtApMater.BorderColorIdle = System.Drawing.Color.White;
            this.txtApMater.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtApMater.BorderThickness = 3;
            this.txtApMater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApMater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApMater.ForeColor = System.Drawing.Color.White;
            this.txtApMater.isPassword = false;
            this.txtApMater.Location = new System.Drawing.Point(279, 175);
            this.txtApMater.Margin = new System.Windows.Forms.Padding(4);
            this.txtApMater.Name = "txtApMater";
            this.txtApMater.Size = new System.Drawing.Size(222, 31);
            this.txtApMater.TabIndex = 10;
            this.txtApMater.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // txtApPater
            // 
            this.txtApPater.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtApPater.BorderColorIdle = System.Drawing.Color.White;
            this.txtApPater.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtApPater.BorderThickness = 3;
            this.txtApPater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApPater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApPater.ForeColor = System.Drawing.Color.White;
            this.txtApPater.isPassword = false;
            this.txtApPater.Location = new System.Drawing.Point(49, 175);
            this.txtApPater.Margin = new System.Windows.Forms.Padding(4);
            this.txtApPater.Name = "txtApPater";
            this.txtApPater.Size = new System.Drawing.Size(222, 31);
            this.txtApPater.TabIndex = 8;
            this.txtApPater.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "TELEFONO";
            // 
            // txtTelef
            // 
            this.txtTelef.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTelef.BorderColorIdle = System.Drawing.Color.White;
            this.txtTelef.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtTelef.BorderThickness = 3;
            this.txtTelef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTelef.ForeColor = System.Drawing.Color.White;
            this.txtTelef.isPassword = false;
            this.txtTelef.Location = new System.Drawing.Point(279, 256);
            this.txtTelef.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(222, 31);
            this.txtTelef.TabIndex = 14;
            this.txtTelef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "DIRECCION";
            // 
            // txtDirecc
            // 
            this.txtDirecc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtDirecc.BorderColorIdle = System.Drawing.Color.White;
            this.txtDirecc.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.txtDirecc.BorderThickness = 3;
            this.txtDirecc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDirecc.ForeColor = System.Drawing.Color.White;
            this.txtDirecc.isPassword = false;
            this.txtDirecc.Location = new System.Drawing.Point(49, 256);
            this.txtDirecc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(222, 31);
            this.txtDirecc.TabIndex = 12;
            this.txtDirecc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.Black;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(84, 324);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 41);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "CANCELAR";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(295, 324);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 17;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.ActiveBorderThickness = 1;
            this.btnGuardar2.ActiveCornerRadius = 20;
            this.btnGuardar2.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGuardar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar2.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnGuardar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar2.BackgroundImage")));
            this.btnGuardar2.ButtonText = "GUARDAR";
            this.btnGuardar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.ForeColor = System.Drawing.Color.White;
            this.btnGuardar2.IdleBorderThickness = 1;
            this.btnGuardar2.IdleCornerRadius = 20;
            this.btnGuardar2.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar2.IdleForecolor = System.Drawing.Color.Black;
            this.btnGuardar2.IdleLineColor = System.Drawing.Color.White;
            this.btnGuardar2.Location = new System.Drawing.Point(84, 324);
            this.btnGuardar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(181, 41);
            this.btnGuardar2.TabIndex = 18;
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar2.Visible = false;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(552, 402);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDirecc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApMater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApPater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertarAlumno";
            this.Load += new System.EventHandler(this.InsertarAlumno_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtTelef;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtDirecc;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtApMater;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtApPater;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar2;
    }
}