namespace CapaVista
{
    partial class MostrarProducto
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
            this.dvgProductos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkEstadoActivo = new System.Windows.Forms.CheckBox();
            this.checkEstadoInactivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgProductos
            // 
            this.dvgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductos.Location = new System.Drawing.Point(41, 182);
            this.dvgProductos.Name = "dvgProductos";
            this.dvgProductos.Size = new System.Drawing.Size(724, 236);
            this.dvgProductos.TabIndex = 30;
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
            this.btnRegresar.Location = new System.Drawing.Point(655, 440);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(190)))), ((int)(((byte)(128)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnActualizar.IconColor = System.Drawing.Color.Black;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 34;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(41, 440);
            this.btnActualizar.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnActualizar.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 30);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "&Agregar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEstadoInactivo);
            this.groupBox1.Controls.Add(this.checkEstadoActivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbCategoriaProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMarcaProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 136);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.White;
            this.txtNombreProducto.Location = new System.Drawing.Point(129, 30);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(180, 26);
            this.txtNombreProducto.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(58, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Marca:";
            // 
            // cbMarcaProducto
            // 
            this.cbMarcaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbMarcaProducto.FormattingEnabled = true;
            this.cbMarcaProducto.Location = new System.Drawing.Point(129, 84);
            this.cbMarcaProducto.Name = "cbMarcaProducto";
            this.cbMarcaProducto.Size = new System.Drawing.Size(180, 24);
            this.cbMarcaProducto.TabIndex = 39;
            // 
            // cbCategoriaProducto
            // 
            this.cbCategoriaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCategoriaProducto.FormattingEnabled = true;
            this.cbCategoriaProducto.Location = new System.Drawing.Point(458, 32);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(180, 24);
            this.cbCategoriaProducto.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(349, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(368, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Estado:";
            // 
            // checkEstadoActivo
            // 
            this.checkEstadoActivo.AutoSize = true;
            this.checkEstadoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstadoActivo.Location = new System.Drawing.Point(458, 88);
            this.checkEstadoActivo.Name = "checkEstadoActivo";
            this.checkEstadoActivo.Size = new System.Drawing.Size(62, 17);
            this.checkEstadoActivo.TabIndex = 43;
            this.checkEstadoActivo.Text = "Activo";
            this.checkEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // checkEstadoInactivo
            // 
            this.checkEstadoInactivo.AutoSize = true;
            this.checkEstadoInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstadoInactivo.Location = new System.Drawing.Point(535, 88);
            this.checkEstadoInactivo.Name = "checkEstadoInactivo";
            this.checkEstadoInactivo.Size = new System.Drawing.Size(72, 17);
            this.checkEstadoInactivo.TabIndex = 44;
            this.checkEstadoInactivo.Text = "Inactivo";
            this.checkEstadoInactivo.UseVisualStyleBackColor = true;
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dvgProductos);
            this.Name = "MostrarProducto";
            this.Text = "MostrarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProductos;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMarcaProducto;
        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkEstadoInactivo;
        private System.Windows.Forms.CheckBox checkEstadoActivo;
    }
}