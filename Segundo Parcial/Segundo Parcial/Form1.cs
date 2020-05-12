using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Segundo_Parcial.Vistas;
using Segundo_Parcial.Model;

namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario us = new usuario();
            us.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                var lista = from usuario in db.usuarios
                            where usuario.DUI == txtConsultarDUI.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    var nombre = from usuario in db.usuarios
                                 where usuario.DUI == txtConsultarDUI.Text
                                 select new
                                 {
                                     Nombre = usuario.Nombre.ToString()
                                 };
                    foreach (var iterarNomnbre in nombre)
                    {
                        Nombre.Text = iterarNomnbre.Nombre.ToString();

                        Nombre.Visible = true;
                        Beneficiario.Visible = true;
                    }
                }
                else
                {
                    Nombre.Text = "No eres beneficiario";
                    Nombre.Visible = true;
                    Beneficiario.Visible = false;
                }
            }
        }
    }
}
    
