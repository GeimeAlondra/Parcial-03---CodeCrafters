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
    public partial class RegistrosMarcas : Form
    {

        MarcasLOG  _MarcasLOG;

        public RegistrosMarcas()
        {
            InitializeComponent();
            marcasBindingSources.MoveLast();
            marcasBindingSources.AddNew();
        }

      



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarMarca();
        }


        //Metodo para guardar registro
        private void GuardarMarca()
        {
            _MarcasLOG = new MarcasLOG();

            try
            {
                //Verificamos el texbox
                //throw new Exception();
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    plinea.BackColor = Color.LightCoral;
                    return;
                }
                

                marcasBindingSources.EndEdit();
                
                Marca marca;
                marca = (Marca)marcasBindingSources.Current;

                int resultado = _MarcasLOG.GuardarMarca(marca);

                if (resultado > 0)
                {
                    MessageBox.Show("Marca agregado con exito", "Tienda | Registro Marcas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se logro guardar la Marca", "Tienda | Registro Marcas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un Error: ","Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        
    }
}
