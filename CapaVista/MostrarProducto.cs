using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CapaVista
{
    public partial class MostrarProducto : Form
    { 
        int _id = 0;
        //private DataTable dataTable;
        ProductoLOG _ProductoLOG;
        public MostrarProducto()
        {
            InitializeComponent();
            ObtenerCategorias();
            ObtenerMarcas();
            ObtenerProveedores();
            llenarDataGridView();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto(); // Crear una instancia del formulario que deseas mostrar
            agregarProducto.ShowDialog();
            llenarDataGridView();
        }

        private void llenarDataGridView()
        {
            _ProductoLOG = new ProductoLOG();           
            if (checkEstadoActivo.Checked)
            {
                
                dgvProductos.DataSource = _ProductoLOG.ObtenerProductos();

            }
            else if (checkEstadoInactivo.Checked)
            {
                
                dgvProductos.DataSource = _ProductoLOG.ObtenerProductos(true);
            }
            cbCategoriaProducto.SelectedIndex = 0;
            cbMarcaProducto.SelectedIndex = 0;
            cbProveedorProducto.SelectedIndex = 0;
        }

        private void AbrirFormulario2()
        {
            AgregarProducto objAgregarProducto = new AgregarProducto(_id);
            objAgregarProducto.LlenarDataGridViewRequested += (sender, args) => {
                LlenarDataGridView();
            };
            objAgregarProducto.ShowDialog();
        }

        private void LlenarDataGridView()
        {
            throw new NotImplementedException();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                 _id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoId"].Value.ToString());
                //Enviamos los datos al form
                AbrirFormulario2();
                llenarDataGridView();
            }
            else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                _ProductoLOG = new ProductoLOG();
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoId"].Value.ToString());
                int resultado = _ProductoLOG.EliminarProducto(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Producto eliminado con exito", "Tienda | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se logro eliminar el Producto", "Tienda | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvProductos.Columns[e.ColumnIndex].Name == "Categoria") // Reemplaza "Categoria" por el nombre real de la columna de la categoría
                {
                    var categoria = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Categoria; // Reemplaza "Categoria" por el nombre de la clase de la categoría
                    if (categoria != null)
                    {
                        e.Value = categoria.CategoriaNombre;
                    }
                }
                else if (dgvProductos.Columns[e.ColumnIndex].Name == "Marca") // Reemplaza "Marca" por el nombre real de la columna de la marca
                {
                    var marca = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Marca; // Reemplaza "Marca" por el nombre de la clase de la marca
                    if (marca != null)
                    {
                        e.Value = marca.MarcaNombre;
                    }
                }
                else if (dgvProductos.Columns[e.ColumnIndex].Name == "Proveedor")
                {
                    var proveedor = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Proveedor; // Reemplaza "Proveedor" por el nombre de la clase del proveedor
                    if (proveedor != null)
                    {
                        e.Value = proveedor.ProveedorNombre;
                    }
                }
            }
        }

        //Cargando los combobox
        private void ObtenerCategorias()
        {
            _ProductoLOG = new ProductoLOG();
            List<Categoria> categorias = _ProductoLOG.ObtenerCategoria();
            categorias.Insert(0, new Categoria { CategoriaId = 0, CategoriaNombre = "---Seleccionar---" });
            cbCategoriaProducto.DataSource = categorias;
            //productobindingSource.DataSource = categorias;
            cbCategoriaProducto.DisplayMember = "CategoriaNombre"; // Propiedad de la entidad Marca para mostrar en el ComboBox
            cbCategoriaProducto.ValueMember = "CategoriaId";
            cbCategoriaProducto.SelectedIndex = 0;

        }
        private void ObtenerMarcas()
        {
            _ProductoLOG = new ProductoLOG();
            List<Marca> marcas = _ProductoLOG.ObtenerMarca();
            marcas.Insert(0, new Marca { MarcaId = 0, MarcaNombre = "---Seleccionar---" });
            cbMarcaProducto.DataSource = marcas;
            cbMarcaProducto.DisplayMember = "MarcaNombre"; // Propiedad de la entidad Marca para mostrar en el ComboBox
            cbMarcaProducto.ValueMember = "MarcaId";
            cbMarcaProducto.SelectedIndex = 0;
        }

        private void ObtenerProveedores()
        {
            _ProductoLOG = new ProductoLOG();
            List<Proveedor> proveedors = _ProductoLOG.ObtenerProveedor();
            proveedors.Insert(0, new Proveedor { ProveedorId = 0, ProveedorNombre = "---Seleccionar---" });
            cbProveedorProducto.DataSource = proveedors;
            cbProveedorProducto.DisplayMember = "ProveedorNombre";
            cbProveedorProducto.ValueMember = "ProveedorId";
            cbProveedorProducto.SelectedIndex = 0;
        }

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool inactivos = false;
            if (checkEstadoActivo.Checked)
            {
                inactivos = false;
            }
            else if (checkEstadoInactivo.Checked)
            {
                inactivos = true;
            }
            Categoria categoriaSeleccionada = (Categoria)cbCategoriaProducto.SelectedItem;

            if (categoriaSeleccionada != null)
            {
                int valorId = categoriaSeleccionada.CategoriaId;
                
                _ProductoLOG = new ProductoLOG();
                dgvProductos.DataSource = _ProductoLOG.FiltroCategoria(valorId, inactivos);
            }
            else
            {
                MessageBox.Show("Seleccione una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMarcaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool inactivos = false;
            if (checkEstadoActivo.Checked)
            {
                inactivos = false;
            }
            else if (checkEstadoInactivo.Checked)
            {
                inactivos = true;
            }
            Marca MarcaSeleccionada = (Marca)cbMarcaProducto.SelectedItem;

            if (MarcaSeleccionada != null)
            {
                int valorId = MarcaSeleccionada.MarcaId;

                _ProductoLOG = new ProductoLOG();
                dgvProductos.DataSource = _ProductoLOG.FiltroMarca(valorId, inactivos);
            }
            else
            {
                MessageBox.Show("Seleccione una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProveedorProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool inactivos = false;
            if (checkEstadoActivo.Checked)
            {
                inactivos = false;
            }
            else if (checkEstadoInactivo.Checked)
            {
                inactivos = true;
            }
            Proveedor ProveedorSeleccionado = (Proveedor)cbProveedorProducto.SelectedItem;

            if (ProveedorSeleccionado != null)
            {
                int valorId = ProveedorSeleccionado.ProveedorId;

                _ProductoLOG = new ProductoLOG();
                dgvProductos.DataSource = _ProductoLOG.FiltroProveedor(valorId, inactivos);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            FiltroPorNombre();
       
        }

        private void FiltroPorNombre()
        {
            _ProductoLOG = new ProductoLOG();
            string nombre = txtNombreProducto.Text;
            if (checkEstadoActivo.Checked)
            {

                dgvProductos.DataSource = _ProductoLOG.FiltroNombre(nombre);

            }
            else if (checkEstadoInactivo.Checked)
            {

                dgvProductos.DataSource = _ProductoLOG.FiltroNombre(nombre, true);
            }
            cbCategoriaProducto.SelectedIndex = 0;
            cbMarcaProducto.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
