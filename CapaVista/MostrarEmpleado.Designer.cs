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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtSalarioEmpleado = new System.Windows.Forms.TextBox();
            this.txtFechaNacEmpleado = new System.Windows.Forms.TextBox();
            this.cbCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.cbSucursalEmpleado = new System.Windows.Forms.ComboBox();
            this.btnActualizarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registro de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(102, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(339, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(358, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Salario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(18, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(638, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cargo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(622, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sucursal:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(165, 92);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtNombreEmpleado.TabIndex = 25;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtApellidoEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(165, 141);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtApellidoEmpleado.TabIndex = 26;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDireccionEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(414, 92);
            this.txtDireccionEmpleado.Multiline = true;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(179, 82);
            this.txtDireccionEmpleado.TabIndex = 27;
            // 
            // txtSalarioEmpleado
            // 
            this.txtSalarioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalarioEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSalarioEmpleado.Location = new System.Drawing.Point(414, 190);
            this.txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            this.txtSalarioEmpleado.Size = new System.Drawing.Size(179, 20);
            this.txtSalarioEmpleado.TabIndex = 28;
            // 
            // txtFechaNacEmpleado
            // 
            this.txtFechaNacEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtFechaNacEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFechaNacEmpleado.Location = new System.Drawing.Point(153, 190);
            this.txtFechaNacEmpleado.Name = "txtFechaNacEmpleado";
            this.txtFechaNacEmpleado.Size = new System.Drawing.Size(161, 20);
            this.txtFechaNacEmpleado.TabIndex = 30;
            // 
            // cbCargoEmpleado
            // 
            this.cbCargoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCargoEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCargoEmpleado.FormattingEnabled = true;
            this.cbCargoEmpleado.Location = new System.Drawing.Point(688, 88);
            this.cbCargoEmpleado.Name = "cbCargoEmpleado";
            this.cbCargoEmpleado.Size = new System.Drawing.Size(142, 21);
            this.cbCargoEmpleado.TabIndex = 31;
            // 
            // cbSucursalEmpleado
            // 
            this.cbSucursalEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbSucursalEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.cbSucursalEmpleado.FormattingEnabled = true;
            this.cbSucursalEmpleado.Location = new System.Drawing.Point(688, 140);
            this.cbSucursalEmpleado.Name = "cbSucursalEmpleado";
            this.cbSucursalEmpleado.Size = new System.Drawing.Size(142, 21);
            this.cbSucursalEmpleado.TabIndex = 32;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnActualizarEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnActualizarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarEmpleado.IconSize = 34;
            this.btnActualizarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(683, 458);
            this.btnActualizarEmpleado.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarEmpleado.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(115, 30);
            this.btnActualizarEmpleado.TabIndex = 33;
            this.btnActualizarEmpleado.Text = "&Actualizar";
            this.btnActualizarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnRegresar.Location = new System.Drawing.Point(62, 458);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // dvgCliente
            // 
            this.dvgCliente.AllowUserToAddRows = false;
            this.dvgCliente.AllowUserToDeleteRows = false;
            this.dvgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dvgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgCliente.ColumnHeadersHeight = 22;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dvgCliente.EnableHeadersVisualStyles = false;
            this.dvgCliente.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgCliente.Location = new System.Drawing.Point(62, 270);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgCliente.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dvgCliente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCliente.Size = new System.Drawing.Size(736, 157);
            this.dvgCliente.TabIndex = 43;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnGuardarEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarEmpleado.IconSize = 38;
            this.btnGuardarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(688, 458);
            this.btnGuardarEmpleado.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.TabIndex = 44;
            this.btnGuardarEmpleado.Text = "&Guardar";
            this.btnGuardarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEmpleado.UseVisualStyleBackColor = false;
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
            // MostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(862, 524);
            this.Controls.Add(this.dvgCliente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.cbSucursalEmpleado);
            this.Controls.Add(this.cbCargoEmpleado);
            this.Controls.Add(this.txtFechaNacEmpleado);
            this.Controls.Add(this.txtSalarioEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Name = "MostrarEmpleado";
            this.Text = "MostrarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtSalarioEmpleado;
        private System.Windows.Forms.TextBox txtFechaNacEmpleado;
        private System.Windows.Forms.ComboBox cbCargoEmpleado;
        private System.Windows.Forms.ComboBox cbSucursalEmpleado;
        private FontAwesome.Sharp.IconButton btnActualizarEmpleado;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.DataGridView dvgCliente;
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
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
    }
}