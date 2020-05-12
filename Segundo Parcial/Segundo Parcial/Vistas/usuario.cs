using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Segundo_Parcial.Model;
using Segundo_Parcial.Vistas;

namespace Segundo_Parcial.Vistas
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }
      

        private void usuario_Load(object sender, EventArgs e)
        {

;        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            using(gobEntities db = new gobEntities())
            {
                var lista = from usuarios in db.usuarios
                            where "master" == txtUsuario.Text
                            && "123" == txtContraseña.Text
                            select usuarios;


                if (lista.Count() > 0)
                {
                    DUI dui = new DUI();
                    dui.Show();
                }
                else
                    MessageBox.Show("El usuario no existe");
            }
        }
        }
    
}
