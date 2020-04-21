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
    public partial class ActulizarEstudiante : Form
    {
        public ActulizarEstudiante()
        {
            InitializeComponent();
        }
        estudiante estud = new estudiante();
        public override System.Windows.Forms.ContextMenuStrip ContextMenuStrip { get; set; }

        void CargarDatos()
        {

            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {

                dtvAct.DataSource = db.estudiante.ToList();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {


            using (notasEstudiantesEntities db = new notasEstudiantesEntities())
            {
                String id = dtvAct.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(id);
                estud = db.estudiante.Where(VerificarID => VerificarID.id_estudiante == idC).First();

                estud.nombre_estudiante = txtEstudiante.Text;
                estud.apellido = txtApellido.Text;
                estud.usuario = txtUsuario.Text;
                estud.contraseña = txtContraseña.Text;
                db.Entry(estud).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
        }
      
        

        private void ActulizarEstudiante_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                String Estudiante = dtvAct.CurrentRow.Cells[1].Value.ToString();
                String Apellido = dtvAct.CurrentRow.Cells[2].Value.ToString();
                String Usuario = dtvAct.CurrentRow.Cells[3].Value.ToString();
                String Contra = dtvAct.CurrentRow.Cells[4].Value.ToString();
                txtEstudiante.Text = Estudiante;
                txtApellido.Text = Apellido;
                txtUsuario.Text = Usuario;
                txtContraseña.Text = Contra;
            }
            CargarDatos();
        }
    }
}
