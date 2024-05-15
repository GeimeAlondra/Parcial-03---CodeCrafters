using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Reportes
{
    public partial class ReporteVentas : Form
    {
        int _id = 0;
        public ReporteVentas(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            this.facturaTableAdapter.Fill(this.dSVenta.Factura, _id);
            this.reportViewer1.RefreshReport();
          
        }
    }
}
