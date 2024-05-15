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
    public partial class MostrarVentas : Form
    {
        VentaLOG _VentaLOG;
        
        public MostrarVentas()
        {
            InitializeComponent();
            CargarDatagridView();
            
        }

        public void CargarDatagridView()
        {
            _VentaLOG = new VentaLOG();
            dgvVentas.DataSource = _VentaLOG.ObtenerVentas();


        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvVentas.Columns[e.ColumnIndex].Name == "Cliente") // Reemplaza "Categoria" por el nombre real de la columna de la categoría
                {
                    var cliente = dgvVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Cliente; // Reemplaza "Categoria" por el nombre de la clase de la categoría
                    if (cliente != null)
                    {
                        e.Value = cliente.ClienteNombre +" "+cliente.ClienteApellido;
                    }
                }
                else if (dgvVentas.Columns[e.ColumnIndex].Name == "EmpleadoNombre") // Reemplaza "Marca" por el nombre real de la columna de la marca
                {
                    var empleado = dgvVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Empleado; // Reemplaza "Marca" por el nombre de la clase de la marca
                    if (empleado != null)
                    {
                        e.Value = empleado.EmpleadoNombre+" "+empleado.EmpleadoApellido;
                    }
                }
               
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name.Equals("Informacion"))
            {
                int id = Convert.ToInt32(dgvVentas.CurrentRow.Cells["VentaId"].Value.ToString());
                

                Reportes.ReporteVentas objeReporte = new Reportes.ReporteVentas(id);
                objeReporte.ShowDialog();

            }
        }
    }       
}
