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


                txtIDNumeracion.Text = "1";
                var tb_v = db.tb_venta;
                foreach (var iteradatosVenta in tb_v)
                {
                    int idventa = iteradatosVenta.idVenta;
                    int suma = idventa + 1;
                    txtIDNumeracion.Text = suma.ToString();
                    
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
                txtCantidad.Select();
                


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (sitema_ventasEntities bd = new sitema_ventasEntities())
            {
                tb_venta tb_venta = new tb_venta();
                String comboTipoDoc = cmbTipoDoc.SelectedValue.ToString();
                String comboCliente = cmbClientes.SelectedValue.ToString();

                tb_venta.idDocumento = int.Parse(comboTipoDoc);
                tb_venta.iDCliente = int.Parse(comboCliente);
                tb_venta.iDUsuario = 1;

                tb_venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                tb_venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                bd.tb_venta.Add(tb_venta);
                bd.SaveChanges();

                detalleVenta dete = new detalleVenta();

                for (int i = 0; i < dtvVentas.RowCount; i++)
                {
                    String IdProducto = dtvVentas.Rows[i].Cells[0].Value.ToString();
                    int ProductosConvertidos = Convert.ToInt32(IdProducto);

                    String cantidad = dtvVentas.Rows[i].Cells[3].Value.ToString();
                    int cantidadConvertida = Convert.ToInt32(cantidad);

                    
                    String precio= dtvVentas.Rows[i].Cells[2].Value.ToString();
                    Decimal PrecioConvertido = Convert.ToDecimal(precio);

                    String total = dtvVentas.Rows[i].Cells[4].Value.ToString();
                    Decimal TotalConvertido = Convert.ToDecimal(total);




                    dete.idVenta = Convert.ToInt32(txtIDNumeracion.Text);
                    dete.idProducto = ProductosConvertidos;
                    dete.cantidad = cantidadConvertida;
                    dete.precio = PrecioConvertido;
                    dete.total = TotalConvertido;
                    bd.detalleVenta.Add(dete);
                    bd.SaveChanges();
                }










            
            }
            retornoid();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtBusqueda.Text=="")
            {
                if (e.KeyCode==Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (sitema_ventasEntities bd = new sitema_ventasEntities())
                {
                    producto pr = new producto();
                    int buscar = int.Parse(txtBusqueda.Text);
                    pr = bd.producto.Where(idBuscar => idBuscar.idProducto == buscar).First();
                    txtIdProducto.Text = Convert.ToString(pr.idProducto);
                    txtNombreProducto.Text = Convert.ToString(pr.nombreProducto);
                    txtPrecioProducto.Text = Convert.ToString(pr.precioProducto);
                    txtCantidad.Focus();
                    txtBusqueda.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Calculo();
            }
            catch (Exception ex)
            {

            }
            dtvVentas.Rows.Add(txtIdProducto.Text, txtNombreProducto.Text, txtPrecioProducto.Text, txtCantidad.Text, txtTotal.Text);
            Double suma = 0;
            for (int i = 0; i < dtvVentas.RowCount; i++)
            {
                String datosAOperar = dtvVentas.Rows[i].Cells[4].Value.ToString();
                Double datosConvertidos = Double.Parse(datosAOperar);


                suma += datosConvertidos;

                txtTotalFinal.Text = suma.ToString();

            }
        }
        int intentos = 1;
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (intentos==2) {
                    btnAgregar.PerformClick();
                    txtBusqueda.Focus();
                    txtIdProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecioProducto.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtBusqueda.Focus();
                }
                intentos += 1;

            }

        }

    }
}


      

            
            
    

