using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class AgregarCliente : Form
    {
        ClienteLOG _ClienteLOG;
        int _id = 0;

        public AgregarCliente(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if (_id > 0)
            {
                this.Text = "Tienda|Edicion de Clientes";
                //Cambiar el boton
                btnGuardarCliente.Text = "Actualizar";
                btnGuardarCliente.BackColor = Color.FromArgb(82, 190, 128);
          
                CargarElementos(_id);
            }
            else
            {
                clientebindingSource.MoveLast();
                clientebindingSource.AddNew();
            }
        }

        private void CargarElementos(int id)
        {
            _ClienteLOG = new ClienteLOG();
            clientebindingSource.DataSource = _ClienteLOG.ObtenerPorId(_id);

        }

        public event EventHandler LlenarDataGridViewRequested;

        private void OnLlenarDataGridViewRequested()
        {
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Se requiere el nombre del Cliente \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCliente.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Se requiere el apellido del Cliente \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Clienteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoCliente.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Se requiere la direccion del Cliente \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionCliente.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCorreoCliente.Text))
            {
                MessageBox.Show("Se requiere el correo del Cliente \\n\\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoCliente.Focus();
                camposValidos = false;
            }

            return camposValidos;
        }

        private void GuardarCliente()
        {
            _ClienteLOG = new ClienteLOG();

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
                    clientebindingSource.EndEdit();
                    Cliente cliente;
                    cliente = (Cliente)clientebindingSource.Current;
                    resultado = _ClienteLOG.ActualizarCliente(cliente, _id, true);
                    if (resultado > 0)
                    {
                        txtNombreCliente.Clear();
                        txtApellidoCliente.Clear();
                        txtDireccionCliente.Clear();
                        txtCorreoCliente.Clear();
                        txtTelefonoCliente.Clear();
                        MessageBox.Show("Cliente Actualizado con exito", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    clientebindingSource.EndEdit();

                    Cliente cliente;
                    cliente = (Cliente)clientebindingSource.Current;

                    resultado = _ClienteLOG.GuardarCliente(cliente);

                    if (resultado > 0)
                    {
                        txtNombreCliente.Clear();
                        txtApellidoCliente.Clear();
                        txtDireccionCliente.Clear();
                        txtCorreoCliente.Clear();
                        txtTelefonoCliente.Clear();
                        MessageBox.Show("Cliente agregado con exito", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //CargarClienteEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "Tienda | Registro Cliente",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            OnLlenarDataGridViewRequested();
        }
    }
}
