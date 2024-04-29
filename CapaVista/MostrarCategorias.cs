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
    public partial class MostrarCategorias : Form
    {
        CategoriaLOG _CategoriaLOG;
        int _id = 0;
        public MostrarCategorias()


        {
            InitializeComponent();
            categoriaBindingSources.MoveLast();
            categoriaBindingSources.AddNew();
            CargarCategoriaEnDataGridView();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void GuardarCategoria()
        {
            _CategoriaLOG = new CategoriaLOG();
            try
            {
                int resultado;
                //debemo indicar si es una actualizacion o es un nuevo producto
                if (_id > 0)
                {
                    Categoria categoria;
                    categoria = (Categoria)categoriaBindingSources.Current;
                    resultado = _CategoriaLOG.ActualizarCategoria(categoria, _id,true);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoria Actualizada con exito", "Tienda | Registro Categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar la Categoria", "Tienda | Registro Categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    categoriaBindingSources.EndEdit();

                    Categoria categoria;
                    categoria = (Categoria)categoriaBindingSources.Current;

                    resultado = _CategoriaLOG.GuardarCategoria(categoria);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoria agregado con exito", "Tienda | Registro categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar la categoria", "Tienda | Registro categoria",
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
        private void CargarCategoriaEnDataGridView()
        {
            _CategoriaLOG = new CategoriaLOG();

            try
            {

                dvgCategorias.DataSource = _CategoriaLOG.ObtenerCategorias();


            }
            catch(Exception ex)
            {

            }
        }

        private void CargarCamposCategoria()
        {

        }










        private bool ValidarCampos()
        {

            bool camposValidos = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Se requiere el nombre de la Categoria \n\n !!Este Campo es Obligatorio!!", "Tienda | Registro Categoria",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtNombreProveedor.Focus();
                plinea.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            return camposValidos;

        }

        private void dvgCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
