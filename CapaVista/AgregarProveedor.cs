using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                MessageBox.Show("Se requiere el nombre del Proveedor \n !Este campo es obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCorreoProveedor.Text))
            {
                MessageBox.Show("Se requiere el correo del Proveedor \n !Este campo es obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionProveedor.Text))
            {
                MessageBox.Show("Se requiere la direccion del Proveedor \n !Este campo es obligatorio!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionProveedor.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtTelefonoProveedor.Text))
            {
                MessageBox.Show("Se requiere el telefono del Proveedor \n !Este campo es obligatorio!", "Tienda | Registro Proveedor",
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
                        MessageBox.Show("Proveedor actualizado con exito", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el Proveedor", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEstadoProveedor.Checked)
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el proveedor inactivo", "Tienda | Registro Proveedor",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Proveedor",
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
                        MessageBox.Show("No se logro guardar el Proveedor", "Tienda | Registro Proveedor",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "Tienda | Registro Proveedor",
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

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caracteres permitidos: letras, números, espacios, comas, puntos y guiones
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreoProveedor_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreoProveedor.Text.Trim();

            // Expresión regular para validar el correo electrónico
            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            // Verificamos si el correo no es válido
            if (!re.IsMatch(correo))
            {
                txtCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);

                MessageBox.Show("El correo es invalido", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                txtCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
            }
        }

        private void txtCorreoProveedor_Validated(object sender, EventArgs e)
        {
            txtCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
        }
    }
}
