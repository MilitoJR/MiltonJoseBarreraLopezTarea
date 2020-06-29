
using Ferreteria_I.Model;
using System;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Municipio_V_Add : Form
    {
        Vista vista = new Vista();
        public int? id;
        public Municipio_V_Add(int? id = null)
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
        private void CargarDatos()
        {
           
        }
        private void Municipio_V_Add_Load(object sender, EventArgs e)
        {
        }
        private void Municipio_btn_Add_Click(object sender, EventArgs e)
        {
            if (Municipio_txt_name.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
                
            }       
        }
        private void Municipio_btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}