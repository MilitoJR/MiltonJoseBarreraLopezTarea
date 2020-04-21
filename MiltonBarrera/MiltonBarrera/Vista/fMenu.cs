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

namespace MiltonBarrera.Vista
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void datosDeEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos_estudiante datos = new Datos_estudiante();
            datos.MdiParent = this;
            datos.Show();
        }

        private void mantenimientoDeMaterasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias materia = new materias();
            materia.Show();
        }

        private void notasPorEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas n =new Notas();
            n.Show();
        }
    }
}
