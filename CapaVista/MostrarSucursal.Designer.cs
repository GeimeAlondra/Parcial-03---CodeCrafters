namespace CapaVista
{
    partial class MostrarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarSucursal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnActualizarSucursal = new FontAwesome.Sharp.IconButton();
            this.btnGuardarSucursal = new FontAwesome.Sharp.IconButton();
            this.dvgSucursal = new System.Windows.Forms.DataGridView();
            this.SucursalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucursalNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucursalDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.sucursalBindingSources = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSources)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registro de Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(71, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dirección:";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sucursalBindingSources, "SucursalNombre", true));
            this.txtNombreSucursal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreSucursal.Location = new System.Drawing.Point(182, 110);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(276, 20);
            this.txtNombreSucursal.TabIndex = 20;
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDireccionSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sucursalBindingSources, "SucursalDireccion", true));
            this.txtDireccionSucursal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccionSucursal.Location = new System.Drawing.Point(182, 168);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(276, 20);
            this.txtDireccionSucursal.TabIndex = 21;
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
            this.btnRegresar.Location = new System.Drawing.Point(59, 496);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizarSucursal
            // 
            this.btnActualizarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.btnActualizarSucursal.FlatAppearance.BorderSize = 0;
            this.btnActualizarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnActualizarSucursal.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnActualizarSucursal.IconColor = System.Drawing.Color.Black;
            this.btnActualizarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarSucursal.IconSize = 34;
            this.btnActualizarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarSucursal.Location = new System.Drawing.Point(523, 496);
            this.btnActualizarSucursal.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarSucursal.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarSucursal.Name = "btnActualizarSucursal";
            this.btnActualizarSucursal.Size = new System.Drawing.Size(115, 30);
            this.btnActualizarSucursal.TabIndex = 24;
            this.btnActualizarSucursal.Text = "&Actualizar";
            this.btnActualizarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarSucursal.UseVisualStyleBackColor = false;
            this.btnActualizarSucursal.Visible = false;
            this.btnActualizarSucursal.Click += new System.EventHandler(this.btnActualizarSucursal_Click);
            // 
            // btnGuardarSucursal
            // 
            this.btnGuardarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGuardarSucursal.FlatAppearance.BorderSize = 0;
            this.btnGuardarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSucursal.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnGuardarSucursal.IconColor = System.Drawing.Color.Black;
            this.btnGuardarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarSucursal.IconSize = 38;
            this.btnGuardarSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarSucursal.Location = new System.Drawing.Point(528, 496);
            this.btnGuardarSucursal.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarSucursal.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarSucursal.Name = "btnGuardarSucursal";
            this.btnGuardarSucursal.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarSucursal.TabIndex = 26;
            this.btnGuardarSucursal.Text = "&Guardar";
            this.btnGuardarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarSucursal.UseVisualStyleBackColor = false;
            this.btnGuardarSucursal.Click += new System.EventHandler(this.btnGuardarSucursal_Click);
            // 
            // dvgSucursal
            // 
            this.dvgSucursal.AllowUserToAddRows = false;
            this.dvgSucursal.AllowUserToDeleteRows = false;
            this.dvgSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgSucursal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgSucursal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dvgSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgSucursal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSucursal.ColumnHeadersHeight = 22;
            this.dvgSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SucursalId,
            this.SucursalNombre,
            this.SucursalDireccion,
            this.Editar,
            this.Eliminar});
            this.dvgSucursal.EnableHeadersVisualStyles = false;
            this.dvgSucursal.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgSucursal.Location = new System.Drawing.Point(59, 231);
            this.dvgSucursal.Name = "dvgSucursal";
            this.dvgSucursal.ReadOnly = true;
            this.dvgSucursal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSucursal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgSucursal.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dvgSucursal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvgSucursal.Size = new System.Drawing.Size(579, 200);
            this.dvgSucursal.TabIndex = 35;
            this.dvgSucursal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSucursal_CellContentClick);
            // 
            // SucursalId
            // 
            this.SucursalId.DataPropertyName = "SucursalId";
            this.SucursalId.HeaderText = "Id";
            this.SucursalId.Name = "SucursalId";
            this.SucursalId.ReadOnly = true;
            // 
            // SucursalNombre
            // 
            this.SucursalNombre.DataPropertyName = "SucursalNombre";
            this.SucursalNombre.HeaderText = "Nombre";
            this.SucursalNombre.Name = "SucursalNombre";
            this.SucursalNombre.ReadOnly = true;
            // 
            // SucursalDireccion
            // 
            this.SucursalDireccion.DataPropertyName = "SucursalDireccion";
            this.SucursalDireccion.HeaderText = "Direccion";
            this.SucursalDireccion.Name = "SucursalDireccion";
            this.SucursalDireccion.ReadOnly = true;
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
            // sucursalBindingSources
            // 
            this.sucursalBindingSources.DataSource = typeof(CapaEntidades.Sucursal);
            // 
            // MostrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(705, 561);
            this.Controls.Add(this.dvgSucursal);
            this.Controls.Add(this.btnActualizarSucursal);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtDireccionSucursal);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarSucursal);
            this.Name = "MostrarSucursal";
            this.Text = "MostrarSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnActualizarSucursal;
        private System.Windows.Forms.BindingSource sucursalBindingSources;
        private FontAwesome.Sharp.IconButton btnGuardarSucursal;
        private System.Windows.Forms.DataGridView dvgSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalDireccion;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}