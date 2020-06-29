
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_I.Model;

namespace Ferreteria_I.Views
{
    public partial class Proveedor_V : Form
    {
        Vista vista = new Vista();
        public Proveedor_V()
        {
            InitializeComponent();
            CenterToScreen();

        }
        proveedor prov = new proveedor();

        void CargarTabla()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var join = from tbprove in db.proveedor
                           from tbmuni in db.municipio
                           from tbdepa in db.departamento

                           where tbprove.id_municipio == tbmuni.id_municipio &&
                           tbprove.id_departamento == tbdepa.id_departamento
                           select new
                           {
                               id_proveedor = tbprove.id_proveedor,
                               Nombre_proveedor = tbprove.nombre_proveedor,
                               Departamento = tbdepa.nombre_departamento,
                               Municipio =tbmuni.nombre_municipio

                           };

                dtgprov.DataSource = join.ToList();
            }
        }
        private void Proveedor_V_btn_Save_Click(object sender, EventArgs e)
        {
            Proveedor_V_Add proveed = new Proveedor_V_Add();
            proveed.Show();
        }
        private void Proveedor_V_btn_edit_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dtgprov.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                prov = db.proveedor.Where(VerificarID => VerificarID.id_proveedor == idC).First();
                prov.nombre_proveedor = txtProv.Text;

                db.Entry(prov).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            CargarTabla();
        }
        private void Proveedor_V_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        private void usuario_btn_Click(object sender, EventArgs e)
        {

        }
        private void CargarTabla(string dato)
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

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtgprov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String proveedor = dtgprov.CurrentRow.Cells[1].Value.ToString();
            txtProv.Text = proveedor;
        }

        private void P(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor_V_Add prove = new Proveedor_V_Add();
            prove.Show();
        }

        private void Proveedor_V_btn_del_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dtgprov.CurrentRow.Cells[0].Value.ToString();
                prov = db.proveedor.Find(int.Parse(id));
                db.proveedor.Remove(prov);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");
            CargarTabla();
        }
    }
}
