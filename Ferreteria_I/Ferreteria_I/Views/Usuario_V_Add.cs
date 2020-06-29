
using Ferreteria_I.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Usuario_V_Add 
    {
        Vista vista = new Vista();
     
        public int? id;
        public Usuario_V_Add(int? id=null)
        {
            InitializeComponent();
            CenterToScreen();
            Cargar_rol();
            Cargar_departamento();
            Cargar_municipio();
            this.id = id;
            if (id!= null)
            {
                CargarDatos();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Usuario_btn_Add_Save_Click(object sender, EventArgs e)
        {
            if (Usuario_txt_Add_Name.Text == "" || Usuario_txt_Add_LastN.Text == "" || Usuario_txt_Add_user.Text == "" || Usuario_txt_Add_pass.Text == "")
            {
                MessageBox.Show("Llenar todos los campos.", "Error");
            }
            else
            {
               
                
            }
        }
        private void Cargar_rol()
        {
            ferreteriaEntities1 db = new ferreteriaEntities1();
            Usuario_cbox_Add_Rol.DataSource = null;
            Usuario_cbox_Add_Rol.Items.Clear();
            string sql = "select id_rol , nombre_rol from rol";
            
            try
            {
               
                DataTable dt = new DataTable();

                Usuario_cbox_Add_Rol.ValueMember = "id_rol";
                Usuario_cbox_Add_Rol.DisplayMember = "nombre_rol";
                Usuario_cbox_Add_Rol.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar rol: "+ex);
            }
            finally
            {
                
            }
        }
        private void Cargar_departamento()
        {
            Usuario_cbox_Add_dep.DataSource = null;
            Usuario_cbox_Add_dep.Items.Clear();
            string sql = "select id_departamento , nombre_departamento from departamento";

            try
            {


                Usuario_cbox_Add_dep.ValueMember = "id_departamento";
                Usuario_cbox_Add_dep.DisplayMember = "nombre_departamento";

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
            Usuario_cbox_Add_Mun.DataSource = null;
            Usuario_cbox_Add_Mun.Items.Clear();
            string sql = "select id_municipio , nombre_municipio from municipio";

            try
            {

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar municipio: " + ex);
            }
            finally
            {
            }
        }
        private void CargarDatos()
        {
            
        }
        private void Usuario_btn_Add_cancel_Click(object sender, EventArgs e)
        {

        }
        private void Usuario_V_Add_Load(object sender, EventArgs e)
        {
            
            }
        private void Usuario_txt_Add_Name_TextChanged(object sender, EventArgs e)
        {

        }
        private void Usuario_txt_Add_LastN_TextChanged(object sender, EventArgs e)
        {

        }
        private void Rol_btn_add_Click(object sender, EventArgs e)
        {
            Rol_V_Add rol_v = new Rol_V_Add();
            rol_v.ShowDialog();
            Cargar_rol();
        }
        private void Usuario_cbox_Add_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Municipio_btn_add_Click(object sender, EventArgs e)
        {
            Municipio_V_Add muni_v = new Municipio_V_Add();
            muni_v.ShowDialog();
            Cargar_municipio();
        }
        private void Departamento_btn_add_Click(object sender, EventArgs e)
        {
            Departamento_V_Add dep_v = new Departamento_V_Add();
            dep_v.ShowDialog();
            Cargar_departamento();
        }
        private void Usuario_txt_Add_tel_TextChanged(object sender, EventArgs e)
        {
        }
        private void Usuario_txt_Add_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void Usuario_txt_Add_tel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }
    }
}
