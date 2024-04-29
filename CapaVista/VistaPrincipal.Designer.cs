namespace CapaVista
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipal));
            this.MenuSideBar = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnMantenimientoMarcas = new System.Windows.Forms.Button();
            this.btnPanelGeneral = new System.Windows.Forms.Button();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.panelMantenimientos = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.paneLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMantenimientoCat = new FontAwesome.Sharp.IconButton();
            this.MenuSideBar.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelMantenimientos.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSideBar
            // 
            this.MenuSideBar.AutoScroll = true;
            this.MenuSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.MenuSideBar.Controls.Add(this.panelTools);
            this.MenuSideBar.Controls.Add(this.btnPanelGeneral);
            this.MenuSideBar.Controls.Add(this.panelVentas);
            this.MenuSideBar.Controls.Add(this.btnPrueba2);
            this.MenuSideBar.Controls.Add(this.panelMantenimientos);
            this.MenuSideBar.Controls.Add(this.btnPrueba);
            this.MenuSideBar.Controls.Add(this.paneLogo);
            this.MenuSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSideBar.Location = new System.Drawing.Point(0, 0);
            this.MenuSideBar.Name = "MenuSideBar";
            this.MenuSideBar.Size = new System.Drawing.Size(229, 600);
            this.MenuSideBar.TabIndex = 0;
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelTools.Controls.Add(this.btnMantenimientoCat);
            this.panelTools.Controls.Add(this.button5);
            this.panelTools.Controls.Add(this.btnProveedor);
            this.panelTools.Controls.Add(this.btnMantenimientoMarcas);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 551);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(212, 167);
            this.panelTools.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 80);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(212, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Mantenimient";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProveedor.Location = new System.Drawing.Point(0, 40);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedor.Size = new System.Drawing.Size(212, 40);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "Mantenimiento Proveedor";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnMantenimientoMarcas
            // 
            this.btnMantenimientoMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoMarcas.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMantenimientoMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoMarcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantenimientoMarcas.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientoMarcas.Name = "btnMantenimientoMarcas";
            this.btnMantenimientoMarcas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMantenimientoMarcas.Size = new System.Drawing.Size(212, 40);
            this.btnMantenimientoMarcas.TabIndex = 2;
            this.btnMantenimientoMarcas.Text = "Mantenimiento Marcas";
            this.btnMantenimientoMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoMarcas.UseVisualStyleBackColor = true;
            this.btnMantenimientoMarcas.Click += new System.EventHandler(this.btnMantenimientoMarcas_Click);
            // 
            // btnPanelGeneral
            // 
            this.btnPanelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelGeneral.FlatAppearance.BorderSize = 0;
            this.btnPanelGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPanelGeneral.Location = new System.Drawing.Point(0, 506);
            this.btnPanelGeneral.Name = "btnPanelGeneral";
            this.btnPanelGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPanelGeneral.Size = new System.Drawing.Size(212, 45);
            this.btnPanelGeneral.TabIndex = 5;
            this.btnPanelGeneral.Text = "Tools";
            this.btnPanelGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGeneral.UseVisualStyleBackColor = true;
            this.btnPanelGeneral.Click += new System.EventHandler(this.btnPanelGeneral_Click);
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelVentas.Controls.Add(this.button6);
            this.panelVentas.Controls.Add(this.button7);
            this.panelVentas.Controls.Add(this.button8);
            this.panelVentas.Controls.Add(this.button9);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 339);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(212, 167);
            this.panelVentas.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(0, 120);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(212, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(0, 80);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(212, 40);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(0, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(212, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(212, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrueba2.FlatAppearance.BorderSize = 0;
            this.btnPrueba2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrueba2.Location = new System.Drawing.Point(0, 294);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrueba2.Size = new System.Drawing.Size(212, 45);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba2";
            this.btnPrueba2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // panelMantenimientos
            // 
            this.panelMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMantenimientos.Controls.Add(this.button3);
            this.panelMantenimientos.Controls.Add(this.button2);
            this.panelMantenimientos.Controls.Add(this.button1);
            this.panelMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMantenimientos.Location = new System.Drawing.Point(0, 158);
            this.panelMantenimientos.Name = "panelMantenimientos";
            this.panelMantenimientos.Size = new System.Drawing.Size(212, 136);
            this.panelMantenimientos.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.button3.Size = new System.Drawing.Size(212, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.button2.Size = new System.Drawing.Size(212, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insertar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.AutoSize = true;
            this.btnPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrueba.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrueba.FlatAppearance.BorderSize = 0;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnPrueba.Image")));
            this.btnPrueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.Location = new System.Drawing.Point(0, 100);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnPrueba.Size = new System.Drawing.Size(212, 58);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Mantenimiento Productos";
            this.btnPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.pictureBox2);
            this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneLogo.Location = new System.Drawing.Point(0, 0);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(212, 100);
            this.paneLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(211, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContainer.Controls.Add(this.lblDia);
            this.panelContainer.Controls.Add(this.lblHora);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(229, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(721, 600);
            this.panelContainer.TabIndex = 1;
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDia.Location = new System.Drawing.Point(198, 353);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(315, 37);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Domingo abril 2024";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHora.Location = new System.Drawing.Point(227, 262);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(255, 73);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "0:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMantenimientoCat
            // 
            this.btnMantenimientoCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoCat.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoCat.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoCat.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnMantenimientoCat.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoCat.IconSize = 36;
            this.btnMantenimientoCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoCat.Location = new System.Drawing.Point(0, 120);
            this.btnMantenimientoCat.Name = "btnMantenimientoCat";
            this.btnMantenimientoCat.Size = new System.Drawing.Size(212, 40);
            this.btnMantenimientoCat.TabIndex = 5;
            this.btnMantenimientoCat.Text = "Mantenimiento Categorias";
            this.btnMantenimientoCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimientoCat.UseVisualStyleBackColor = true;
            this.btnMantenimientoCat.Click += new System.EventHandler(this.btnMantenimientoCat_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.MenuSideBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuSideBar.ResumeLayout(false);
            this.MenuSideBar.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelMantenimientos.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuSideBar;
        private System.Windows.Forms.Panel panelMantenimientos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.FlowLayoutPanel paneLogo;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnPrueba2;
        private System.Windows.Forms.Button btnPanelGeneral;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnMantenimientoMarcas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDia;
        private FontAwesome.Sharp.IconButton btnMantenimientoCat;
    }
}

