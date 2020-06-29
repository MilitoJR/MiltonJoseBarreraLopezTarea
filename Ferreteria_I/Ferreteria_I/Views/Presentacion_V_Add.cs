
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
    public partial class Presentacion_V_Add : Form
    {
        Vista vista = new Vista();
        int? id;
        public Presentacion_V_Add(int? id=null)
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }
        private void Presentacion_V_Add_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            
        }
        private void Presentacion_Add_btn_save_Click(object sender, EventArgs e)
        {
            if (Presentacion_Add_txt_nombre.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
      
            
        }

        private void Presentacion_Add_btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
