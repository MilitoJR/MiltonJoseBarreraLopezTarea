
using System;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Municipio_V : Form
    {
 
        public Municipio_V()
        {
            InitializeComponent();
            CenterToScreen();
            CargarTabla();
        }

        private void Dep_V_btn_add_Click(object sender, EventArgs e)
        {

        }

        private void Dep_V_btn_edit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(Municipio_list.CurrentRow.Cells[0].Value.ToString());
            if (id != null)
            {
                Console.WriteLine(id);
                Municipio_V_Add muni_List = new Municipio_V_Add(id);
                muni_List.Show();
                Close();
            }
        }
        private void CargarTabla()
        {
            
        }
        private void Municipio_V_btn_del_Click(object sender, EventArgs e)
        {
           
        }

        private void Municipio_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Municipio_V_Load(object sender, EventArgs e)
        {

        }

        private void Municipio_V_btn_cancel_Click(object sender, EventArgs e)
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

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
