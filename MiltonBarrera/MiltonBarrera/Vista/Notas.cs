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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }
        notas n = new notas();
        void CargarDatos()
        {

            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                var jointablas = from not in db.notas
                                 from mat in db.materia
                                 from est in db.estudiante
                                 where est.id_estudiante == not.id_estudiante && mat.id_materia == not.id_materia

                                 select new
                                 {
                                     Id = not.id_notas,
                                     Nombre = est.nombre_estudiante,
                                     Materia = mat.nombre_materia,
                                     Nota = not.notas1,
                                     IDMat = mat.id_materia,
                                     IDEstud=est.id_estudiante


                                 };
                var iteradatos = db.notas;
                foreach (var iterardatos in jointablas)
                {

                    dtvNota.Rows.Add(iterardatos.Id, iterardatos.Nombre,
                        iterardatos.Materia, iterardatos.Nota, iterardatos.IDEstud, iterardatos.IDMat);

                    
                }

                


            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            String EstudianteId = dtvNota.CurrentRow.Cells[4].Value.ToString();
            String MateriaId = dtvNota.CurrentRow.Cells[5].Value.ToString();
            String Nota = dtvNota.CurrentRow.Cells[3].Value.ToString();
            
            txtEstudiante.Text = EstudianteId;
            txtMateria.Text = MateriaId;
            txtNota.Text = Nota;

            
            
        }
        
        private void Notas_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                n.id_estudiante = Convert.ToInt32(txtEstudiante.Text);
                n.id_materia = Convert.ToInt32(txtMateria.Text);
                n.notas1 = Convert.ToInt32(txtNota.Text);
                db.notas.Add(n);
                db.SaveChanges();
            }
            MessageBox.Show("Guardado con exito");
            CargarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                String id = dtvNota.CurrentRow.Cells[0].Value.ToString();
                n = db.notas.Find(int.Parse(id));
                db.notas.Remove(n);
                db.SaveChanges();
            }
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
               String Id = dtvNota.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                n= db.notas.Where(VerificarID => VerificarID.id_notas == IdC).First();
                n.id_estudiante = Convert.ToInt32(txtEstudiante.Text);
                n.id_materia = Convert.ToInt32(txtMateria.Text);
                n.notas1 = Convert.ToInt32(txtNota.Text);
                db.Entry(n).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
        }
    }
}
