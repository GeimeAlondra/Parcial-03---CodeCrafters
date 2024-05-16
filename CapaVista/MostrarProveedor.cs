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
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MostrarProveedor : Form
    {
        ProveedorLOG _ProveedorLOG;
        int _id = 0;

        public MostrarProveedor()
        {
            InitializeComponent();
            llenarDataGridView();
            CargarProveedorEnDataGridView();
        }

        private void llenarDataGridView()
        {
            _ProveedorLOG = new ProveedorLOG();

            if (checkEstadoActivo.Checked)
            {
                dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
                dgvProveedor.Columns["Eliminar"].Visible = true;
            }
            else if (checkEstadoInactivo.Checked)
            {
                dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor(true);
                dgvProveedor.Columns["Eliminar"].Visible = false;
            }
        }

        private void AbrirFormulario2()
        {
            AgregarProveedor objAgregarProveedor = new AgregarProveedor(_id);
            objAgregarProveedor.LlenarDataGridViewRequested += (sender, args) => {
                LlenarDataGridView();
            };
            objAgregarProveedor.ShowDialog();
        }

        private void LlenarDataGridView()
        {
            llenarDataGridView();
        }

        private void CargarProveedorEnDataGridView()
        {
            _ProveedorLOG = new ProveedorLOG();
            dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["ProveedorId"].Value.ToString());
                //Enviamos los datos al form
                AbrirFormulario2();
                llenarDataGridView();
            }
            else if (dgvProveedor.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                _ProveedorLOG = new ProveedorLOG();
                int id = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["ProveedorId"].Value.ToString());
                int resultado = _ProveedorLOG.EliminarProveedor(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor desactivado con exito", "Tienda | Registro Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se logro desactivar el Proveedor", "Tienda | Registro Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            _id = 0;
            AbrirFormulario2();
        }

        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            FiltroPorNombre();
        }

        private void FiltroPorNombre()
        {
            _ProveedorLOG = new ProveedorLOG();
            string nombre = txtNombreProveedor.Text;
            if (checkEstadoActivo.Checked)
            {

                dgvProveedor.DataSource = _ProveedorLOG.FiltroNombre(nombre);

            }
            else if (checkEstadoInactivo.Checked)
            {

                dgvProveedor.DataSource = _ProveedorLOG.FiltroNombre(nombre, true);
            }
        }


        private void checkEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void checkEstadoActivo_CheckedChanged_1(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
