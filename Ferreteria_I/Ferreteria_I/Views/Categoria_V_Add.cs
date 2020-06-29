
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
    public partial class Categoria_V_Add : Form
    {
 
        int? id;
        public Categoria_V_Add(int? id = null)
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            if (id != null)
            {
                cargardatos();
            }
        }
        categoria cat = new categoria();
        private void Categoria_Add_btn_save_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
                using (ferreteriaEntities1 db = new ferreteriaEntities1())
                {
                    cat.nombre_categoria = txtCategoria.Text;
                    db.categoria.Add(cat);
                    db.SaveChanges();
                }
                MessageBox.Show("Guardado con exito");

            }
            
        }
        private void cargardatos()
        {
          
        }

        private void Categoria_Add_btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
