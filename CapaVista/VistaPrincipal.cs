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
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
            PersonalizarInterfaz();
            
        }

        private void PersonalizarInterfaz()
        {
            panelMantenimientos.Visible = false;
            panelVentas.Visible = false;   
            panelTools.Visible = false;
            //..agregar el panel nuevo cada vez

        }
        //Metodo para ocultar un sub menu
        private void HideSubMenu()
        {
            if (panelMantenimientos.Visible == true )
            {
                panelMantenimientos.Visible = false;
                
            }
            if(panelVentas.Visible == true)
            {
                panelVentas.Visible = false;
            }
            if (panelTools.Visible == true)
            {
                panelTools.Visible = false;
            }


            //aqui se debe agregar condiciones si se agregan mas paneles
        }
        
        //Metodo para mostrar los submenu de cada boton 
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false )
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Mantenimiento
        //..Panel Mantenimiento ****
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //Mostrar subMenu
            showSubMenu(panelMantenimientos);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir Formulario vinculado
            abrirFormulario(new Prueb2());

            //.
            // codigo
            //...
            HideSubMenu();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }
        //FIn Panel Mantenimiento
        #endregion Mantenimientos

        #region Ventas
        // Panel Ventas
        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            //Mostrar subMenu
            showSubMenu(panelVentas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }

        #endregion Ventas
        

        private void btnPrueb3_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }


        //Metodo para abrir los panele dentro de la ventana principal

        private Form activeForm = null;
        private void abrirFormulario( Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();              
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        #region MantenimientoGeneral
        //para panel mantenimiento general

        private void btnPanelGeneral_Click(object sender, EventArgs e)
        {
            //Mostrar subMenu
            showSubMenu(panelTools);
        }

        private void btnMantenimientoMarcas_Click(object sender, EventArgs e)
        {
            //.abriendo Formulario en el panel 
            //abrirFormulario(new MostrarMarcas());
            abrirFormulario(new MostrarMarcas());

            // codigo
            //...
            HideSubMenu();
        }
       

      

        private void button5_Click(object sender, EventArgs e)
        {
            //.
            // codigo
            //...
            HideSubMenu();
        }




        #endregion MantenimientoGeneral

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblDia.Text = DateTime.Now.ToString("dddd MMMM yyyy");
        }

        private void btnMantenimientoCat_Click(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarCategorias());
            HideSubMenu();
        }

        private void btnMantenimientoMarca_Click(object sender, EventArgs e)
        {
            //.abriendo Formulario en el panel 
            //abrirFormulario(new MostrarMarcas());
            abrirFormulario(new MostrarMarcas());

            // codigo
            //...
            HideSubMenu();
        }

        private void btnMantenimientoProveedor_Click(object sender, EventArgs e)
        {

            //abrir formulario MostrarProveedor
            abrirFormulario(new MostrarProveedor());


            // codigo
            //...
            HideSubMenu();
        }

        private void btnMantenimientoProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarProducto());
            //codigo extra
            HideSubMenu();
        }

        private void btnMantenimientoCargo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarTipoEmpleado());
            HideSubMenu();
        }

        private void btnMantenimientoClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarCliente());
            HideSubMenu();
        }

        private void btnMantenimientoProveedor_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarProveedor());
            HideSubMenu();
        }

        private void btnManetenimientoEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new MostrarEmpleado());
            HideSubMenu();
        }
    }
}
