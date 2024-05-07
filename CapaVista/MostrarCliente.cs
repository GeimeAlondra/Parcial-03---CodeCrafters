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
            clienteBindingSources.MoveLast();
            clienteBindingSources.AddNew();
            CargarClienteEnDataGridView();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
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
                    clienteBindingSources.EndEdit();
                    Cliente cliente;
                    cliente = (Cliente)clienteBindingSources.Current;
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
                        btnActualizarCliente.Visible = false;
                        btnGuardarCliente.Visible = true;
                        CargarClienteEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar el Cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    clienteBindingSources.EndEdit();

                    Cliente cliente;
                    cliente = (Cliente)clienteBindingSources.Current;

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
                        CargarClienteEnDataGridView();
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

        private void EliminarCliente(int Id)
        {
            try
            {
                _ClienteLOG = new ClienteLOG();
                int resultado;
                if (Id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar este registro?",
                                            "Tienda | Registro Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        resultado = _ClienteLOG.EliminarCliente(Id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("El cliente ha sido eliminado con exito", "Tienda | Registro Clientes",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dvgCliente.DataSource = _ClienteLOG.ObtenerCliente();
                        }
                        else
                        {
                            MessageBox.Show("El cliente no se ha eliminado", "Tienda | Registro Clientes",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClienteEnDataGridView()
        {
            _ClienteLOG = new ClienteLOG();
            dvgCliente.DataSource = _ClienteLOG.ObtenerCliente();
        }

        private void CargarDatos(int id)
        {
            _ClienteLOG = new ClienteLOG();

            clienteBindingSources.DataSource = _ClienteLOG.ObtenerPorId(id);

        }

        private void dvgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgCliente.Columns[e.ColumnIndex].Name == "Editar")
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dvgCliente.CurrentRow.Cells["ClienteId"].Value.ToString());

                CargarDatos(_id);
                btnGuardarCliente.Visible = false;
                btnActualizarCliente.Visible = true;
            }

            if (dvgCliente.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                _id = Convert.ToInt32(dvgCliente.CurrentRow.Cells["ClienteId"].Value.ToString());
                EliminarCliente(_id);
            }
        }

        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Se requiere el nombre del cliente \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtNombreProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Se requiere el apellido del cliente \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtNombreProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Se requiere la direccion del cliente \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDireccionProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCorreoCliente.Text))
            {
                MessageBox.Show("Se requiere el correo del cliente \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDireccionProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtTelefonoCliente.Text))
            {
                MessageBox.Show("Se requiere el telefono del cliente \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Cliente",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDireccionProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;
        }
    }
}
