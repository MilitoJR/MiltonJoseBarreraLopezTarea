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
using MiltonBarrera.Vista;

namespace MiltonBarrera
{
    public partial class Loggeo : Form
    {
        public Loggeo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var lista = from usuarios in db.estudiante
                            where usuarios.usuario == txtUsuario.Text
                            && usuarios.contraseña == txtContraseña.Text
                            select usuarios;


                if (lista.Count() > 0)
                {
                    fMenu menu = new fMenu();
                    menu.Show();
                }
                else
                    MessageBox.Show("El usuario no existe");
            }
        }
    }
}
