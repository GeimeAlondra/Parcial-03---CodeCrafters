namespace CapaVista
{
    partial class AgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.productobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.checkEstadoProducto = new System.Windows.Forms.CheckBox();
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.cbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.cbProveedorProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProducto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.productobindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(122, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(94, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(122, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(375, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(116, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(97, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(116, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marca:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productobindingSource, "ProductoDescripcion", true));
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(206, 113);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(353, 68);
            this.txtDescripcionProducto.TabIndex = 9;
            // 
            // productobindingSource
            // 
            this.productobindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtPrecioProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productobindingSource, "ProductoPrecio", true));
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.ForeColor = System.Drawing.Color.White;
            this.txtPrecioProducto.Location = new System.Drawing.Point(206, 205);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(148, 22);
            this.txtPrecioProducto.TabIndex = 10;
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtStockProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productobindingSource, "ProductoStock", true));
            this.txtStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProducto.ForeColor = System.Drawing.Color.White;
            this.txtStockProducto.Location = new System.Drawing.Point(436, 205);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(123, 22);
            this.txtStockProducto.TabIndex = 11;
            // 
            // checkEstadoProducto
            // 
            this.checkEstadoProducto.AutoSize = true;
            this.checkEstadoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.productobindingSource, "Estado", true));
            this.checkEstadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstadoProducto.Location = new System.Drawing.Point(206, 249);
            this.checkEstadoProducto.Name = "checkEstadoProducto";
            this.checkEstadoProducto.Size = new System.Drawing.Size(69, 20);
            this.checkEstadoProducto.TabIndex = 14;
            this.checkEstadoProducto.Text = "Activo";
            this.checkEstadoProducto.UseVisualStyleBackColor = true;
            // 
            // cbCategoriaProducto
            // 
            this.cbCategoriaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbCategoriaProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productobindingSource, "CategoriaId", true));
            this.cbCategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCategoriaProducto.FormattingEnabled = true;
            this.cbCategoriaProducto.Location = new System.Drawing.Point(206, 293);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(180, 24);
            this.cbCategoriaProducto.TabIndex = 15;
            // 
            // cbMarcaProducto
            // 
            this.cbMarcaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbMarcaProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productobindingSource, "MarcaId", true));
            this.cbMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.cbMarcaProducto.FormattingEnabled = true;
            this.cbMarcaProducto.Location = new System.Drawing.Point(206, 352);
            this.cbMarcaProducto.Name = "cbMarcaProducto";
            this.cbMarcaProducto.Size = new System.Drawing.Size(180, 24);
            this.cbMarcaProducto.TabIndex = 16;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productobindingSource, "ProductoNombre", true));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.White;
            this.txtNombreProducto.Location = new System.Drawing.Point(206, 62);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(353, 26);
            this.txtNombreProducto.TabIndex = 36;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAgregarMarca.Location = new System.Drawing.Point(436, 350);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarMarca.TabIndex = 37;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(436, 291);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarCategoria.TabIndex = 38;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(436, 407);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarProveedor.TabIndex = 41;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // cbProveedorProducto
            // 
            this.cbProveedorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbProveedorProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productobindingSource, "ProveedorId", true));
            this.cbProveedorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedorProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.cbProveedorProducto.FormattingEnabled = true;
            this.cbProveedorProducto.Location = new System.Drawing.Point(206, 409);
            this.cbProveedorProducto.Name = "cbProveedorProducto";
            this.cbProveedorProducto.Size = new System.Drawing.Size(180, 24);
            this.cbProveedorProducto.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(86, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Proveedor:";
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
            this.btnRegresar.Location = new System.Drawing.Point(449, 467);
            this.btnRegresar.MaximumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 30);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = " &Cancelar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnGuardarProducto.IconColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarProducto.IconSize = 34;
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(125, 467);
            this.btnGuardarProducto.MaximumSize = new System.Drawing.Size(115, 30);
            this.btnGuardarProducto.MinimumSize = new System.Drawing.Size(115, 30);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(115, 30);
            this.btnGuardarProducto.TabIndex = 17;
            this.btnGuardarProducto.Text = "&Guardar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(715, 509);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.cbProveedorProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.cbMarcaProducto);
            this.Controls.Add(this.cbCategoriaProducto);
            this.Controls.Add(this.checkEstadoProducto);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.productobindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.CheckBox checkEstadoProducto;
        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.ComboBox cbMarcaProducto;
        private FontAwesome.Sharp.IconButton btnGuardarProducto;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.BindingSource productobindingSource;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.ComboBox cbProveedorProducto;
        private System.Windows.Forms.Label label9;
    }
}