using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiltonBarrera.Model;


namespace MiltonBarrera.Vista
{
    public partial class Datos_estudiante : Form
    {
        public Datos_estudiante()
        {
            InitializeComponent();
        }
        estudiante estud = new estudiante();

        private void Datos_estudiante_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                estud.nombre_estudiante = txtEstudiante.Text;
                estud.apellido = txtApellido.Text;
                estud.usuario = txtUsuario.Text;
                estud.contraseña = txtContraseña.Text;
                db.estudiante.Add(estud);
                db.SaveChanges();
            }
            MessageBox.Show("Guardado con exito");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActulizarEstudiante act = new ActulizarEstudiante();
            act.Show();
           
                
        }
    }
}
