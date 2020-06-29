
using Ferreteria_I.Model;
using System;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Departamento_V_Add : Form
    {
       
        public int? id;
        Vista vista = new Vista();
        public Departamento_V_Add(int? id = null)
            
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            if (id != null)
            {
                Console.WriteLine(id);
                CargarDatos();
            }
            else
            {
                Console.WriteLine("No hay id");
            }
        }
        private void Usuario_btn_Add_cancel_Click(object sender, EventArgs e)
        {

        }
        private void Departamento_btn_add_Click(object sender, EventArgs e)
        {
            if (Departamento_txt_name.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
                
            }
        }
        private void CargarDatos()
        {
           

        }
        private void Departamento_txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void Departamento_V_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
