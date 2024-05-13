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
            this.dvgEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEstadoInactivo = new System.Windows.Forms.RadioButton();
            this.checkEstadoActivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpleadoDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dvgEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dvgEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dvgEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgEmpleado.ColumnHeadersHeight = 22;
            this.dvgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpleadoId,
            this.EmpleadoNombre,
            this.EmpleadoApellido,
            this.EmpleadoDireccion,
            this.TipoEmpleadoId,
            this.TipoEmpleado,
            this.FechaNacimiento,
            this.Editar,
            this.Eliminar,
            this.Salario,
            this.Estado});
            this.dvgEmpleado.EnableHeadersVisualStyles = false;
            this.dvgEmpleado.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgEmpleado.Location = new System.Drawing.Point(64, 192);
            this.dvgEmpleado.Name = "dvgEmpleado";
            this.dvgEmpleado.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgEmpleado.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dvgEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEmpleado.Size = new System.Drawing.Size(594, 280);
            this.dvgEmpleado.TabIndex = 63;
            this.dvgEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmpleado_CellContentClick);
            this.dvgEmpleado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgEmpleado_CellFormatting);
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
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
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
            this.groupBox1.Controls.Add(this.checkEstadoInactivo);
            this.groupBox1.Controls.Add(this.checkEstadoActivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbCargoEmpleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(678, 131);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Empleados";
            // 
            // checkEstadoInactivo
            // 
            this.checkEstadoInactivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEstadoInactivo.AutoSize = true;
            this.checkEstadoInactivo.Location = new System.Drawing.Point(544, 68);
            this.checkEstadoInactivo.Name = "checkEstadoInactivo";
            this.checkEstadoInactivo.Size = new System.Drawing.Size(84, 22);
            this.checkEstadoInactivo.TabIndex = 49;
            this.checkEstadoInactivo.TabStop = true;
            this.checkEstadoInactivo.Text = "Inactivo";
            this.checkEstadoInactivo.UseVisualStyleBackColor = true;
            this.checkEstadoInactivo.CheckedChanged += new System.EventHandler(this.checkEstadoInactivo_CheckedChanged);
            // 
            // checkEstadoActivo
            // 
            this.checkEstadoActivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEstadoActivo.AutoSize = true;
            this.checkEstadoActivo.Checked = true;
            this.checkEstadoActivo.Location = new System.Drawing.Point(544, 40);
            this.checkEstadoActivo.Name = "checkEstadoActivo";
            this.checkEstadoActivo.Size = new System.Drawing.Size(72, 22);
            this.checkEstadoActivo.TabIndex = 48;
            this.checkEstadoActivo.TabStop = true;
            this.checkEstadoActivo.Text = "Activo";
            this.checkEstadoActivo.UseVisualStyleBackColor = true;
            this.checkEstadoActivo.CheckedChanged += new System.EventHandler(this.checkEstadoActivo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(499, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Estado:";
            // 
            // cbCargoEmpleado
            // 
            this.cbCargoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCargoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCargoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCargoEmpleado.ForeColor = System.Drawing.Color.White;
            this.cbCargoEmpleado.FormattingEnabled = true;
            this.cbCargoEmpleado.Location = new System.Drawing.Point(124, 86);
            this.cbCargoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.cbCargoEmpleado.MaximumSize = new System.Drawing.Size(180, 0);
            this.cbCargoEmpleado.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbCargoEmpleado.Name = "cbCargoEmpleado";
            this.cbCargoEmpleado.Size = new System.Drawing.Size(180, 26);
            this.cbCargoEmpleado.TabIndex = 41;
            this.cbCargoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbCargoEmpleado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(63, 91);
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
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
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
            // EmpleadoId
            // 
            this.EmpleadoId.DataPropertyName = "EmpleadoId";
            this.EmpleadoId.HeaderText = "Id";
            this.EmpleadoId.Name = "EmpleadoId";
            this.EmpleadoId.ReadOnly = true;
            this.EmpleadoId.Width = 41;
            // 
            // EmpleadoNombre
            // 
            this.EmpleadoNombre.DataPropertyName = "EmpleadoNombre";
            this.EmpleadoNombre.HeaderText = "Nombre";
            this.EmpleadoNombre.Name = "EmpleadoNombre";
            this.EmpleadoNombre.ReadOnly = true;
            this.EmpleadoNombre.Width = 76;
            // 
            // EmpleadoApellido
            // 
            this.EmpleadoApellido.DataPropertyName = "EmpleadoApellido";
            this.EmpleadoApellido.HeaderText = "Apellido";
            this.EmpleadoApellido.Name = "EmpleadoApellido";
            this.EmpleadoApellido.ReadOnly = true;
            this.EmpleadoApellido.Width = 75;
            // 
            // EmpleadoDireccion
            // 
            this.EmpleadoDireccion.DataPropertyName = "EmpleadoDireccion";
            this.EmpleadoDireccion.HeaderText = "Direccion";
            this.EmpleadoDireccion.Name = "EmpleadoDireccion";
            this.EmpleadoDireccion.ReadOnly = true;
            this.EmpleadoDireccion.Width = 83;
            // 
            // TipoEmpleadoId
            // 
            this.TipoEmpleadoId.DataPropertyName = "TipoEmpleadoId";
            this.TipoEmpleadoId.HeaderText = "Cargo";
            this.TipoEmpleadoId.Name = "TipoEmpleadoId";
            this.TipoEmpleadoId.ReadOnly = true;
            this.TipoEmpleadoId.Visible = false;
            this.TipoEmpleadoId.Width = 64;
            // 
            // TipoEmpleado
            // 
            this.TipoEmpleado.DataPropertyName = "TipoEmpleado";
            this.TipoEmpleado.HeaderText = "Cargo";
            this.TipoEmpleado.Name = "TipoEmpleado";
            this.TipoEmpleado.ReadOnly = true;
            this.TipoEmpleado.Width = 64;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "EmpleadoFechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 131;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 44;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 77;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "EmpleadoSalario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Visible = false;
            this.Salario.Width = 70;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 69;
            // 
            // MostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCargoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton checkEstadoInactivo;
        private System.Windows.Forms.RadioButton checkEstadoActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}