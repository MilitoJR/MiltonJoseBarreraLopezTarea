
using Ferreteria_I.Model;
using MySql.Data.MySqlClient;
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
    public partial class Marca_V_Add : Form
    {
      
        int? id;
        public Marca_V_Add(int? id = null)
        {
            InitializeComponent();
            CenterToScreen();

            this.id = id;
            if (id != null)
            {
                Console.WriteLine(id);

            }
        }


        void CargarCombo()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var proveedor = db.proveedor.ToList();
                combopro.DataSource = proveedor;
                combopro.ValueMember = "id_proveedor";
                combopro.DisplayMember = "nombre_proveedor";
            }

            }

            private void Marca_V_Add_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void Marca_btn_add_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1()) {
                marca marc = new marca();
                String comboproveedor = combopro.SelectedValue.ToString();

                marc.nombre_marca = txtmarca.Text;
                
                db.marca.Add(marc);
                db.SaveChanges();

                CargarCombo(); 
            }
        }

        private void Marca_btn_Add_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
        }

        

    

