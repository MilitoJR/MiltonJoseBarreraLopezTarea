using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConsole.Model;

namespace AppConsole.Vista.FormulariosBusqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            filtro();
        }
        void filtro()
        {

            String nombre = txtBuscar.Text;
            using (sitema_ventasEntities bd = new sitema_ventasEntities())
            {
                var jointablas = from tbprod in bd.producto

                                 where tbprod.nombreProducto.Contains(nombre)

                                 select new
                                 {
                                     Id = tbprod.idProducto,
                                     Nombre = tbprod.nombreProducto,
                                     Precio = tbprod.precioProducto
                                 };
                dtvBusqueda.DataSource = jointablas.ToList();
            }

           
        }
      


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            using (sitema_ventasEntities bd = new sitema_ventasEntities())
            {
                filtro();
            }




        }

        private void dtvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }
        void enviar()
        {
            String Id = dtvBusqueda.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvBusqueda.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvBusqueda.CurrentRow.Cells[2].Value.ToString();

            frmMenu.ventas.txtIdProducto.Text = Id;
            frmMenu.ventas.txtNombreProducto.Text = Nombre;
            frmMenu.ventas.txtPrecioProducto.Text = Precio;

            frmMenu.ventas.txtCantidad.Focus();

            this.Close();
        }

        private void dtvBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                enviar();
            }
        }
    }
}
