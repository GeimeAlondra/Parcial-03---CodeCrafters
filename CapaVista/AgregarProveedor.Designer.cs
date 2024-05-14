namespace CapaVista
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.proveedorbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plinea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.checkEstadoProveedor = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProveedor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDireccionProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorbindingSource, "ProveedorDireccion", true));
            this.txtDireccionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionProveedor.ForeColor = System.Drawing.Color.White;
            this.txtDireccionProveedor.Location = new System.Drawing.Point(149, 246);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(309, 19);
            this.txtDireccionProveedor.TabIndex = 56;
            this.txtDireccionProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionProveedor_KeyPress);
            // 
            // proveedorbindingSource
            // 
            this.proveedorbindingSource.DataSource = typeof(CapaEntidades.Proveedor);
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtCorreoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorbindingSource, "ProveedorCorreo", true));
            this.txtCorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProveedor.ForeColor = System.Drawing.Color.White;
            this.txtCorreoProveedor.Location = new System.Drawing.Point(150, 199);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(309, 19);
            this.txtCorreoProveedor.TabIndex = 55;
            this.txtCorreoProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreoProveedor_Validating);
            this.txtCorreoProveedor.Validated += new System.EventHandler(this.txtCorreoProveedor_Validated);
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtTelefonoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorbindingSource, "ProveedorTelefono", true));
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProveedor.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(148, 292);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(183, 17);
            this.txtTelefonoProveedor.TabIndex = 54;
            this.txtTelefonoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoProveedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(228, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Registro de Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(43, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Telefono:";
            // 
            // plinea
            // 
            this.plinea.BackColor = System.Drawing.Color.AliceBlue;
            this.plinea.Location = new System.Drawing.Point(150, 171);
            this.plinea.Name = "plinea";
            this.plinea.Size = new System.Drawing.Size(311, 2);
            this.plinea.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(148, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 2);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(148, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 2);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(148, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 2);
            this.panel3.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(510, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorbindingSource, "ProveedorNombre", true));
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.ForeColor = System.Drawing.Color.White;
            this.txtNombreProveedor.Location = new System.Drawing.Point(150, 154);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(309, 19);
            this.txtNombreProveedor.TabIndex = 53;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // checkEstadoProveedor
            // 
            this.checkEstadoProveedor.AutoSize = true;
            this.checkEstadoProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.proveedorbindingSource, "Estado", true));
            this.checkEstadoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstadoProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkEstadoProveedor.Location = new System.Drawing.Point(148, 348);
            this.checkEstadoProveedor.Name = "checkEstadoProveedor";
            this.checkEstadoProveedor.Size = new System.Drawing.Size(69, 20);
            this.checkEstadoProveedor.TabIndex = 58;
            this.checkEstadoProveedor.Text = "Activo";
            this.checkEstadoProveedor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(48, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Estado:";
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
            this.btnRegresar.Location = new System.Drawing.Point(439, 494);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 60;
            this.btnRegresar.Text = " &Cancelar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGuardarProveedor.FlatAppearance.BorderSize = 0;
            this.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProveedor.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnGuardarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnGuardarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarProveedor.IconSize = 34;
            this.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(115, 494);
            this.btnGuardarProveedor.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnGuardarProveedor.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(115, 30);
            this.btnGuardarProveedor.TabIndex = 59;
            this.btnGuardarProveedor.Text = "&Guardar";
            this.btnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProveedor.UseVisualStyleBackColor = false;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(705, 561);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.checkEstadoProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plinea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.proveedorbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel plinea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.CheckBox checkEstadoProveedor;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnGuardarProveedor;
        private System.Windows.Forms.BindingSource proveedorbindingSource;
    }
}