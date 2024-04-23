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
    public partial class MostrarProveedor : Form
    {
        ProveedorLOG _ProveedorLOG;
        public MostrarProveedor()
        {
            _ProveedorLOG = new ProveedorLOG();
            InitializeComponent();
            proveedorBindingSource.MoveLast();
            proveedorBindingSource.AddNew();
            dvgProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();

        }

      
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Se requiere el nombre del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }


            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Se requiere el correo del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Se requiere la direccion del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Se requiere el telefono del proveedor\n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;

        }

        private void GuardarProveedor()
        {
            _ProveedorLOG = new ProveedorLOG();
            try
            {
                if (ValidarCampos())
                {
                }
                ////Binding Sources
                proveedorBindingSource.EndEdit();
                Proveedor proveedor;
                proveedor = (Proveedor)proveedorBindingSource.Current;
                int resultado = _ProveedorLOG.GuardarProveedor(proveedor);
                if (resultado > 0)
                {
                    txtNombre.Clear();
                    MessageBox.Show("Proveedor Guardado con exito", "Tienda | Registro Proveedro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvgProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
                }
                else
                {
                    MessageBox.Show("No se logro guardar la Marca", "Tienda | Registro Marcas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProveedor()
        {

        }













    }
}
