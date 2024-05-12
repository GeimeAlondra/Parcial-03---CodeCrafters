﻿using Capa_Logica;
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
    public partial class AgregarEmpleado : Form
    {
        EmpleadoLOG _EmpleadoLOG;
        int _id = 0;

        public AgregarEmpleado(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if (_id > 0)
            {
                this.Text = "Tienda|Edicion de Empleados";
                //Cambiar el boton
                btnGuardarEmpleado.Text = "Actualizar";
                btnGuardarEmpleado.BackColor = Color.FromArgb(82, 190, 128);
                
                ObtenerTipoEmpleados();
                CargarElementos(_id);
            }
            else
            {
                empleadobindingSource.MoveLast();
                empleadobindingSource.AddNew();
                ObtenerTipoEmpleados();
            }
        }

        public event EventHandler LlenarDataGridViewRequested;

        private void OnLlenarDataGridViewRequested()
        {
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void CargarElementos(int id)
        {
            _EmpleadoLOG = new EmpleadoLOG();
            empleadobindingSource.DataSource = _EmpleadoLOG.ObtenerPorId(_id);
        }

        private void ObtenerTipoEmpleados()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            List<TipoEmpleado> tipoEmpleados = _EmpleadoLOG.ObtenerTipoEmpleado();
            tipoEmpleados.Insert(0, new TipoEmpleado { TipoEmpleadoId = 0, Cargo = "---Seleccionar---" });
            cbCargoEmpleado.DataSource = tipoEmpleados;
            cbCargoEmpleado.DisplayMember = "Cargo"; // Propiedad de la entidad Marca para mostrar en el ComboBox
            cbCargoEmpleado.ValueMember = "TipoEmpleadoId";
            cbCargoEmpleado.SelectedIndex = 0;
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            GuardarEmpleado();
        }

        private void GuardarEmpleado()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }
                int resultado;

                //debemo indicar si es una actualizacion o es un nuevo producto
                if (_id > 0)
                {
                    empleadobindingSource.EndEdit();
                    Empleado empleado;
                    empleado = (Empleado)empleadobindingSource.Current;
                    resultado = _EmpleadoLOG.ActualizarEmpleado(empleado, _id, true);
                    if (resultado > 0)
                    {
                        txtNombreEmpleado.Clear();
                        txtApellidoEmpleado.Clear();
                        txtFechaNacEmpleado.Clear();
                        txtDireccionEmpleado.Clear();
                        txtSalarioEmpleado.Clear();
                        cbCargoEmpleado.SelectedItem = null;
                        MessageBox.Show("Empleado Actualizado con exito", "Tienda | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Empleado", "Tienda | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEstadoEmpleado.Checked)
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el empleado inactivo", "Tienda | Registro Empleados",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Empleados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    empleadobindingSource.EndEdit();

                    Empleado empleado;
                    empleado = (Empleado)empleadobindingSource.Current;

                    resultado = _EmpleadoLOG.GuardarEmpleado(empleado);

                    if (resultado > 0)
                    {
                        txtNombreEmpleado.Clear();
                        txtApellidoEmpleado.Clear();
                        txtFechaNacEmpleado.Clear();
                        txtDireccionEmpleado.Clear();
                        txtSalarioEmpleado.Clear();
                        MessageBox.Show("Empleado agregado con exito", "Tienda | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el Empleado", "Tienda | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "Tienda | Registro Empleados",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Se requiere el nombre del Empleado \\n\\n !Este Campo es Obligatorio!", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreEmpleado.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtApellidoEmpleado.Text))
            {
                MessageBox.Show("Se requiere el apellido del Empleado \\n\\n !Este Campo es Obligatorio!", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoEmpleado.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtFechaNacEmpleado.Text))
            {
                MessageBox.Show("Se requiere la fecha de nacimiento del Empleado \\n\\n !Este Campo es Obligatorio!", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFechaNacEmpleado.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionEmpleado.Text))
            {
                MessageBox.Show("Se requiere la dirección del Empleado \\n\\n !Este Campo es Obligatorio!", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionEmpleado.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtSalarioEmpleado.Text))
            {
                MessageBox.Show("Se requiere el monto del salario del Empleado \\n\\n !Este Campo es Obligatorio!", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioEmpleado.Focus();
                camposValidos = false;
            }

            // Validación del ComboBox
            if (cbCargoEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un cargo válido.", "Tienda | Registro Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCargoEmpleado.Focus();
                camposValidos = false;
            }

            return camposValidos;
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            MostrarTipoEmpleado objMostraCat = new MostrarTipoEmpleado();
            objMostraCat.ShowDialog();
            ObtenerTipoEmpleados();
        }
    }

}