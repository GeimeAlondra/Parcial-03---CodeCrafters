﻿namespace CapaVista
{
    partial class MostrarTipoEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarTipoEmpleado));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnActualizarTipoEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoEmpleadoBindingSources = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardarTipoEmpleado = new FontAwesome.Sharp.IconButton();
            this.dvgTipoEmpleado = new System.Windows.Forms.DataGridView();
            this.TipoEmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmpleadoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEmpleadoBindingSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoEmpleadoBindingSources, "Cargo", true));
            this.txtCargo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCargo.Location = new System.Drawing.Point(176, 136);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(229, 20);
            this.txtCargo.TabIndex = 19;
            // 
            // btnActualizarTipoEmpleado
            // 
            this.btnActualizarTipoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.btnActualizarTipoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarTipoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTipoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarTipoEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnActualizarTipoEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnActualizarTipoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarTipoEmpleado.IconSize = 34;
            this.btnActualizarTipoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarTipoEmpleado.Location = new System.Drawing.Point(515, 484);
            this.btnActualizarTipoEmpleado.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarTipoEmpleado.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnActualizarTipoEmpleado.Name = "btnActualizarTipoEmpleado";
            this.btnActualizarTipoEmpleado.Size = new System.Drawing.Size(115, 30);
            this.btnActualizarTipoEmpleado.TabIndex = 21;
            this.btnActualizarTipoEmpleado.Text = "&Actualizar";
            this.btnActualizarTipoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarTipoEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarTipoEmpleado.Visible = false;
            this.btnActualizarTipoEmpleado.Click += new System.EventHandler(this.btnActualizarTipoEmpleado_Click);
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
            this.btnRegresar.Location = new System.Drawing.Point(71, 484);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registro de Tipo de Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(67, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cargo:";
            // 
            // tipoEmpleadoBindingSources
            // 
            this.tipoEmpleadoBindingSources.DataSource = typeof(CapaEntidades.TipoEmpleado);
            // 
            // btnGuardarTipoEmpleado
            // 
            this.btnGuardarTipoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarTipoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGuardarTipoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTipoEmpleado.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnGuardarTipoEmpleado.IconColor = System.Drawing.Color.Black;
            this.btnGuardarTipoEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarTipoEmpleado.IconSize = 38;
            this.btnGuardarTipoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTipoEmpleado.Location = new System.Drawing.Point(520, 484);
            this.btnGuardarTipoEmpleado.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarTipoEmpleado.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarTipoEmpleado.Name = "btnGuardarTipoEmpleado";
            this.btnGuardarTipoEmpleado.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarTipoEmpleado.TabIndex = 25;
            this.btnGuardarTipoEmpleado.Text = "&Guardar";
            this.btnGuardarTipoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTipoEmpleado.UseVisualStyleBackColor = false;
            this.btnGuardarTipoEmpleado.Click += new System.EventHandler(this.btnGuardarTipoEmpleado_Click);
            // 
            // dvgTipoEmpleado
            // 
            this.dvgTipoEmpleado.AllowUserToAddRows = false;
            this.dvgTipoEmpleado.AllowUserToDeleteRows = false;
            this.dvgTipoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgTipoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTipoEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgTipoEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dvgTipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgTipoEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTipoEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgTipoEmpleado.ColumnHeadersHeight = 22;
            this.dvgTipoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgTipoEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEmpleadoId,
            this.TipoEmpleadoCargo,
            this.Editar,
            this.Eliminar});
            this.dvgTipoEmpleado.EnableHeadersVisualStyles = false;
            this.dvgTipoEmpleado.GridColor = System.Drawing.Color.SteelBlue;
            this.dvgTipoEmpleado.Location = new System.Drawing.Point(71, 212);
            this.dvgTipoEmpleado.Name = "dvgTipoEmpleado";
            this.dvgTipoEmpleado.ReadOnly = true;
            this.dvgTipoEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTipoEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgTipoEmpleado.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dvgTipoEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgTipoEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTipoEmpleado.Size = new System.Drawing.Size(559, 220);
            this.dvgTipoEmpleado.TabIndex = 26;
            this.dvgTipoEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTipoEmpleado_CellContentClick);
            // 
            // TipoEmpleadoId
            // 
            this.TipoEmpleadoId.DataPropertyName = "TipoEmpleadoId";
            this.TipoEmpleadoId.HeaderText = "Id";
            this.TipoEmpleadoId.Name = "TipoEmpleadoId";
            this.TipoEmpleadoId.ReadOnly = true;
            // 
            // TipoEmpleadoCargo
            // 
            this.TipoEmpleadoCargo.DataPropertyName = "TipoEmpleadoCargo";
            this.TipoEmpleadoCargo.HeaderText = "Cargo";
            this.TipoEmpleadoCargo.Name = "TipoEmpleadoCargo";
            this.TipoEmpleadoCargo.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // MostrarTipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(705, 561);
            this.Controls.Add(this.dvgTipoEmpleado);
            this.Controls.Add(this.btnActualizarTipoEmpleado);
            this.Controls.Add(this.btnGuardarTipoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label2);
            this.Name = "MostrarTipoEmpleado";
            this.Text = "MostrarTipoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.tipoEmpleadoBindingSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCargo;
        private FontAwesome.Sharp.IconButton btnActualizarTipoEmpleado;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipoEmpleadoBindingSources;
        private FontAwesome.Sharp.IconButton btnGuardarTipoEmpleado;
        private System.Windows.Forms.DataGridView dvgTipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmpleadoCargo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}