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
using System.Windows.Documents;
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
            //this.dvgProveedor.DataSource = proveedorBindingSource;
            dvgProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();

            
        }

        private void dvgProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgProveedor.Columns[e.ColumnIndex].Name == "Editar")
            {
                
                //DataGridViewRow row = dvgProveedor.Rows[e.RowIndex];
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                int Id = Convert.ToInt32(dvgProveedor.CurrentRow.Cells["ProveedorId"].Value.ToString());
                //lleno el formulario con los datos de mi seleccion en el datagridview
                txtNombreProveedor.Text = dvgProveedor.CurrentRow.Cells["NombreProveedor"].Value.ToString();
                txtCorreoProveedor.Text = dvgProveedor.CurrentRow.Cells["ProveedorCorreo"].Value.ToString();
                txtDireccionProveedor.Text = dvgProveedor.CurrentRow.Cells["ProveedorDireccion"].Value.ToString();
                txtTelefonoProveedor.Text = dvgProveedor.CurrentRow.Cells["ProveedorTelefono"].Value.ToString();

                txtProveedorId.Text = dvgProveedor.CurrentRow.Cells["ProveedorId"].Value.ToString();


                btnGuardarProveedor.Visible = false;
                btnActualizar.Visible = true;

            }

            if (dvgProveedor.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int Id = Convert.ToInt32(dvgProveedor.CurrentRow.Cells["ProveedorId"].Value.ToString());
                //Mando a llamar el metodo para eliminar el registro en la tabla marcas y le paso el id del fila
                EliminarProveedor(Id);

            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txtNombreProveedor.Clear();
                    txtCorreoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtTelefonoProveedor.Clear();

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
                int Id = Convert.ToInt32(txtProveedorId.Text);
                int resultado = _ProveedorLOG.GuardarProveedor(proveedor,Id,true);
                if (resultado > 0)
                {
                    txtNombreProveedor.Clear();
                    txtCorreoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtTelefonoProveedor.Clear();

                    MessageBox.Show("Proveedor actualizado con exito", "Tienda | Registro Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Cambiando visibilidad de los botones
                    btnActualizar.Visible = false;
                    btnGuardarProveedor.Visible = true;
                    dvgProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
                }
                else
                {
                    MessageBox.Show("No se logro actualizar el proveedor ", "Tienda | Registro Proveedor",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
         

        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombreProveedor.Text))
            {
                MessageBox.Show("Se requiere el nombre del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtNombreProveedor.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }


            if (string.IsNullOrEmpty(txtCorreoProveedor.Text))
            {
                MessageBox.Show("Se requiere el correo del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtCorreoProveedor.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDireccionProveedor.Text))
            {
                MessageBox.Show("Se requiere la direccion del proveedor \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDireccionProveedor.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            if (string.IsNullOrEmpty(txtTelefonoProveedor.Text))
            {
                MessageBox.Show("Se requiere el telefono del proveedor\n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Proveedor",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtTelefonoProveedor.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;

        }
       
        private void EliminarProveedor(int Id)
        {
            try
            {
                _ProveedorLOG = new ProveedorLOG();
                int resultado;
                if (Id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar este registro?",
                                            "Tienda | Registro Marcas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        resultado = _ProveedorLOG.EliminarProveedor(Id);

                        if (resultado > 0)
                        {
                            MessageBox.Show("La Marca ha sido eliminada con exito", "Tienda | Registro Marcas",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dvgProveedor.DataSource = _ProveedorLOG.ObtenerProveedor();
                        }
                        else
                        {
                            MessageBox.Show("La Marca no se a eliminado", "Tienda | Registro Marcas",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }
    }
}
