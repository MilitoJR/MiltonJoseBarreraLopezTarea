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
using AppConsole.Vista;

namespace AppConsole
{
    public partial class Loggeo : Form
    {
        public Loggeo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {
                var lista = from usuarios in db.usuario
                            where usuarios.email == txtUsuario.Text
                            && usuarios.contraseña == txtContra.Text
                            select usuarios;


                if (lista.Count() > 0)
                {
                     frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                    MessageBox.Show("El usuario no existe");
            }
        }
    }
}
