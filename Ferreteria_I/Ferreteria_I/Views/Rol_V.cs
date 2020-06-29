
using Ferreteria_I.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Rol_V : Form
    {
        Vista vista = new Vista();
        usuario user = new usuario();
        public Rol_V()
        {
            InitializeComponent();
            CenterToScreen();

        }
        void cargardatos()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1()) 
            {
               Rol_list.DataSource = db.rol.ToList();
            }
        }
        private void Rol_V_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
        private void Rol_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Rol_V_btn_Save_Click(object sender, EventArgs e)
        {

        }
        
        private void Rol_V_btn_del_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = Rol_list.CurrentRow.Cells[0].Value.ToString();
                user = db.usuario.Find(int.Parse(id));
                db.usuario.Remove(user);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");


        }
      
        private void Usuario_V_btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void Rol_V_btn_edit_Click_1(object sender, EventArgs e)
        {

            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            { String id = Rol_list.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                user = db.usuario.Where(VerificarID => VerificarID.id_rol == idC).First();
                user.nombre = txtrol.Text;
               
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
        }

        private void Rol_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Rol = Rol_list.CurrentRow.Cells[1].Value.ToString();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            MetodoP_V met = new MetodoP_V();
            met.Show();
            Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_V usu = new Usuarios_V();
            usu.Show();
            Close();
        }

        private void productoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Producto_V prod = new Producto_V();
            prod.Show();
        }

        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Marca_V mar = new Marca_V();
            mar.Show();
            Close();
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Proveedor_V pro = new Proveedor_V();
            pro.Show();
            Close();
        }

        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Categoria_V cat = new Categoria_V();
            cat.Show();
            Close();
        }

        private void presentacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Presentacion_V pre = new Presentacion_V();
            pre.Show();
            Close();
        }

        private void metodoDePagoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MetodoP_V met = new MetodoP_V();
            met.Show();
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
