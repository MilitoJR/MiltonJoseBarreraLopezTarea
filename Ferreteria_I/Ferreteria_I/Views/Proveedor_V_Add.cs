
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
    public partial class Proveedor_V_Add : Form
    {



        void cargarcombo()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var municipio = db.municipio.ToList();
                combomuni.DataSource = municipio;
                combomuni.ValueMember = "id_municipio";
                combomuni.DisplayMember = "nombre_municipio";


                var departamento = db.departamento.ToList();
                combodepa.DataSource = departamento;
                combodepa.ValueMember = "id_departamento";
                combodepa.DisplayMember = "nombre_departamento";
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cargarcombo();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Proveedor_V_Add_Load(object sender, EventArgs e)
        {
           
            }
        private void Usuario_btn_Add_Save_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                proveedor pro = new proveedor();
                String combomarcas = combomuni.SelectedValue.ToString();
                String combopresen = combodepa.SelectedValue.ToString();

                pro.nombre_proveedor = txtprovee.Text;
                pro.nombre_contacto = txtcontacto.Text;
                pro.telefono =Convert.ToInt32( txttelefono.Text);
                db.proveedor.Add(pro);
                db.SaveChanges();

                cargarcombo(); 
            }
            }
        private void CargarDatos()
        {
            
        }
        private void Cargar_departamento()
        {
            
            try
            {

                combodepa.ValueMember = "id_departamento";
                combodepa.DisplayMember = "nombre_departamento";

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar departamento: " + ex);
            }
            finally
            {
               
            }
        }
        private void Cargar_municipio()
        {
            combomuni.DataSource = null;
            combomuni.Items.Clear();
            string sql = "select id_municipio , nombre_municipio from municipio";


            try
            {
                

                combomuni.ValueMember = "id_municipio";
                combomuni.DisplayMember = "nombre_municipio";

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar municipio: " + ex);
            }
            finally
            {

            }
        }
        private void Proveedor_txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingresar un Telefono valido.", "Error");
            }
        }

        private void proveedor_btn_Add_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
