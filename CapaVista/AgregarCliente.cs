

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
                MessageBox.Show("Se requiere el nombre del Cliente \n !Este campo es obligatorio!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCliente.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Se requiere el apellido del Cliente \n !Este campo es obligatorio!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoCliente.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                MessageBox.Show("Se requiere la direccion del Cliente \n !Este campo es obligatorio!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionCliente.Focus();
                camposValidos = false;

            }

            if (string.IsNullOrEmpty(txtCorreoCliente.Text))
            {
                MessageBox.Show("Se requiere el correo del Cliente \n !Este campo es obligatorio!", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Cliente actualizado con exito", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el Cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEstadoCliente.Checked)
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el cliente inactivo", "Tienda | Registro Cliente",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Cliente",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

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
                        MessageBox.Show("No se logro guardar el Cliente", "Tienda | Registro Cliente",
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

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caracteres permitidos: letras, números, espacios, comas, puntos y guiones
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreoCliente_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreoCliente.Text.Trim();

            // Expresión regular para validar el correo electrónico
            Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            // Verificamos si el correo no es válido
            if (!re.IsMatch(correo))
            {
                txtCorreoCliente.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);

                MessageBox.Show("El correo es invalido", "Tienda | Registro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                txtCorreoCliente.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
            }
        }

        private void txtCorreoCliente_Validated(object sender, EventArgs e)
        {
            txtCorreoCliente.BackColor = System.Drawing.Color.FromArgb(35, 32, 39);
        }
    }
}
