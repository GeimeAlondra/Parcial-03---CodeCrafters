using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class AgregarProducto : Form
    {
        ProductoLOG _ProductoLOG;
        int _id = 0;
        
        public AgregarProducto(int id = 0)
        {
            InitializeComponent();
            

            _id = id;
            if (_id > 0)
            {
                this.Text = "Tienda|Edicion de Productos";
                //Cambiar el boton
                btnGuardarProducto.Text = "Actualizar";
                btnGuardarProducto.BackColor = Color.FromArgb(82, 190, 128);
                //
                ObtenerMarcas();
                ObtenerCategorias();
                CargarElementos(_id);
            }
            else
            {
                productobindingSource.MoveLast();
                productobindingSource.AddNew();

                ObtenerMarcas();
                ObtenerCategorias();
            }

            
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarElementos(int id)
        {
            _ProductoLOG = new ProductoLOG();
            productobindingSource.DataSource = _ProductoLOG.ObtenerProductoPorId(_id);

        }

        private void ObtenerMarcas()
        {


            _ProductoLOG = new ProductoLOG();
            List<Marca> marcas = _ProductoLOG.ObtenerMarca();
            marcas.Insert(0, new Marca { MarcaId = 0, MarcaNombre = "===Seleccionar===" });
            cbMarcaProducto.DataSource = marcas;
            cbMarcaProducto.DisplayMember = "MarcaNombre"; // Propiedad de la entidad Marca para mostrar en el ComboBox
            cbMarcaProducto.ValueMember = "MarcaId";
            cbMarcaProducto.SelectedIndex = 0;

        }


        private void ObtenerCategorias()
        {
            _ProductoLOG = new ProductoLOG();
            List<Categoria> categorias = _ProductoLOG.ObtenerCategoria();           
            categorias.Insert(0, new Categoria { CategoriaId = 0, CategoriaNombre = "===Seleccionar===" });
            cbCategoriaProducto.DataSource = categorias;
            //productobindingSource.DataSource = categorias;
            cbCategoriaProducto.DisplayMember = "CategoriaNombre"; // Propiedad de la entidad Marca para mostrar en el ComboBox
            cbCategoriaProducto.ValueMember = "CategoriaId";
            cbCategoriaProducto.SelectedIndex = 0;

        }


    private void GuardarProducto()
        {
            _ProductoLOG = new ProductoLOG();
            try
            {

                if (!ValidarCampos())
                {
                    return; // Si los campos no son válidos, salir del método
                }
                int resultado;
                //debemo indicar si es una actualizacion o es un nuevo producto
                if (_id > 0)
                {
                    productobindingSource.EndEdit();
                    Producto producto;
                    producto = (Producto)productobindingSource.Current;
                    resultado = _ProductoLOG.ActualizarProducto(producto, _id, true);
                    if (resultado > 0)
                    {
                        txtNombreProducto.Clear();
                        txtDescripcionProducto.Clear();
                        txtPrecioProducto.Clear();
                        txtStockProducto.Clear();
                        cbCategoriaProducto.SelectedItem = null;
                        cbMarcaProducto.SelectedItem = null;
                        MessageBox.Show("Producto Actualizado con exito", "Tienda | Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
          
                        this.Close();
                        


                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Producto", "Tienda | Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEstadoProducto.Checked)
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el producto inactivo", "Tienda | Registro Productos",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    productobindingSource.EndEdit();

                    Producto producto;
                    producto = (Producto)productobindingSource.Current;

                    resultado = _ProductoLOG.GuardarProducto(producto);

                    if (resultado > 0)
                    {
                        txtNombreProducto.Clear();
                        txtDescripcionProducto.Clear();
                        txtPrecioProducto.Clear();
                        txtStockProducto.Clear();
                        cbCategoriaProducto.SelectedItem = null;
                        cbMarcaProducto.SelectedItem = null;
                        MessageBox.Show("Producto agregado con exito", "Tienda | Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el producto", "Tienda | Registro producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "Tienda | Registro Productos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                MessageBox.Show("Se requiere el nombre del Producto \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                MessageBox.Show("Se requiere la descripción del Producto \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcionProducto.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtPrecioProducto.Text))
            {
                MessageBox.Show("Se requiere el precio del Producto \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioProducto.Focus();
                camposValidos = false;
            }

            // Validación del ComboBox
            if (cbCategoriaProducto.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar una categoría válida.", "Tienda | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoriaProducto.Focus();
                camposValidos = false;
            }

            
            if (cbMarcaProducto.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar una marca válida.", "Tienda | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMarcaProducto.Focus();
                camposValidos = false;
            }

            return camposValidos;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }
    }
}
