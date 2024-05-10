namespace CapaVista
{
    partial class MostrarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarEmpleado));
            this.dvgEmpleado = new System.Windows.Forms.DataGridView();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSucursalEmpleado = new System.Windows.Forms.ComboBox();
            this.cbCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgEmpleado
            // 
            this.dvgEmpleado.AllowUserToAddRows = false;
            this.dvgEmpleado.AllowUserToDeleteRows = false;
            this.dvgEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dvgEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgEmpleado.ColumnHeadersHeight = 22;
            this.dvgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.ClienteProveedor,
            this.ApellidoCliente,
            this.ClienteDireccion,
            this.EmpleadoSalario,
            this.EmpleadoFechaNac,
            this.EmpleadoCargo,
            this.EmpleadoSucursal,
            this.Editar,
            this.Eliminar});
            this.dvgEmpleado.EnableHeadersVisualStyles = false;
            this.dvgEmpleado.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgEmpleado.Location = new System.Drawing.Point(21, 185);
            this.dvgEmpleado.Name = "dvgEmpleado";
            this.dvgEmpleado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEmpleado.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dvgEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEmpleado.Size = new System.Drawing.Size(678, 284);
            this.dvgEmpleado.TabIndex = 63;
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "Id";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            // 
            // ClienteProveedor
            // 
            this.ClienteProveedor.DataPropertyName = "ClienteNombre";
            this.ClienteProveedor.HeaderText = "Nombre";
            this.ClienteProveedor.Name = "ClienteProveedor";
            this.ClienteProveedor.ReadOnly = true;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            // 
            // ClienteDireccion
            // 
            this.ClienteDireccion.DataPropertyName = "ClienteDireccion";
            this.ClienteDireccion.HeaderText = "Direccion";
            this.ClienteDireccion.Name = "ClienteDireccion";
            this.ClienteDireccion.ReadOnly = true;
            // 
            // EmpleadoSalario
            // 
            this.EmpleadoSalario.DataPropertyName = "EmpleadoSalario";
            this.EmpleadoSalario.HeaderText = "Salario";
            this.EmpleadoSalario.Name = "EmpleadoSalario";
            this.EmpleadoSalario.ReadOnly = true;
            // 
            // EmpleadoFechaNac
            // 
            this.EmpleadoFechaNac.DataPropertyName = "EmpleadoFechaNac";
            this.EmpleadoFechaNac.HeaderText = "Telefono";
            this.EmpleadoFechaNac.Name = "EmpleadoFechaNac";
            this.EmpleadoFechaNac.ReadOnly = true;
            // 
            // EmpleadoCargo
            // 
            this.EmpleadoCargo.HeaderText = "Cargo";
            this.EmpleadoCargo.Name = "EmpleadoCargo";
            this.EmpleadoCargo.ReadOnly = true;
            // 
            // EmpleadoSucursal
            // 
            this.EmpleadoSucursal.HeaderText = "Sucursal";
            this.EmpleadoSucursal.Name = "EmpleadoSucursal";
            this.EmpleadoSucursal.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 75;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 76;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnAgregarEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEmpleado.IconSize = 34;
            this.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(21, 496);
            this.btnAgregarEmpleado.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnAgregarEmpleado.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(115, 30);
            this.btnAgregarEmpleado.TabIndex = 64;
            this.btnAgregarEmpleado.Text = "&Agregar";
            this.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.Silver;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnRegresar.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresar.IconSize = 34;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(589, 496);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 65;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSucursalEmpleado);
            this.groupBox1.Controls.Add(this.cbCargoEmpleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(678, 126);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Empleados";
            // 
            // cbSucursalEmpleado
            // 
            this.cbSucursalEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSucursalEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbSucursalEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSucursalEmpleado.ForeColor = System.Drawing.Color.White;
            this.cbSucursalEmpleado.FormattingEnabled = true;
            this.cbSucursalEmpleado.Location = new System.Drawing.Point(445, 40);
            this.cbSucursalEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.cbSucursalEmpleado.MaximumSize = new System.Drawing.Size(180, 0);
            this.cbSucursalEmpleado.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbSucursalEmpleado.Name = "cbSucursalEmpleado";
            this.cbSucursalEmpleado.Size = new System.Drawing.Size(180, 26);
            this.cbSucursalEmpleado.TabIndex = 39;
            // 
            // cbCargoEmpleado
            // 
            this.cbCargoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCargoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCargoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCargoEmpleado.ForeColor = System.Drawing.Color.White;
            this.cbCargoEmpleado.FormattingEnabled = true;
            this.cbCargoEmpleado.Location = new System.Drawing.Point(124, 80);
            this.cbCargoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.cbCargoEmpleado.MaximumSize = new System.Drawing.Size(180, 0);
            this.cbCargoEmpleado.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbCargoEmpleado.Name = "cbCargoEmpleado";
            this.cbCargoEmpleado.Size = new System.Drawing.Size(180, 26);
            this.cbCargoEmpleado.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(65, 88);
            this.label7.MaximumSize = new System.Drawing.Size(79, 16);
            this.label7.MinimumSize = new System.Drawing.Size(79, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cargo:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(124, 40);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(180, 26);
            this.txtNombreEmpleado.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(363, 45);
            this.label1.MaximumSize = new System.Drawing.Size(79, 16);
            this.label1.MinimumSize = new System.Drawing.Size(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sucursal:";
            // 
            // MostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(722, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dvgEmpleado);
            this.Name = "MostrarEmpleado";
            this.Text = "MostrarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoSucursal;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSucursalEmpleado;
        private System.Windows.Forms.ComboBox cbCargoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label2;
    }
}