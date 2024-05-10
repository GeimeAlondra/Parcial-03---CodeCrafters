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

            //proveedorbindingSource.MoveLast();
            //proveedorbindingSource.AddNew();
            CargarProveedorEnDataGridView();
            llenarDataGridView();
        }

        private void llenarDataGridView()
        {
            _ProveedorLOG = new ProveedorLOG();
            if (checkEstadoActivo.Checked)
            {
                dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
            }
            else if (checkEstadoInactivo.Checked)
            {
                dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor(true);
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
            throw new NotImplementedException();
        }

        private void CargarProveedorEnDataGridView()
        {
            _ProveedorLOG = new ProveedorLOG();
            dgvProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
        }

   

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario2();
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
                    MessageBox.Show("Proveedor Eliminado con exito", "Tienda | Registro Proveedores",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se logro eliminar el Proveedor", "Tienda | Registro Proveedores",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void checkEstadoActivo_CheckedChanged(object sender, EventArgs e)
        //{
        //    llenarDataGridView();
        //}

        //private void checkEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        //{
        //    llenarDataGridView();
        //}
    }
}
