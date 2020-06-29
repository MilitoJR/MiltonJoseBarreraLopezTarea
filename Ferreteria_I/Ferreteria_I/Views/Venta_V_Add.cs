
using Ferreteria_I.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Venta_V_Add : Form
    {
        Vista vista = new Vista();
        int? id;
        public Venta_V_Add(int? id = null)
        {
            InitializeComponent();
            CenterToScreen();


        }
        void CargarCombo()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var pagos = db.pago.ToList();
                cmbpago.DataSource = pagos;
                cmbpago.ValueMember = "id_pago";
                cmbpago.DisplayMember = "metodo_pago";




            }

        }



        void Calculo()
        {
            try
            {

                Double precio;
                Double cantidad;
                Double total;

                precio = Double.Parse(txtprecio.Text);
                cantidad = Convert.ToDouble(txtcantidad.Text);

                total = cantidad * precio;

                txttotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                txtcantidad.Text = "0";
                txtcantidad.Select();
            }
        }
       

        private void Venta_btn_Save_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 bd = new ferreteriaEntities1())
            {
                venta tb_venta = new venta();
                String combopago = cmbpago.SelectedValue.ToString();
               
                tb_venta.cantidad_venta =Convert.ToInt32( txtcantidad.Text);
                bd.venta.Add(tb_venta);
                bd.SaveChanges();

                CargarCombo();
                Calculo();
            }
            }


        private void txttotal_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txttotal.Text);
            Calculo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void cmbpago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
       


    
           
