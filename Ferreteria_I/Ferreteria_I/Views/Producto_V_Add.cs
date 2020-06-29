
using Ferreteria_I.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_I.Views;

namespace Ferreteria_I.Views
{
    public partial class Producto_V_Add : Form
    {
        Vista vista = new Vista();
        public int? id;
        public Producto_V_Add(int? id = null)
        {
            InitializeComponent();
            CenterToScreen();


        }
        void CargarCombo()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                var marca = db.marca.ToList();
                combomarca.DataSource = marca;
                combomarca.ValueMember = "id_marca";
                combomarca.DisplayMember = "nombre_marca";


                var presentacion = db.presentacion.ToList();
                combopresentacion.DataSource = presentacion;
                combopresentacion.ValueMember = "id_presentacion";
                combopresentacion.DisplayMember = "nombre_presentacion";

                var categoria = db.categoria.ToList();
                combocategoria.DataSource = categoria;
                combocategoria.ValueMember = "id_categoria";
                combocategoria.DisplayMember = "nombre_categoria";

                var proveedor = db.proveedor.ToList();
                comboproveedor.DataSource = proveedor;
                comboproveedor.ValueMember = "id_proveedor";
                comboproveedor.DisplayMember = "nombre_proveedor";






            }

        }
        private void Producto_V_Add_Load(object sender, EventArgs e)
        {
            
            }

        private void Usuario_btn_Add_Save_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                producto pro = new producto();
                String combomarcas =combomarca.SelectedValue.ToString();
                String combopresen = combopresentacion.SelectedValue.ToString();
                String combocatego = combocategoria.SelectedValue.ToString();
                String comboprov = comboproveedor.SelectedValue.ToString();
                pro.nombre_producto = txtnombre.Text;
                pro.cantidad = Convert.ToInt32(txtcantidad.Text);
                pro.precio_compra =Convert.ToDecimal(txtprecioc.Text);
                pro.precio_venta = Convert.ToDecimal(txtpreciov.Text);
                pro.descripcion = txtdescrip.Text;
                db.producto.Add(pro);
                db.SaveChanges();
               
                CargarCombo();

            }
            
        }
        

       


        private void Prod_txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingresar una Cantidad valida.", "Error");
            }
        }
        private void Prod_txt_pcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Prod_txt_pventa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void Prod_txt_pcompra_Leave(object sender, EventArgs e)
        {
            if (txtprecioc.Text == "")
            {
                txtpreciov.Text = "";

            }
            else
            {
                double PVenta = double.Parse(txtprecioc.Text);
                double PVentaT = (PVenta * 0.4) + PVenta;
                txtpreciov.Text = PVentaT.ToString();
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void Usuario_btn_Add_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {


        }

        private void btn_cat_Click(object sender, EventArgs e)
        {

        }

        private void btn_presentacion_Click(object sender, EventArgs e)
        {

        }

        private void btn_prov_Click(object sender, EventArgs e)
        {

        }
    }
}
