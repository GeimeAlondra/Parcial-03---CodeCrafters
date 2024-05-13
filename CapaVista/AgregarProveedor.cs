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
    public partial class AgregarProveedor : Form
    {
        ProveedorLOG _ProveedorLOG;
        int _id = 0;

        public AgregarProveedor(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if (_id > 0)
            {
                this.Text = "Tienda|Edicion de Proveedores";
                //Cambiar el boton
                btnGuardarProveedor.Text = "Actualizar";
                btnGuardarProveedor.BackColor = Color.FromArgb(82, 190, 128);
                //
                CargarElementos(_id);
            }
            else
            {
                proveedorbindingSource.MoveLast();
                proveedorbindingSource.AddNew();
            }
        }

        private void CargarElementos(int id)
        {
            _ProveedorLOG = new ProveedorLOG();
            proveedorbindingSource.DataSource = _ProveedorLOG.ObtenerProveedorPorId(_id);
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombreProveedor.Text))
            {
                MessageBox.Show("Se requiere el nombre del proveedor \n\n !Este Campo es Obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCorreoProveedor.Text))
            {
                MessageBox.Show("Se requiere el correo del proveedor \n\n !Este Campo es Obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionProveedor.Text))
            {
                MessageBox.Show("Se requiere la direccion del proveedor \n\n !Este Campo es Obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtTelefonoProveedor.Text))
            {
                MessageBox.Show("Se requiere el telefono del proveedor\n\n !Este Campo es Obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefonoProveedor.Focus();
                camposValidos = false;
            }
            return camposValidos;
        }

        private void GuardarProveedor()
        {
            _ProveedorLOG = new ProveedorLOG();
            try
            {
                if (!ValidarCampos())
                {
                    return; 
                }
                int resultado;

                //debemos indicar si es una actualizacion o es un nuevo producto
                if (_id > 0)
                {
                    proveedorbindingSource.EndEdit();
                    Proveedor proveedor;
                    proveedor = (Proveedor)proveedorbindingSource.Current;
                    resultado = _ProveedorLOG.ActualizarProveedor(proveedor, _id, true);
                    if (resultado > 0)
                    {
                        txtNombreProveedor.Clear();
                        txtCorreoProveedor.Clear();
                        txtDireccionProveedor.Clear();
                        txtTelefonoProveedor.Clear();
                        MessageBox.Show("Proveedor Actualizado con exito", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Proveedor", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEstadoProveedor.Checked)
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el proveedor inactivo", "Tienda | Registro Proveedores",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Proveedores",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    proveedorbindingSource.EndEdit();

                    Proveedor proveedor;
                    proveedor = (Proveedor)proveedorbindingSource.Current;

                    resultado = _ProveedorLOG.GuardarProveedor(proveedor);

                    if (resultado > 0)
                    {
                        txtNombreProveedor.Clear();
                        txtCorreoProveedor.Clear();
                        txtDireccionProveedor.Clear();
                        txtTelefonoProveedor.Clear();
                        MessageBox.Show("Proveedor agregado con exito", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el proveedor", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "Tienda | Registro Proveedores",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
            OnLlenarDataGridViewRequested();
        }

        public event EventHandler LlenarDataGridViewRequested;

        private void OnLlenarDataGridViewRequested()
        {
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
