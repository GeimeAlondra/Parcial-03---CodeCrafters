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
    public partial class MostrarTipoEmpleado : Form
    {
        TipoEmpleadoLOG _TipoEmpleadoLOG;
        int _id = 0;

        public MostrarTipoEmpleado()
        {
            InitializeComponent();
            tipoEmpleadoBindingSources.MoveLast();
            tipoEmpleadoBindingSources.AddNew();
            CargarTipoEmpleadoEnDataGridView();
        }

        private void btnGuardarTipoEmpleado_Click(object sender, EventArgs e)
        {
            GuardarTipoEmpleado();
        }

        private void btnActualizarTipoEmpleado_Click(object sender, EventArgs e)
        {
            GuardarTipoEmpleado();
        }

        private void GuardarTipoEmpleado()
        {
            _TipoEmpleadoLOG = new TipoEmpleadoLOG();

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
                    tipoEmpleadoBindingSources.EndEdit();
                    TipoEmpleado tipoEmpleado;
                    tipoEmpleado = (TipoEmpleado)tipoEmpleadoBindingSources.Current;
                    resultado = _TipoEmpleadoLOG.ActualizarTipoEmpleado(tipoEmpleado, _id, true);
                    if (resultado > 0)
                    {
                        txtCargo.Clear();
                        MessageBox.Show("Tipo Empleado Actualizado con exito", "Tienda | Registro Tipo Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnActualizarTipoEmpleado.Visible = false;
                        btnGuardarTipoEmpleado.Visible = true;
                        CargarTipoEmpleadoEnDataGridView();

                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Tipo Empleado", "Tienda | Registro Tipo Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    tipoEmpleadoBindingSources.EndEdit();

                    TipoEmpleado tipoEmpleado;
                    tipoEmpleado = (TipoEmpleado)tipoEmpleadoBindingSources.Current;

                    resultado = _TipoEmpleadoLOG.GuardarTipoEmpleado(tipoEmpleado);

                    if (resultado > 0)
                    {
                        txtCargo.Clear();
                        MessageBox.Show("Tipo Empleado Agregado con Exito", "Tienda | Registro Tipo Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTipoEmpleadoEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Guardar el Tipo Empleado", "Tienda | Registro Tipo Empleado",
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

        private void EliminarTipoEmpleado(int id)
        {
            _TipoEmpleadoLOG = new TipoEmpleadoLOG();
            int resultado = _TipoEmpleadoLOG.EliminarTipoEmpleado(id);
            if (resultado > 0)
            {
                MessageBox.Show("Tipo Empleado Eliminado con exito", "Tienda | Registro Tipo Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTipoEmpleadoEnDataGridView();
            }
            else
            {
                MessageBox.Show("No se logro Eliminar el Tipo Empleado", "Tienda | Registro Tipo Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("Se requiere el nombre del cargo \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Tipo Empleado",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;

        }

        private void CargarDatos(int id)
        {
            _TipoEmpleadoLOG = new TipoEmpleadoLOG();

            tipoEmpleadoBindingSources.DataSource = _TipoEmpleadoLOG.ObtenerPorId(id);

        }

        private void CargarTipoEmpleadoEnDataGridView()
        {
            _TipoEmpleadoLOG = new TipoEmpleadoLOG();
            dvgTipoEmpleado.DataSource = _TipoEmpleadoLOG.ObtenerTipoEmpleados();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgTipoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgTipoEmpleado.Columns[e.ColumnIndex].Name == "Editar")
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dvgTipoEmpleado.CurrentRow.Cells["TipoEmpleadoId"].Value.ToString());
                //

                CargarDatos(_id);
                btnGuardarTipoEmpleado.Visible = false;
                btnActualizarTipoEmpleado.Visible = true;

            }

            if (dvgTipoEmpleado.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                _id = Convert.ToInt32(dvgTipoEmpleado.CurrentRow.Cells["TipoEmpleadoId"].Value.ToString());
                EliminarTipoEmpleado(_id);
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
