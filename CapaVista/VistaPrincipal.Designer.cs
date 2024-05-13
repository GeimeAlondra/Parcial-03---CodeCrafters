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
            this.panelVentas = new System.Windows.Forms.Panel();
            this.panelMantenimientos = new System.Windows.Forms.Panel();
            this.paneLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMantenimientoCargo = new FontAwesome.Sharp.IconButton();
            this.btnMantenimientoMarca = new FontAwesome.Sharp.IconButton();
            this.btnMantenimientoCat = new FontAwesome.Sharp.IconButton();
            this.btnPanelGeneral = new System.Windows.Forms.Button();
            this.btnManetenimientoEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnMantenimientoProveedor = new FontAwesome.Sharp.IconButton();
            this.btnMantenimientoClientes = new FontAwesome.Sharp.IconButton();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.btnMantenimientoProductos = new FontAwesome.Sharp.IconButton();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MenuSideBar.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelMantenimientos.SuspendLayout();
            this.paneLogo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelTools.Controls.Add(this.btnMantenimientoCargo);
            this.panelTools.Controls.Add(this.btnMantenimientoMarca);
            this.panelTools.Controls.Add(this.btnMantenimientoCat);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 445);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(229, 121);
            this.panelTools.TabIndex = 6;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelVentas.Controls.Add(this.iconButton1);
            this.panelVentas.Controls.Add(this.btnManetenimientoEmpleado);
            this.panelVentas.Controls.Add(this.btnMantenimientoProveedor);
            this.panelVentas.Controls.Add(this.btnMantenimientoClientes);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentas.Location = new System.Drawing.Point(0, 235);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(229, 167);
            this.panelVentas.TabIndex = 4;
            // 
            // panelMantenimientos
            // 
            this.panelMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMantenimientos.Controls.Add(this.panel2);
            this.panelMantenimientos.Controls.Add(this.btnMantenimientoProductos);
            this.panelMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMantenimientos.Location = new System.Drawing.Point(0, 149);
            this.panelMantenimientos.Name = "panelMantenimientos";
            this.panelMantenimientos.Size = new System.Drawing.Size(229, 43);
            this.panelMantenimientos.TabIndex = 2;
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.pictureBox2);
            this.paneLogo.Controls.Add(this.panel1);
            this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneLogo.Location = new System.Drawing.Point(0, 0);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(229, 106);
            this.paneLogo.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContainer.Controls.Add(this.lblDia);
            this.panelContainer.Controls.Add(this.lblHora);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(229, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(777, 600);
            this.panelContainer.TabIndex = 1;
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDia.Location = new System.Drawing.Point(226, 353);
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
            this.lblHora.Location = new System.Drawing.Point(255, 262);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(255, 73);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "0:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMantenimientoCargo
            // 
            this.btnMantenimientoCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoCargo.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoCargo.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoCargo.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.btnMantenimientoCargo.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoCargo.IconSize = 36;
            this.btnMantenimientoCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoCargo.Location = new System.Drawing.Point(0, 80);
            this.btnMantenimientoCargo.Name = "btnMantenimientoCargo";
            this.btnMantenimientoCargo.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnMantenimientoCargo.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoCargo.TabIndex = 8;
            this.btnMantenimientoCargo.Text = "Registrar  Cargo";
            this.btnMantenimientoCargo.UseVisualStyleBackColor = true;
            this.btnMantenimientoCargo.Click += new System.EventHandler(this.btnMantenimientoCargo_Click);
            // 
            // btnMantenimientoMarca
            // 
            this.btnMantenimientoMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoMarca.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoMarca.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoMarca.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.btnMantenimientoMarca.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoMarca.IconSize = 36;
            this.btnMantenimientoMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoMarca.Location = new System.Drawing.Point(0, 40);
            this.btnMantenimientoMarca.Name = "btnMantenimientoMarca";
            this.btnMantenimientoMarca.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnMantenimientoMarca.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoMarca.TabIndex = 6;
            this.btnMantenimientoMarca.Text = "Registrar  Marcas";
            this.btnMantenimientoMarca.UseVisualStyleBackColor = true;
            this.btnMantenimientoMarca.Click += new System.EventHandler(this.btnMantenimientoMarca_Click);
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
            this.btnMantenimientoCat.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientoCat.Name = "btnMantenimientoCat";
            this.btnMantenimientoCat.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoCat.TabIndex = 5;
            this.btnMantenimientoCat.Text = "Registrar Categorias";
            this.btnMantenimientoCat.UseVisualStyleBackColor = true;
            this.btnMantenimientoCat.Click += new System.EventHandler(this.btnMantenimientoCat_Click);
            // 
            // btnPanelGeneral
            // 
            this.btnPanelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelGeneral.FlatAppearance.BorderSize = 0;
            this.btnPanelGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnPanelGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPanelGeneral.Image = global::CapaVista.Properties.Resources.catalogar;
            this.btnPanelGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelGeneral.Location = new System.Drawing.Point(0, 402);
            this.btnPanelGeneral.Name = "btnPanelGeneral";
            this.btnPanelGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 50, 0);
            this.btnPanelGeneral.Size = new System.Drawing.Size(229, 43);
            this.btnPanelGeneral.TabIndex = 5;
            this.btnPanelGeneral.Text = "Catalogos";
            this.btnPanelGeneral.UseVisualStyleBackColor = true;
            this.btnPanelGeneral.Click += new System.EventHandler(this.btnPanelGeneral_Click);
            // 
            // btnManetenimientoEmpleado
            // 
            this.btnManetenimientoEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManetenimientoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnManetenimientoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManetenimientoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnManetenimientoEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnManetenimientoEmpleado.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnManetenimientoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManetenimientoEmpleado.IconSize = 35;
            this.btnManetenimientoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManetenimientoEmpleado.Location = new System.Drawing.Point(0, 80);
            this.btnManetenimientoEmpleado.Name = "btnManetenimientoEmpleado";
            this.btnManetenimientoEmpleado.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnManetenimientoEmpleado.Size = new System.Drawing.Size(229, 40);
            this.btnManetenimientoEmpleado.TabIndex = 10;
            this.btnManetenimientoEmpleado.Text = "Registrar Empleado";
            this.btnManetenimientoEmpleado.UseVisualStyleBackColor = true;
            this.btnManetenimientoEmpleado.Click += new System.EventHandler(this.btnManetenimientoEmpleado_Click);
            // 
            // btnMantenimientoProveedor
            // 
            this.btnMantenimientoProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoProveedor.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoProveedor.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.btnMantenimientoProveedor.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoProveedor.IconSize = 36;
            this.btnMantenimientoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoProveedor.Location = new System.Drawing.Point(0, 40);
            this.btnMantenimientoProveedor.Name = "btnMantenimientoProveedor";
            this.btnMantenimientoProveedor.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnMantenimientoProveedor.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoProveedor.TabIndex = 9;
            this.btnMantenimientoProveedor.Text = "Registrar  Proveedor";
            this.btnMantenimientoProveedor.UseVisualStyleBackColor = true;
            this.btnMantenimientoProveedor.Click += new System.EventHandler(this.btnMantenimientoProveedor_Click_1);
            // 
            // btnMantenimientoClientes
            // 
            this.btnMantenimientoClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoClientes.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoClientes.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoClientes.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnMantenimientoClientes.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoClientes.IconSize = 36;
            this.btnMantenimientoClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoClientes.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientoClientes.Name = "btnMantenimientoClientes";
            this.btnMantenimientoClientes.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnMantenimientoClientes.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoClientes.TabIndex = 7;
            this.btnMantenimientoClientes.Text = "Registrar  Cliente";
            this.btnMantenimientoClientes.UseVisualStyleBackColor = true;
            this.btnMantenimientoClientes.Click += new System.EventHandler(this.btnMantenimientoClientes_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrueba2.FlatAppearance.BorderSize = 0;
            this.btnPrueba2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnPrueba2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrueba2.Image = global::CapaVista.Properties.Resources.ventas;
            this.btnPrueba2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba2.Location = new System.Drawing.Point(0, 192);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Padding = new System.Windows.Forms.Padding(10, 0, 75, 0);
            this.btnPrueba2.Size = new System.Drawing.Size(229, 43);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Ventas";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientoProductos.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoProductos.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btnMantenimientoProductos.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMantenimientoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMantenimientoProductos.IconSize = 36;
            this.btnMantenimientoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(0, 0);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(229, 40);
            this.btnMantenimientoProductos.TabIndex = 6;
            this.btnMantenimientoProductos.Text = "Mantenimiento Productos";
            this.btnMantenimientoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.AutoSize = true;
            this.btnPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrueba.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrueba.FlatAppearance.BorderSize = 0;
            this.btnPrueba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnPrueba.Image")));
            this.btnPrueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba.Location = new System.Drawing.Point(0, 106);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Padding = new System.Windows.Forms.Padding(15, 0, 50, 0);
            this.btnPrueba.Size = new System.Drawing.Size(229, 43);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "Productos";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 43);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 2);
            this.panel1.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconButton1.IconColor = System.Drawing.Color.PaleTurquoise;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 120);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.iconButton1.Size = new System.Drawing.Size(229, 40);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Registar Venta";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1006, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.MenuSideBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Tecnologica";
            this.MenuSideBar.ResumeLayout(false);
            this.MenuSideBar.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelMantenimientos.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuSideBar;
        private System.Windows.Forms.Panel panelMantenimientos;
        private System.Windows.Forms.FlowLayoutPanel paneLogo;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Button btnPrueba2;
        private System.Windows.Forms.Button btnPanelGeneral;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDia;
        private FontAwesome.Sharp.IconButton btnMantenimientoCat;
        private FontAwesome.Sharp.IconButton btnMantenimientoMarca;
        private FontAwesome.Sharp.IconButton btnMantenimientoProductos;
        private FontAwesome.Sharp.IconButton btnMantenimientoCargo;
        private FontAwesome.Sharp.IconButton btnMantenimientoClientes;
        private FontAwesome.Sharp.IconButton btnManetenimientoEmpleado;
        private FontAwesome.Sharp.IconButton btnMantenimientoProveedor;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

