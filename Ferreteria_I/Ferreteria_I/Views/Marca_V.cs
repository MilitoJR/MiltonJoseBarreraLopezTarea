
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
    public partial class Marca_V : Form
    {
        
        public Marca_V()
        {
            InitializeComponent();
            CenterToScreen();
            CargarTabla();
        }
        marca mar = new marca();
         void CargarTabla()
        {
            using(ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var join = from tbmarca in db.marca
                           from tbprove in db.proveedor
                           
                           where tbmarca.id_proveedor == tbprove.id_proveedor
                       
                           select new
                           {
                               id_marca = tbmarca.id_marca,
                               Nombre = tbmarca.nombre_marca,
                               Proveedor = tbprove.nombre_proveedor

                           };

                dgvMarca.DataSource = join.ToList();
            }
        }
        private void Marca_V_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        private void Marca_V_btn_Save_Click(object sender, EventArgs e)
        {
            Marca_V_Add mar = new Marca_V_Add();
            mar.Show();
        }
        private void Marca_V_btn_edit_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dgvMarca.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                mar = db.marca.Where(VerificarID => VerificarID.id_marca == idC).First();
                mar.nombre_marca = txtmarca.Text;

                db.Entry(mar).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
        }

        private void Marca_V_btn_del_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dgvMarca.CurrentRow.Cells[0].Value.ToString();
                mar = db.marca.Find(int.Parse(id));
                db.marca.Remove(mar);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");
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

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String marca = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = marca;
        }
    }
}
