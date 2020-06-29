using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_I.Model;

namespace Ferreteria_I.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var lista = from usuarios in db.usuario
                            where usuarios.usuario1 == txtuser.Text
                            && usuarios.clave == txtpass.Text
                            select usuarios;


                if (lista.Count() > 0)
                {
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
        }
    }
}
