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
    public partial class MostrarCliente : Form
    {
        ClienteLOG _ClienteLOG;
        int _id = 0;

        public MostrarCliente()
        {
            InitializeComponent();

            //clientebindingSource.MoveLast();
            //clientebindingSource.AddNew();
            CargarClienteEnDataGridView();
            llenarDataGridView();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarDataGridView()
        {
            _ClienteLOG = new ClienteLOG();
            if (checkEstadoActivo.Checked)
            {
                dvgCliente.DataSource = _ClienteLOG.ObtenerCliente();
            }
            else if (checkEstadoInactivo.Checked)
            {
                dvgCliente.DataSource = _ClienteLOG.ObtenerCliente(true);
            }
        }

        private void AbrirFormulario2()
        {
            AgregarCliente objAgregarCliente = new AgregarCliente(_id);
            objAgregarCliente.LlenarDataGridViewRequested += (sender, args) => {
                LlenarDataGridView();
            };
            objAgregarCliente.ShowDialog();
        }

        private void LlenarDataGridView()
        {
            llenarDataGridView();
            
        }

        private void CargarClienteEnDataGridView()
        {
            _ClienteLOG = new ClienteLOG();
            dvgCliente.DataSource = _ClienteLOG.ObtenerCliente();
        }

        private void dvgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgCliente.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dvgCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                //Enviamos los datos al form
                AbrirFormulario2();
                llenarDataGridView();
            }
            else if (dvgCliente.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                _ClienteLOG = new ClienteLOG();
                int id = Convert.ToInt32(dvgCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                int resultado = _ClienteLOG.EliminarCliente(id);
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            _id = 0;
            AbrirFormulario2();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            FiltroPorNombre();
        }

        private void FiltroPorNombre()
        {
            _ClienteLOG = new ClienteLOG();
            string nombre = txtNombreCliente.Text;
            if (checkEstadoActivo.Checked)
            {

                dvgCliente.DataSource = _ClienteLOG.FiltroNombre(nombre);

            }
            else if (checkEstadoInactivo.Checked)
            {

                dvgCliente.DataSource = _ClienteLOG.FiltroNombre(nombre, true);
            }
        }

        private void checkEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void checkEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
