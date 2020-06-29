
using Ferreteria_I.Model;
using System;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class MetodoP_V_Add : Form
    {
     
        public int? id;
        public MetodoP_V_Add(int? id = null)
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }
        pago pago = new pago();
        private void CargarDatos()
        {
           
        }
        private void MetodoP_V_Add_Load(object sender, EventArgs e)
        {

        }
        private void mpago_btn_add_Click(object sender, EventArgs e)
        {
                
        }

        private void mpago_btn_Add_cancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpago.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
                using (ferreteriaEntities1 db = new ferreteriaEntities1())
                {
                    pago.metodo_pago = txtpago.Text;
                    db.pago.Add(pago);
                    db.SaveChanges();
                }
                MessageBox.Show("Guardado con exito");

            }
        }
    }
}
