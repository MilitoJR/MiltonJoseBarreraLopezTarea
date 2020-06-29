
using Ferreteria_I.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Categoria_V : Form
    {
        Vista vista = new Vista();
        public Categoria_V()
        {
            InitializeComponent();
            CenterToScreen();
            Cargartabla();
        }
        categoria cate = new categoria();


        void CargarDatos()
        {
            using(ferreteriaEntities1 db = new ferreteriaEntities1())
            {


                var categoria = db.categoria;
                foreach (var iteradatos in categoria)
                {
                    dtvCategoria.Rows.Add(iteradatos.id_categoria, iteradatos.nombre_categoria);
                }


            }
        }
        private void Categoria_V_Load(object sender, EventArgs e)
        {
            dtvCategoria.Refresh();
            dtvCategoria.Rows.Clear();
            CargarDatos();
        }
        private void Cargartabla()
        {
            
        }
        private void Cat_V_btn_add_Click(object sender, EventArgs e)
        {
            Categoria_V_Add cate = new Categoria_V_Add();
            cate.Show();
            
        }
        private void Cat_V_btn_edit_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dtvCategoria.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                cate = db.categoria.Where(VerificarID => VerificarID.id_categoria == idC).First();
                cate.nombre_categoria = txtcategoria.Text;
            
                db.Entry(cate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
               
            }
            CargarDatos();
        }
        private void Cat_V_btn_del_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dtvCategoria.CurrentRow.Cells[0].Value.ToString();
                cate = db.categoria.Find(int.Parse(id));
                db.categoria.Remove(cate);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");
            CargarDatos();


        }
        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Marca_V marca = new Marca_V();
            marca.Show();
            Close();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto_V producto = new Producto_V();
            producto.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String Categoria =dtvCategoria.CurrentRow.Cells[1].Value.ToString();
            txtcategoria.Text = Categoria;
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
        }
    }
}
