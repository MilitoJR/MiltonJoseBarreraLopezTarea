
using Ferreteria_I.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Usuarios_V : Form
    {
        Vista vista = new Vista();
        public Usuarios_V()
        {
            InitializeComponent();
            CenterToScreen();
            CargarTabla(null);
        }
        private void CargarTabla(string dato)
        {
           
        }
        private void usuario_btn_Click(object sender, EventArgs e)
        {

        }
        private void Usuarios_V_Load(object sender, EventArgs e)
        {

        }
        private void usuario_btn_Click_1(object sender, EventArgs e)
        {
            string dato = usuario_txt.Text;
            CargarTabla(dato);
        }
        private void Usuario_btn_add_Click(object sender, EventArgs e)
        {
        }
        private void Usuario_btn_edit_Click(object sender, EventArgs e)
        {
            
            
        }
        private void Usuario_btn_del_Click(object sender, EventArgs e)
        {
           
        }
        private void Usuarios_V_Load_1(object sender, EventArgs e)
        {

        }
        private void Usuario_btn_cancel_Click(object sender, EventArgs e)
        {

        }
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto_V prod = new Producto_V();
            prod.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca_V mar = new Marca_V();
            mar.Show();
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor_V pro = new Proveedor_V();
            pro.Show();
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
            Presentacion_V pre = new Presentacion_V();
            pre.Show();
            Close();
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }
    }
}
