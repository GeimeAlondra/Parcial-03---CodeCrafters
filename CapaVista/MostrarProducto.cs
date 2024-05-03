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
    { int _id = 0;

        ProductoLOG _ProductoLOG;
        public MostrarProducto()
        {
            InitializeComponent();
            llenarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            _ProductoLOG = new ProductoLOG();

            dgvProductos.DataSource = _ProductoLOG.ObtenerProductos();
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
            
            dgvProductos.DataSource = _ProductoLOG.ObtenerProductos();
            

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["CategoriaId"].Value.ToString());
                //Enviamos los datos al form
                
                AgregarProducto objAgregarProducto = new AgregarProducto(this, _id);

                objAgregarProducto.ShowDialog();



            }

            //if (dvgCategorias.Columns[e.ColumnIndex].Name == "Eliminar")
            //{
            //    _id = Convert.ToInt32(dvgCategorias.CurrentRow.Cells["CategoriaId"].Value.ToString());
            //    EliminarCategoria(_id);
            //}
        }
    }
}
