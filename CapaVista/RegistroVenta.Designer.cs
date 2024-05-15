namespace CapaVista
{
    partial class RegistroVenta
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxNombreProd = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lineaCantidad = new System.Windows.Forms.Panel();
            this.plinea = new System.Windows.Forms.Panel();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcesar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.clientebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadobindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "VentaTotal", true));
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(630, 448);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(116, 19);
            this.txtMonto.TabIndex = 25;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(CapaEntidades.Venta);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, 451);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Monto Total:";
            // 
            // txtExistencias
            // 
            this.txtExistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoStock", true));
            this.txtExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.ForeColor = System.Drawing.Color.White;
            this.txtExistencias.Location = new System.Drawing.Point(137, 92);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.ReadOnly = true;
            this.txtExistencias.Size = new System.Drawing.Size(116, 17);
            this.txtExistencias.TabIndex = 21;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(362, 37);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 17);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // cbxNombreProd
            // 
            this.cbxNombreProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNombreProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNombreProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbxNombreProd.DataSource = this.productoBindingSource;
            this.cbxNombreProd.DisplayMember = "ProductoNombre";
            this.cbxNombreProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNombreProd.ForeColor = System.Drawing.Color.White;
            this.cbxNombreProd.FormattingEnabled = true;
            this.cbxNombreProd.Location = new System.Drawing.Point(140, 143);
            this.cbxNombreProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxNombreProd.Name = "cbxNombreProd";
            this.cbxNombreProd.Size = new System.Drawing.Size(363, 26);
            this.cbxNombreProd.TabIndex = 19;
            this.cbxNombreProd.ValueMember = "ProductoId";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoId", true));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(137, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 17);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Existencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.lineaCantidad);
            this.groupBox1.Controls.Add(this.plinea);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtExistencias);
            this.groupBox1.Controls.Add(this.cbxNombreProd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 200);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Ventas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Location = new System.Drawing.Point(137, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 2);
            this.panel2.TabIndex = 34;
            // 
            // lineaCantidad
            // 
            this.lineaCantidad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lineaCantidad.Location = new System.Drawing.Point(362, 54);
            this.lineaCantidad.Name = "lineaCantidad";
            this.lineaCantidad.Size = new System.Drawing.Size(116, 2);
            this.lineaCantidad.TabIndex = 33;
            // 
            // plinea
            // 
            this.plinea.BackColor = System.Drawing.Color.LightSkyBlue;
            this.plinea.Location = new System.Drawing.Point(137, 54);
            this.plinea.Name = "plinea";
            this.plinea.Size = new System.Drawing.Size(116, 2);
            this.plinea.TabIndex = 32;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 34;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(589, 143);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnAgregar.Size = new System.Drawing.Size(115, 26);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(11, 238);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(737, 170);
            this.dgvDetalleVenta.TabIndex = 29;
            this.dgvDetalleVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Turquoise;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnProcesar.IconColor = System.Drawing.Color.Black;
            this.btnProcesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProcesar.IconSize = 34;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(24, 507);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(115, 30);
            this.btnProcesar.TabIndex = 32;
            this.btnProcesar.Text = "&Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Firebrick;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 34;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(654, 507);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(94, 30);
            this.iconButton1.TabIndex = 33;
            this.iconButton1.Text = "&Volver";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Location = new System.Drawing.Point(630, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 2);
            this.panel3.TabIndex = 35;
            // 
            // cbxCliente
            // 
            this.cbxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbxCliente.DataSource = this.clientebindingSource;
            this.cbxCliente.DisplayMember = "ClienteNombre";
            this.cbxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.ForeColor = System.Drawing.Color.White;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(103, 423);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(241, 26);
            this.cbxCliente.TabIndex = 38;
            this.cbxCliente.ValueMember = "ProductoId";
            this.cbxCliente.Enter += new System.EventHandler(this.cbxCliente_Enter);
            // 
            // clientebindingSource
            // 
            this.clientebindingSource.DataSource = typeof(CapaEntidades.Cliente);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cliente:";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbxEmpleado.DataSource = this.empleadobindingSource;
            this.cbxEmpleado.DisplayMember = "EmpleadoNombre";
            this.cbxEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpleado.ForeColor = System.Drawing.Color.White;
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(103, 463);
            this.cbxEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(241, 26);
            this.cbxEmpleado.TabIndex = 40;
            this.cbxEmpleado.ValueMember = "ProductoId";
            this.cbxEmpleado.Enter += new System.EventHandler(this.cbxEmpleado_Enter);
            // 
            // empleadobindingSource
            // 
            this.empleadobindingSource.DataSource = typeof(CapaEntidades.Empleado);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Empleado:";
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(761, 561);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(777, 600);
            this.Name = "RegistroVenta";
            this.Text = "RegistroVenta";
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadobindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxNombreProd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnProcesar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel plinea;
        private System.Windows.Forms.Panel lineaCantidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource clientebindingSource;
        private System.Windows.Forms.BindingSource empleadobindingSource;
    }
}