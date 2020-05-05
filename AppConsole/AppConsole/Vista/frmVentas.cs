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
                


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(sitema_ventasEntities bd= new sitema_ventasEntities())
            {
                tb_venta tb_v = new tb_venta();
                String comboTipoDoc = cmbTipoDoc.SelectedValue.ToString();
                String comboCliente = cmbClientes.SelectedValue.ToString();
               
                tb_v.idDocumento = int.Parse(comboTipoDoc);
                tb_v.iDCliente = int.Parse(comboCliente);
                tb_v.iDUsuario = 1;

                tb_v.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Text);
                bd.tb_venta.Add(tb_v);
                bd.SaveChanges();

                detalleVenta dete = new detalleVenta();


                

                
                
                    for (int i = 0; i < dtvVentas.RowCount; i++)
                    {
                        String IdProducto = dtvVentas.Rows[i].Cells[0].Value.ToString();
                        int IdProductosConvertidos = Convert.ToInt32(IdProducto);

                        String cantidad = dtvVentas.Rows[i].Cells[3].Value.ToString();
                        int CantidadConvertidos = Convert.ToInt32(cantidad);

                        String precio = dtvVentas.Rows[i].Cells[2].Value.ToString();
                        Decimal precioConvertidos = Convert.ToDecimal(precio);

                        String total = dtvVentas.Rows[i].Cells[4].Value.ToString();
                        Decimal totalConvertidos = Convert.ToDecimal(total);


                        dete.idVenta = int.Parse(txtIDNumeracion.Text);
                        dete.idProducto = IdProductosConvertidos;
                        dete.cantidad = CantidadConvertidos;
                        dete.precio = precioConvertidos;
                        dete.total = totalConvertidos;
                        bd.detalleVenta.Add(dete);
                        bd.SaveChanges();





                    }
                



            }
        }

        private void txtTotalFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
