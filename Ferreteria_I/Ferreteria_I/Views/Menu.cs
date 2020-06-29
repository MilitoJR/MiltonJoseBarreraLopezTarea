using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca_V marca = new Marca_V();
            marca.Show();
            Close();
        }

   

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Producto_V producto = new Producto_V();
            producto.Show();
            Close();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor_V prov = new Proveedor_V();
            prov.Show();
            Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodoP_V met = new MetodoP_V();
            met.Show();
            Close();
        }



        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_V us = new Usuarios_V();
            us.Show();
            Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol_V rol = new Rol_V();
            rol.Show();
            Close();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamento_V depa = new Departamento_V();
            depa.Show();
            Close();
        }
    }
}
