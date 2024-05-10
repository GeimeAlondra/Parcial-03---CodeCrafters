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
    public partial class AgregarEmpleado : Form
    {
        EmpleadoLOG _EmpleadoLOG;
        int _id = 0;

        public AgregarEmpleado(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if (_id > 0)
            {
                this.Text = "Tienda|Edicion de Empleados";
                //Cambiar el boton
                btnGuardarEmpleado.Text = "Actualizar";
                btnGuardarEmpleado.BackColor = Color.FromArgb(82, 190, 128);
                
                ObtenerTipoEmpleados();
                //CargarElementos(_id);
            }
            else
            {
                empleadobindingSource.MoveLast();
                empleadobindingSource.AddNew();
                ObtenerTipoEmpleados();
            }
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            ObtenerTipoEmpleados();
        }

        private void ObtenerTipoEmpleados()
        {
            _EmpleadoLOG = new EmpleadoLOG();
            List<TipoEmpleado> tipoEmpleados = _EmpleadoLOG.ObtenerTipoEmpleado();
            tipoEmpleados.Insert(0, new TipoEmpleado{ TipoEmpleadoId = 0, Cargo = "---Seleccionar---" });
            cbCargoEmpleado.DataSource = tipoEmpleados;
            cbCargoEmpleado.DisplayMember = "Cargo"; // Propiedad de la entidad TipoEmpleado para mostrar en el ComboBox
            cbCargoEmpleado.ValueMember = "TipoEmpleadoId";
            cbCargoEmpleado.SelectedIndex = 0;
        }

   

       
    }
}
