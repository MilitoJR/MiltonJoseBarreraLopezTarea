
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
using Ferreteria_I.Views;

namespace Ferreteria_I.Views
{
    public partial class Venta_V : Form
    {
        Vista vista = new Vista();
        usuario user = new usuario();
        public Venta_V()
        {
            InitializeComponent();

            CenterToScreen();
        }
        void CargarTabla()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {

            }
        }
  
       
        private void Venta_btn_Click(object sender, EventArgs e)
        {
            string dato = Venta_txt.Text;
            
        }
        private void Venta_V_btn_Save_Click(object sender, EventArgs e)
        {

        }
        private void Venta_V_btn_edit_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = Venta_list.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                user = db.usuario.Where(VerificarID => VerificarID.id_usuario == idC).First();

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        private void Venta_V_btn_del_Click(object sender, EventArgs e)
        {
            
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
  
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
 
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void Venta_V_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
