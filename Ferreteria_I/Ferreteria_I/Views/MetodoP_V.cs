
using System;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class MetodoP_V : Form
    {
     
        public MetodoP_V()
        {
            InitializeComponent();
            CenterToScreen();

        }
         void CargarTabla()
        {
            
        }
        private void MPago_V_btn_Save_Click(object sender, EventArgs e)
        {
            MetodoP_V_Add met = new MetodoP_V_Add();
            met.Show();

        }
        private void MPago_V_btn_edit_Click(object sender, EventArgs e)
        {
            
        }
        private void MPago_V_btn_del_Click(object sender, EventArgs e)
        {
            
           
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto_V producto = new Producto_V();
            producto.Show();
            Close();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca_V marca = new Marca_V();
            marca.Show();
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor_V prove = new Proveedor_V();
            prove.Show();
            Close();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_V cat = new Categoria_V();
            cat.Show();
            Close();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion_V prese = new Presentacion_V();
            prese.Show();
            Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_V us = new Usuarios_V();
            us.Show();
            Close();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rol_V rol = new Rol_V();
            rol.Show();
            Close();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta_V venta = new Venta_V();
            venta.Show();
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String metodo = dtgmet.CurrentRow.Cells[1].Value.ToString();
            txtmetodo.Text = metodo;
        }
    }
}
