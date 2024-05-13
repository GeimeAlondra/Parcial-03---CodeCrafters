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
    public partial class MostrarEmpleado : Form
    {
        int _id = 0;
        //private DataTable dataTable;
        EmpleadoLOG _EmpleadoLOG;

        public MostrarEmpleado()
        {
            InitializeComponent();
            ObtenerTipoEmpleados();
            llenarDataGridView();
        }

        private void llenarDataGridView()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            if (checkEstadoActivo.Checked)
            {
                dvgEmpleado.DataSource = _EmpleadoLOG.ObtenerEmpleado();
            }
            else if (checkEstadoInactivo.Checked)
            {
                dvgEmpleado.DataSource = _EmpleadoLOG.ObtenerEmpleado(true);
            }
      
            cbCargoEmpleado.SelectedIndex = 0;
        }

        private void AbrirFormulario2()
        {
            AgregarEmpleado objAgregarEmpleado = new AgregarEmpleado(_id);
            objAgregarEmpleado.LlenarDataGridViewRequested += (sender, args) => {
                LlenarDataGridView();
            };
            objAgregarEmpleado.ShowDialog();
        }

        private void LlenarDataGridView()
        {
            llenarDataGridView();
        }





        private void checkEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void checkEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void ObtenerTipoEmpleados()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            List<TipoEmpleado> tipoEmpleados = _EmpleadoLOG.ObtenerTipoEmpleado();
            tipoEmpleados.Insert(0, new TipoEmpleado { TipoEmpleadoId = 0, Cargo = "---Seleccionar---" });
            cbCargoEmpleado.DataSource = tipoEmpleados;
            cbCargoEmpleado.DisplayMember = "Cargo"; 
            cbCargoEmpleado.ValueMember = "TipoEmpleadoId";
            cbCargoEmpleado.SelectedIndex = 0;
        }

        private void cbCargoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
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
            TipoEmpleado tipoEmpleadoSeleccionado = (TipoEmpleado)cbCargoEmpleado.SelectedItem;

            if (tipoEmpleadoSeleccionado != null)
            {
                int valorId = tipoEmpleadoSeleccionado.TipoEmpleadoId;

                _EmpleadoLOG = new EmpleadoLOG();
                dvgEmpleado.DataSource = _EmpleadoLOG.FiltroTipoEmpleado(valorId, inactivos);
            }
            else
            {
                MessageBox.Show("Seleccione un cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltroPorNombre()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            string nombre = txtNombreEmpleado.Text;
            if (checkEstadoActivo.Checked)
            {

                dvgEmpleado.DataSource = _EmpleadoLOG.FiltroNombre(nombre);

            }
            else if (checkEstadoInactivo.Checked)
            {

                dvgEmpleado.DataSource = _EmpleadoLOG.FiltroNombre(nombre, true);
            }
            cbCargoEmpleado.SelectedIndex = 0;
        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltroPorNombre();
        }

        private void dvgEmpleado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dvgEmpleado.Columns[e.ColumnIndex].Name == "TipoEmpleado") 
                {
                    var tipoEmpleado = dvgEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as TipoEmpleado; 
                    if (tipoEmpleado != null)
                    {
                        e.Value = tipoEmpleado.Cargo;
                    }
                }
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            _id = 0;
            AbrirFormulario2();
        }

       

        private void dvgEmpleado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgEmpleado.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                _id = Convert.ToInt32(dvgEmpleado.CurrentRow.Cells["EmpleadoId"].Value.ToString());
                //Enviamos los datos al form
                AbrirFormulario2();
                llenarDataGridView();
            }
            else if (dvgEmpleado.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                _EmpleadoLOG = new EmpleadoLOG();
                int id = Convert.ToInt32(dvgEmpleado.CurrentRow.Cells["EmpleadoId"].Value.ToString());
                int resultado = _EmpleadoLOG.EliminarEmpleado(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Empleado Eliminado con exito", "Tienda | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se logro Eliminar el Empleado", "Tienda | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
