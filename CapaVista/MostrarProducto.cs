using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MostrarProducto : Form
    { 
        int _id = 0;

        ProductoLOG _ProductoLOG;
        public MostrarProducto()
        {
            InitializeComponent();
           
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
            // Código para llenar el DataGridView
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
                    MessageBox.Show("Producto Eliminado con exito", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se logro Eliminar el producto", "Tienda | Registro Productos",
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
    }
}
