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
    public partial class MostrarMarcas : Form
    {
        MarcasLOG _MarcasLOG;

        
        public MostrarMarcas()
        {
            
            _MarcasLOG = new MarcasLOG();    
            InitializeComponent();
            
            marcasBindingSources.MoveLast();
            marcasBindingSources.AddNew();
            dvgMarcas.DataSource = _MarcasLOG.ObtenerMarcas();
        }

        private void dvgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgMarcas.Columns[e.ColumnIndex].Name == "Editar")
            {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                int Id = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["MarcaId"].Value.ToString());
               //lleno el formulario con los datos de mi seleccion en el datagridview
                txtNombre.Text = dvgMarcas.CurrentRow.Cells["Marcas"].Value.ToString();
                txtMarcaId.Text = dvgMarcas.CurrentRow.Cells["MarcaId"].Value.ToString();
                btnGuardarMarca.Visible = false;
                btnActualizar.Visible = true;

            }

            if (dvgMarcas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int Id = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["MarcaId"].Value.ToString());
                //Mando a llamar el metodo para eliminar el registro en la tabla marcas y le paso el id del fila
                EliminarMarca(Id);
                
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }
        //****************************//
        //Metodo para guardar registro//
        //****************************//
        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            //Llamamos la funcion de guardar
            GuardarMarca();
        }
       

        private void GuardarMarca()
        {
            _MarcasLOG = new MarcasLOG();
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("!!El campo nombre no se puede dejar vacio,\n ¡Es obligatorio!", "Tienda | Registro Marca",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Verificamos el texbox
                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Se requiere el nombre de la Marca", "Tienda | Registro Marca",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                        plinea.BackColor = Color.LightCoral;
                        return;
                    }
                    //Binding Sources
                    marcasBindingSources.EndEdit();
                    Marca marca;
                    marca = (Marca)marcasBindingSources.Current;
                    int resultado = _MarcasLOG.GuardarMarca(marca);
                    if (resultado > 0)
                    {
                        txtNombre.Clear();
                        MessageBox.Show("Marca agregada con exito", "Tienda | Registro Marca",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dvgMarcas.DataSource = _MarcasLOG.ObtenerMarcas();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar la Marca", "Tienda | Registro Marca",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: ", "Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //****************************//
        //Metodo para Actualizar Marca//
        //****************************//
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMarca();
        }

        private void ActualizarMarca()
        {
            _MarcasLOG = new MarcasLOG();
            try
            {
                //Verificamos el texbox
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre de la Marca \n !Este campo es obligatorio!", "Tienda | Registro Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    plinea.BackColor = Color.LightCoral;
                    return;
                }
                else
                {
                    //Binding Sources
                    marcasBindingSources.EndEdit();
                    Marca marca;
                    marca = (Marca)marcasBindingSources.Current;
                    int Id = Convert.ToInt32(txtMarcaId.Text);
                    int resultado = _MarcasLOG.GuardarMarca(marca,Id,true);
                    if (resultado > 0)
                    {
                        txtNombre.Clear();
                        MessageBox.Show("Marca actualizada con exito", "Tienda | Registro Marca",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cambiamos visivibilidad del boton de guardar a true y ocultamos el deactualizar
                        btnActualizar.Visible = false;
                        btnGuardarMarca.Visible = true;

                        dvgMarcas.DataSource = _MarcasLOG.ObtenerMarcas();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar la Marca", "Tienda | Registro Marca",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: ", "Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //****************************//
        // Metodo para Eliminar Marca //
        //****************************//

        private void EliminarMarca(int Id)
        {
            try 
            {
                _MarcasLOG = new MarcasLOG();
                int resultado;
                if (Id != null)
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quiere eliminar este registro?",
                                            "Tienda | Registro Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        resultado = _MarcasLOG.EliminarMarca(Id);

                        if(resultado > 0)
                        {
                            MessageBox.Show("La Marca ha sido eliminada con exito", "Tienda | Registro Marca",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                           dvgMarcas.DataSource = _MarcasLOG.ObtenerMarcas();
                        }
                        else
                        {
                            MessageBox.Show("La Marca no se ha eliminado", "Tienda | Registro Marca",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrió un Error: {ex}", "Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
