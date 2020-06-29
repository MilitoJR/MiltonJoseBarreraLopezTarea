
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
    public partial class Rol_V_Add : Form
    {
        Vista vista = new Vista();
        usuario user = new usuario();
        public int? id;
        public Rol_V_Add(int? id=null)
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            if (id != null)
            {
                
            }
        }
        private void Rol_V_Add_Load(object sender, EventArgs e) { }
        private void Usuario_btn_Add_Save_Click(object sender, EventArgs e)
        {

        }
        private void Rol_btn_add_Click(object sender, EventArgs e)
        {
            if (Rol_txt_name.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
                using (ferreteriaEntities1 db = new ferreteriaEntities1())
                {
                    user.nombre = Rol_txt_name.Text;

                    db.usuario.Add(user);
                    db.SaveChanges();
                }
                MessageBox.Show("Guardado con exito");


            }
        }
        private void Usuario_btn_Add_cancel_Click(object sender, EventArgs e)
        {

        }
    
        private void Rol_txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
