namespace CapaVista
{
    partial class AgregarEmpleado
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
            this.empleadobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCargoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtFechaNacEmpleado = new System.Windows.Forms.TextBox();
            this.txtSalarioEmpleado = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkEstadoEmpleado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.empleadobindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadobindingSource
            // 
            this.empleadobindingSource.DataSource = typeof(CapaEntidades.Empleado);
            // 
            // cbCargoEmpleado
            // 
            this.cbCargoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCargoEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadobindingSource, "TipoEmpleadoId", true));
            this.cbCargoEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCargoEmpleado.FormattingEnabled = true;
            this.cbCargoEmpleado.Location = new System.Drawing.Point(263, 378);
            this.cbCargoEmpleado.Name = "cbCargoEmpleado";
            this.cbCargoEmpleado.Size = new System.Drawing.Size(222, 21);
            this.cbCargoEmpleado.TabIndex = 58;
            // 
            // txtFechaNacEmpleado
            // 
            this.txtFechaNacEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtFechaNacEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadobindingSource, "EmpleadoFechaNacimiento", true));
            this.txtFechaNacEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFechaNacEmpleado.Location = new System.Drawing.Point(263, 184);
            this.txtFechaNacEmpleado.Name = "txtFechaNacEmpleado";
            this.txtFechaNacEmpleado.Size = new System.Drawing.Size(222, 20);
            this.txtFechaNacEmpleado.TabIndex = 57;
            // 
            // txtSalarioEmpleado
            // 
            this.txtSalarioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalarioEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadobindingSource, "EmpleadoSalario", true));
            this.txtSalarioEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSalarioEmpleado.Location = new System.Drawing.Point(263, 331);
            this.txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            this.txtSalarioEmpleado.Size = new System.Drawing.Size(222, 20);
            this.txtSalarioEmpleado.TabIndex = 56;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDireccionEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadobindingSource, "EmpleadoDireccion", true));
            this.txtDireccionEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(263, 227);
            this.txtDireccionEmpleado.Multiline = true;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(222, 82);
            this.txtDireccionEmpleado.TabIndex = 55;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtApellidoEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadobindingSource, "EmpleadoApellido", true));
            this.txtApellidoEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(263, 142);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(221, 20);
            this.txtApellidoEmpleado.TabIndex = 54;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadobindingSource, "EmpleadoNombre", true));
            this.txtNombreEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(263, 101);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(221, 20);
            this.txtNombreEmpleado.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(201, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(99, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(193, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Salario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(180, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(188, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(188, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registro de Empleado";
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
            this.btnRegresar.Location = new System.Drawing.Point(449, 458);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 61;
            this.btnRegresar.Text = " &Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
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
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(154, 458);
            this.btnGuardarEmpleado.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarEmpleado.TabIndex = 63;
            this.btnGuardarEmpleado.Text = "&Guardar";
            this.btnGuardarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEmpleado.UseVisualStyleBackColor = false;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAgregarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCargo.Location = new System.Drawing.Point(515, 378);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarCargo.TabIndex = 64;
            this.btnAgregarCargo.Text = "Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = false;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(193, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Estado:";
            // 
            // checkEstadoEmpleado
            // 
            this.checkEstadoEmpleado.AutoSize = true;
            this.checkEstadoEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.empleadobindingSource, "Estado", true));
            this.checkEstadoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstadoEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkEstadoEmpleado.Location = new System.Drawing.Point(267, 421);
            this.checkEstadoEmpleado.Name = "checkEstadoEmpleado";
            this.checkEstadoEmpleado.Size = new System.Drawing.Size(69, 20);
            this.checkEstadoEmpleado.TabIndex = 66;
            this.checkEstadoEmpleado.Text = "Activo";
            this.checkEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(715, 509);
            this.Controls.Add(this.checkEstadoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarCargo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cbCargoEmpleado);
            this.Controls.Add(this.txtFechaNacEmpleado);
            this.Controls.Add(this.txtSalarioEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.empleadobindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.ComboBox cbCargoEmpleado;
        private System.Windows.Forms.TextBox txtFechaNacEmpleado;
        private System.Windows.Forms.TextBox txtSalarioEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.BindingSource empleadobindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkEstadoEmpleado;
    }
}