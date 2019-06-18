namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.alumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalificaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.logo);
            this.sidemenu.Controls.Add(this.alumnos);
            this.sidemenu.Controls.Add(this.btnCalificaciones);
            this.sidemenu.Controls.Add(this.bunifuFlatButton4);
            this.sidemenu.Controls.Add(this.bunifuFlatButton3);
            this.sidemenu.Controls.Add(this.btnInicio);
            this.sidemenu.Controls.Add(this.btnMenu);
            this.logoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 0);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(236, 477);
            this.sidemenu.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 50);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 135);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // alumnos
            // 
            this.alumnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.alumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alumnos.BorderRadius = 0;
            this.alumnos.ButtonText = "      Alumnos";
            this.alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.alumnos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.alumnos, BunifuAnimatorNS.DecorationType.None);
            this.alumnos.DisabledColor = System.Drawing.Color.Gray;
            this.alumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnos.Iconcolor = System.Drawing.Color.Transparent;
            this.alumnos.Iconimage = ((System.Drawing.Image)(resources.GetObject("alumnos.Iconimage")));
            this.alumnos.Iconimage_right = null;
            this.alumnos.Iconimage_right_Selected = null;
            this.alumnos.Iconimage_Selected = null;
            this.alumnos.IconMarginLeft = 0;
            this.alumnos.IconMarginRight = 0;
            this.alumnos.IconRightVisible = true;
            this.alumnos.IconRightZoom = 0D;
            this.alumnos.IconVisible = true;
            this.alumnos.IconZoom = 90D;
            this.alumnos.IsTab = true;
            this.alumnos.Location = new System.Drawing.Point(-1, 258);
            this.alumnos.Name = "alumnos";
            this.alumnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.alumnos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.alumnos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.alumnos.selected = false;
            this.alumnos.Size = new System.Drawing.Size(303, 48);
            this.alumnos.TabIndex = 14;
            this.alumnos.Text = "      Alumnos";
            this.alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alumnos.Textcolor = System.Drawing.Color.White;
            this.alumnos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnos.Click += new System.EventHandler(this.alumnos_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalificaciones.BorderRadius = 0;
            this.btnCalificaciones.ButtonText = "      Calificaciones";
            this.btnCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnCalificaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalificaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalificaciones.Iconimage")));
            this.btnCalificaciones.Iconimage_right = null;
            this.btnCalificaciones.Iconimage_right_Selected = null;
            this.btnCalificaciones.Iconimage_Selected = null;
            this.btnCalificaciones.IconMarginLeft = 0;
            this.btnCalificaciones.IconMarginRight = 0;
            this.btnCalificaciones.IconRightVisible = true;
            this.btnCalificaciones.IconRightZoom = 0D;
            this.btnCalificaciones.IconVisible = true;
            this.btnCalificaciones.IconZoom = 90D;
            this.btnCalificaciones.IsTab = true;
            this.btnCalificaciones.Location = new System.Drawing.Point(0, 420);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalificaciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalificaciones.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCalificaciones.selected = false;
            this.btnCalificaciones.Size = new System.Drawing.Size(303, 48);
            this.btnCalificaciones.TabIndex = 13;
            this.btnCalificaciones.Text = "      Calificaciones";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.Textcolor = System.Drawing.Color.White;
            this.btnCalificaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "      Grupos";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 366);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(303, 48);
            this.bunifuFlatButton4.TabIndex = 12;
            this.bunifuFlatButton4.Text = "      Grupos";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "      Materias";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 312);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(303, 48);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "      Materias";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoAnimator.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInicio.Iconimage")));
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = true;
            this.btnInicio.Location = new System.Drawing.Point(0, 204);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnInicio.selected = true;
            this.btnInicio.Size = new System.Drawing.Size(303, 48);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(196, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelContenedor);
            this.panel2.Controls.Add(this.panel3);
            this.logoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 477);
            this.panel2.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.logoAnimator.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 32);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(749, 445);
            this.PanelContenedor.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.iconrestaurar);
            this.panel3.Controls.Add(this.iconMinimizar);
            this.panel3.Controls.Add(this.iconmaximizar);
            this.panel3.Controls.Add(this.iconCerrar);
            this.logoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 32);
            this.panel3.TabIndex = 0;
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.iconrestaurar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.iconrestaurar, BunifuAnimatorNS.DecorationType.None);
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(696, 7);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(15, 15);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 10;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.iconMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.iconMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
            this.iconMinimizar.Location = new System.Drawing.Point(670, 7);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(15, 15);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 11;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.iconmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.iconmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(696, 7);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(15, 15);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 9;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.iconCerrar, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.iconCerrar, BunifuAnimatorNS.DecorationType.None);
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(722, 7);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(15, 15);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 8;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidemenu);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton alumnos;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalificaciones;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}