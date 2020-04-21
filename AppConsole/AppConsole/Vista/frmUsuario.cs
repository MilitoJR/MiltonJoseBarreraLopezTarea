using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConsole.Model;


namespace AppConsole.Vista
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        usuario user = new usuario();
        void LimpiarDatos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        void CargarDatos() {

            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {



                //var usuarios = db.usuario;
                //foreach (var iteradatosUsuario in usuarios )
                //{
                //    dtvUsuario.Rows.Add(iteradatosUsuario.email,iteradatosUsuario.contraseña);
                //}



                dtvUsuario.DataSource = db.usuario.ToList();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {
                user.email = txtUsuario.Text;
                user.contraseña = txtContraseña.Text;
                db.usuario.Add(user);
                db.SaveChanges();
            }
            MessageBox.Show("Guardado con exito");
            CargarDatos();
            LimpiarDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {
                String id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
                user = db.usuario.Find(int.Parse(id));
                db.usuario.Remove(user);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");
            CargarDatos();
            LimpiarDatos();
        }

        private void dtvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dtvUsuario.CurrentRow.Cells[1].Value.ToString();
            String Contra = dtvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = Email;
            txtContraseña.Text = Contra;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {
                String id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                user = db.usuario.Where(VerificarID => VerificarID.id == idC).First();
                user.email = txtUsuario.Text;
                user.contraseña = txtContraseña.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
