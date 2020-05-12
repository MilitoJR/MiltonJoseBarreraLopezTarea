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
    public partial class DUI : Form
    {
        public DUI()
        {
            InitializeComponent();
        }

        void limpiardatos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDUI.Text = "";
        }
        void cargardatos()
        {
            dtvDui.Rows.Clear();
            using (gobEntities db = new gobEntities())
            {
                var tb_Usuarios = db.usuarios;
                foreach (var iterardatostbUsuario in tb_Usuarios)
                {
                    dtvDui.Rows.Add(iterardatostbUsuario.id, iterardatostbUsuario.Nombre, iterardatostbUsuario.DUI);
                }

            }
        }
        usuarios user = new usuarios();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;
                db.usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                string Id = dtvDui.CurrentRow.Cells[0].Value.ToString();

                user = db.usuarios.Find(int.Parse(Id));
                db.usuarios.Remove(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                string Id = dtvDui.CurrentRow.Cells[0].Value.ToString();
                int IdC =Convert.ToInt32(Id);
                user = db.usuarios.Where(VerificarId => VerificarId.id == IdC).First();
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void dtvDui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtvDui.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvDui.CurrentRow.Cells[1].Value.ToString();
            String DUI = dtvDui.CurrentRow.Cells[2].Value.ToString();
            txtId.Text = Id;
            txtNombre.Text = Nombre;
            txtDUI.Text = DUI;

            cargardatos();
        }

        private void DUI_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
