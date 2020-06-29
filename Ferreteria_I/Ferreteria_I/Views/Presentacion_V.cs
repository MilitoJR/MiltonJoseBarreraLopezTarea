
using Ferreteria_I.Model;
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
    public partial class Presentacion_V : Form
    {
        Vista vista = new Vista();
        public Presentacion_V()
        {
            InitializeComponent();
            CenterToScreen();
            CargarTabla();
        }
     void CargarTabla()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {


                var presentacion = db.presentacion;
                foreach (var iteradatos in presentacion)
                {
                    dtgpresentacion.Rows.Add(iteradatos.id_presentacion, iteradatos.nombre_presentacion);
                }


            }
        }

        private void Presentacion_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Presentacion_V_btn_add_Click(object sender, EventArgs e)
        {

        }
        private void Presentacion_V_btn_edit_Click(object sender, EventArgs e)
        {
            
           
            
        }
        private void Presentacion_V_btn_del_Click(object sender, EventArgs e)
        {
           
        }

        private void Presentacion_V_Load(object sender, EventArgs e)
        {
            CargarTabla();
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

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodoP_V met = new MetodoP_V();
            met.Show();
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

        }
    }
}
