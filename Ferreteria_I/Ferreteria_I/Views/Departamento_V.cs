
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
    public partial class Departamento_V : Form
    {
        
        public Departamento_V()
        {
            InitializeComponent();
            CenterToScreen();
            CargarTabla();
        }
        Vista vista = new Vista();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dep_V_btn_add_Click(object sender, EventArgs e)
        {

        }

        private void Dep_V_btn_edit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(Dep_list.CurrentRow.Cells[0].Value.ToString());
            if (id != null)
            {
                Console.WriteLine(id);
                Departamento_V_Add dep_List = new Departamento_V_Add(id);
                dep_List.Show();
                Close();
            }
        }
        private void CargarTabla()
        {
            
          
        }
        private void Dep_V_btn_del_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Dep_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Departamento_V_Load(object sender, EventArgs e)
        {
            CargarTabla();
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
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
            Municipio_V municipo = new Municipio_V();
            municipo.Show();
            Close();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }
    }
}
