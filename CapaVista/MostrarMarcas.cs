using Capa_Logica;
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
        MarcasLOG _MarcaLOG;
        public MostrarMarcas()
        {
            _MarcaLOG = new MarcasLOG();    
            InitializeComponent();
            dvgMarcas.DataSource = _MarcaLOG.ObtenerMarcas();
        }

        private void dvgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgMarcas.Columns[e.ColumnIndex].Name == "Editar")
            {
                int Id = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["MarcaId"].Value.ToString());
                Console.WriteLine("Aqui esta el id desde editar" + Id);
            }

            if (dvgMarcas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int Id = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["MarcaId"].Value.ToString());
                Console.WriteLine("Aqui esta el id desde eliminar" + Id);
            }


        }
    }
}
