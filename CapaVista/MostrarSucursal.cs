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
    public partial class MostrarSucursal : Form
    {
        SucursalLOG _SucursalLOG;
        int _id = 0;

        public MostrarSucursal()
        {
            InitializeComponent();
            sucursalBindingSources.MoveLast();
            sucursalBindingSources.AddNew();
            CargarSucursalEnDataGridView();
        }

        private void GuardarSucursal()
        {
            _SucursalLOG = new SucursalLOG();
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
                    sucursalBindingSources.EndEdit();
                    Sucursal sucursal;
                    sucursal = (Sucursal)sucursalBindingSources.Current;
                    resultado = _SucursalLOG.ActualizarSucursal(sucursal, _id, true);
                    if (resultado > 0)
                    {
                        txtNombreSucursal.Clear();
                        txtDireccionSucursal.Clear();
                        MessageBox.Show("Sucursal Actualizada con exito", "Tienda | Registro Sucursal",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnActualizarSucursal.Visible = false;
                        btnGuardarSucursal.Visible = true;
                        CargarSucursalEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar la Sucursal", "Tienda | Registro Sucursal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sucursalBindingSources.EndEdit();

                    Sucursal sucursal;
                    sucursal = (Sucursal)sucursalBindingSources.Current;

                    resultado = _SucursalLOG.GuardarSucursal(sucursal);

                    if (resultado > 0)
                    {
                        txtNombreSucursal.Clear();
                        txtDireccionSucursal.Clear();
                        MessageBox.Show("Sucursal agregada con exito", "Tienda | Registro sucursal",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarSucursalEnDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar la sucursal", "Tienda | Registro sucursal",
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

        private void btnGuardarSucursal_Click(object sender, EventArgs e)
        {
            GuardarSucursal();
        }

        private void CargarSucursalEnDataGridView()
        {
            _SucursalLOG = new SucursalLOG();
            dvgSucursal.DataSource = _SucursalLOG.ObtenerSucursales();
        }

        private void btnActualizarSucursal_Click(object sender, EventArgs e)
        {
            GuardarSucursal();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(int id)
        {
            _SucursalLOG = new SucursalLOG();

            sucursalBindingSources.DataSource = _SucursalLOG.ObtenerPorId(id);

        }

        private void dvgSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgSucursal.Columns[e.ColumnIndex].Name == "Editar")
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                _id = Convert.ToInt32(dvgSucursal.CurrentRow.Cells["SucursalId"].Value.ToString());

                CargarDatos(_id);
                btnGuardarSucursal.Visible = false;
                btnActualizarSucursal.Visible = true;
            }

            if (dvgSucursal.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                _id = Convert.ToInt32(dvgSucursal.CurrentRow.Cells["SucursalId"].Value.ToString());
                EliminarSucursal(_id);
            }
        }

        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombreSucursal.Text))
            {
                MessageBox.Show("Se requiere el nombre de la sucursal \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Sucursal",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtNombreProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionSucursal.Text))
            {
                MessageBox.Show("Se requiere la direccion de la sucursal \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDireccionProveedor.Focus();
                //plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;
        }

        private void EliminarSucursal(int Id)
        {
            try
            {
                _SucursalLOG = new SucursalLOG();
                int resultado;
                if (Id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar este registro?",
                                            "Tienda | Registro Sucursalwe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        resultado = _SucursalLOG.EliminarSucursal(Id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("La Sucursal ha sido eliminada con exito", "Tienda | Registro Sucursales",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dvgSucursal.DataSource = _SucursalLOG.ObtenerSucursales();
                        }
                        else
                        {
                            MessageBox.Show("La Sucursal no se ha eliminado", "Tienda | Registro Sucursales",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Sucursal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
