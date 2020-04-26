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
using AppConsole.Vista.FormulariosBusqueda;

namespace AppConsole.Vista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarCombo();
            retornoid();
        }
        void retornoid()
        {
            using (sitema_ventasEntities db = new sitema_ventasEntities())
            {



                var tb_v = db.tb_venta;
                foreach (var iteradatosVenta in tb_v)
                {
                    txtIDNumeracion.Text = iteradatosVenta.idVenta.ToString();
                    
                    //dtvUsuario.Rows.Add(iteradatosUsuario.email, iteradatosUsuario.contraseña);
                }




            }

        }
        void CargarCombo()
        {
            using(sitema_ventasEntities db = new sitema_ventasEntities())
            {
                var clientes = db.tb_cliente.ToList();
                cmbClientes.DataSource = clientes;
                cmbClientes.DisplayMember = "nombreCliente";
                cmbClientes.ValueMember =  "iDCliente";



                var tipoDoc = db.tb_documento.ToList();
                cmbTipoDoc.DataSource = tipoDoc;
                cmbTipoDoc.DisplayMember = "nombreDocumento";
                cmbTipoDoc.ValueMember = "iDDocumento";
            }
            
        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            
            busqueda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dtvVentas.Rows.Add(txtIDNumeracion.Text,txtNombreProducto.Text,txtPrecioProducto.Text,txtCantidad.Text,txtTotal.Text);

            try
            {
                Calculo();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calculo();
            
        }
        void Calculo()
        {
            try
            {

                Double precio;
                Double cantidad;
                Double total;

                precio = Double.Parse(txtPrecioProducto.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);

                total = cantidad * precio;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                txtCantidad.Text = "0";
                MessageBox.Show("No puedes operar datos menores que 0");
                txtCantidad.Select();


            }
        }
    }
}
