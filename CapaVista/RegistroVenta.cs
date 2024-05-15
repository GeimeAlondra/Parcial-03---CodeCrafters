using Capa_Logica;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroVenta : Form
    {
        VentaLOG _VentaLOG;
        ProductoLOG _ProductoLOG;
        ClienteLOG _ClienteLOG;
        EmpleadoLOG _EmpleadoLOG;
        DataTable detalleVenta;


        public RegistroVenta(int id = 0)
        {
            InitializeComponent();
            CargarProductos();
            CargarClientes();
            CargarEmpleados();
          
            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }


        private void CargarProductos()
        {
            _ProductoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _ProductoLOG.ObtenerProductos();
        }

        private void CargarClientes()
        {
            _ClienteLOG = new ClienteLOG();
            var clientes = _ClienteLOG.ObtenerCliente();

            // Insertar un cliente de selección predeterminada
            clientes.Insert(0, new Cliente { ClienteId = 0, ClienteNombre = "---Seleccionar---" });

            clientebindingSource.DataSource = clientes;
            cbxCliente.SelectedIndex = 0;
        }

        private void CargarEmpleados()
        {
            _EmpleadoLOG = new EmpleadoLOG();         
            var empleado = _EmpleadoLOG.ObtenerEmpleado();
            // Insertar un Empleado de selección predeterminada
            empleado.Insert(0, new Empleado { EmpleadoId = 0, EmpleadoNombre = "---Seleccionar---" });
            empleadobindingSource.DataSource = empleado;
            cbxCliente.SelectedIndex = 0;

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _ProductoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigo.Text);

                var producto = _ProductoLOG.ObtenerProductoPorId(codigo);

                if (producto != null && producto.Estado == true)
                {
                    cbxNombreProd.Text = producto.ProductoNombre;
                }
                else
                {
                    cbxNombreProd.Text = "";
                }
            }
            else
            {
                CargarProductos();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductoLOG = new ProductoLOG();
                if (!ValidarCampoCantidad())
                {
                    return; // Si los campos no son válidos, salir del método
                }
                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                productoBindingSource.EndEdit();
                var producto = (Producto)productoBindingSource.Current;
                

                if (producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.ProductoNombre, producto.ProductoPrecio,
                        cantidad, (cantidad * producto.ProductoPrecio));

                    dgvDetalleVenta.DataSource = detalleVenta;

                    CalcularMontoTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error {ex}", "Tienda | Registro Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }
            txtMonto.Text = montoTotal.ToString();
        }

        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (precioValido && cantidad > 0)
                    {
                        decimal SubTotal = precio * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = SubTotal;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un precio válido");
                        CalcularMontoTotal();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
        public void LimpiarCampos()
        {
            txtMonto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            cbxCliente.SelectedIndex = 0;
            cbxEmpleado.SelectedIndex = 0;
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.Rows.Clear();
            dgvDetalleVenta.Columns.Clear();
            VaciarDetalleVenta();

        }

        private void VaciarDetalleVenta()
        {
            detalleVenta.Rows.Clear();
            detalleVenta.Columns.Clear();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }

        public bool ValidarCampoCantidad()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Se requiere la cantidad del Producto \n !Este campo es obligatorio!", "Tienda | Registro Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lineaCantidad.BackColor = Color.LightCoral;
                txtCantidad.Focus();

                camposValidos = false;
            }



            return camposValidos;
        }

        public bool ValidarCamposProcesar()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Se requiere la cantidad del Producto \n !Este campo es obligatorio!", "Tienda | Registro Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lineaCantidad.BackColor = Color.LightCoral;
                txtCantidad.Focus();

                camposValidos = false;
         
            }


            if (cbxCliente.SelectedIndex == 0)
            {
                MessageBox.Show("Se requiere el cliente de la Venta \n !Este campo es obligatorio!", "Tienda | Registro Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCliente.BackColor = Color.LightCoral;
               

                camposValidos = false;
            }

            if (cbxEmpleado.SelectedIndex == 0)
            {
                MessageBox.Show("Se requiere el empleado que realizo la Venta \n !Este campo es obligatorio!", "Tienda | Registro Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxEmpleado.BackColor = Color.LightCoral;

                camposValidos = false;
            }

            return camposValidos;
        }


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _VentaLOG = new VentaLOG();

                Venta venta = new Venta();

                if (!ValidarCamposProcesar())
                {
                    return; // Si los campos no son válidos, salir del método
                }
                venta.VentaFecha = DateTime.Now.ToShortDateString();
                venta.VentaTotal = decimal.Parse(txtMonto.Text);
                var empleadoSeleccionado = (Empleado)cbxEmpleado.SelectedItem;
                venta.EmpleadoId = empleadoSeleccionado.EmpleadoId;

                var clienteseleccionado = (Cliente)cbxCliente.SelectedItem;
                venta.ClienteId = clienteseleccionado.ClienteId;

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    var detalle = new DetalleVenta()
                    {
                        ProductoId = int.Parse(row.Cells["Codigo"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString())
                    };

                    venta.DetalleVenta.Add(detalle);

                    //Descontamos el producto
                    _ProductoLOG.DescontarStock(detalle.ProductoId, detalle.Cantidad);
                }
                    


                int resultado = _VentaLOG.GuardarVenta(venta);

                if (resultado > 0)
                {
                    LimpiarCampos();
                    
                    MessageBox.Show("Venta guardada con exito", "Tienda | Registro Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("No se logro guardar la Venta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Tienda|Registro Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            lineaCantidad.BackColor = Color.LightSkyBlue;
        }

        private void cbxEmpleado_Leave(object sender, EventArgs e)
        {
            cbxEmpleado.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void cbxCliente_Enter(object sender, EventArgs e)
        {
            cbxCliente.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void cbxEmpleado_Enter(object sender, EventArgs e)
        {
            cbxEmpleado.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public event EventHandler LlenarDataGridViewRequested;

        private void OnLlenarDataGridViewRequested()
        {
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
