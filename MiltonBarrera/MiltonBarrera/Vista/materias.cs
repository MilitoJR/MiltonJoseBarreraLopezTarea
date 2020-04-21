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
    public partial class materias : Form
    {
        public materias()
        {
            InitializeComponent();
        }
        materia mate = new materia();

        void CargarDatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {

                dtvMat.DataSource = db.materia.ToList();

                
            }
        }
private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                
                mate.nombre_materia = txtNombreMat.Text;
                db.materia.Add(mate);
                db.SaveChanges();
            }
            MessageBox.Show("Guardado con exito");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
             
                String Materia = dtvMat.CurrentRow.Cells[2].Value.ToString();
                
                txtNombreMat.Text = Materia;
            }
            CargarDatos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                String id = dtvMat.CurrentRow.Cells[1].Value.ToString();
                int idC = int.Parse(id);
                mate = db.materia.Where(VerificarID => VerificarID.id_materia == idC).First();

                
                mate.nombre_materia = txtNombreMat.Text;
             
                db.Entry(mate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
        }

        private void materias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
