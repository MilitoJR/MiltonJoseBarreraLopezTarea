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

namespace AppConsole.Vista
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            using (sitema_ventasEntities bd= new sitema_ventasEntities())
            {
                var jointablas = from tbusu in bd.usuario
                                 from rolesuser in bd.roles_usuario
                                 where tbusu.id == rolesuser.id_Rol_usuario

                                 select new
                                 {
                                     Id = tbusu.id,
                                     email = tbusu.email,
                                     tiporol = rolesuser.tipo_rol
                                 };
                dtVistaRoles.DataSource = jointablas.ToList();
            }
        }
    }
}
