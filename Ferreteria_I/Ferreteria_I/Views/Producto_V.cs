
using Ferreteria_I.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    public partial class Producto_V : Form
    {
        Vista vista = new Vista();
        public Producto_V()
        {
            InitializeComponent();
           
         
        }
        producto pro = new producto();
        void CargarDatos()
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {

                {
                    var join = from tbpro in db.producto
                                     from tbmarca in db.marca
                                     from tbcat in db.categoria
                                     from tbprove in db.proveedor
                                     where tbpro.id_marca == tbmarca.id_marca
                                     && tbpro.id_categoria == tbcat.id_categoria
                                     && tbpro.id_proveedor == tbprove.id_proveedor
                                     select new
                                     {
                                         id_producto = tbpro.id_producto,
                                         Nombre = tbpro.nombre_producto,
                                         Marca = tbmarca.nombre_marca,
                                         Catidad=tbpro.cantidad,
                                         Descripcion=tbpro.descripcion,
                                         precio_compra=tbpro.precio_compra,
                                         precio_venta= tbpro.precio_venta,
                                         Categoria = tbcat.nombre_categoria,
                                         Proveedor = tbprove.nombre_proveedor
                                     };

                    dtvProducto.DataSource = join.ToList();
                    
                    //dtvProductos.Rows.Add(iteradatos.id_producto, iteradatos.nombre_producto, iteradatos.id_marca, iteradatos.cantidad, iteradatos.descripcion, iteradatos.precio_compra, iteradatos.precio_venta, iteradatos.id_categoria, iteradatos.id_proveedor);
                }
            } 
        }
        private void Producto_btn_Click(object sender, EventArgs e)
        {
        }
        private void CargarDatos(string datos)
        {
           
        }
        private void Producto_V_Load(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                CargarDatos();

              
            }


                
        }
        private void Producto_V_btn_Save_Click(object sender, EventArgs e)
        {
            Producto_V_Add pro = new Producto_V_Add();
            pro.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Producto_V_Shown(object sender, EventArgs e)
        {

        }
        private void Producto_V_Activated(object sender, EventArgs e)
        {

        }
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_V cat = new Categoria_V();
            cat.Show();
            Close();
        }


        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_V us = new Usuarios_V();
            us.Show();
            Close();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca_V marca =new Marca_V();
            marca.Show();
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor_V prove = new Proveedor_V();
            prove.Show();
            Close();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rol_V rol = new Rol_V();
            rol.Show();
            Close();

        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion_V prese = new Presentacion_V();
            prese.Show();
            Close();
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodoP_V met = new MetodoP_V();
            met.Show();
            Close();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_venta_Click(object sender, EventArgs e)
        {

        }


        private void btnventa_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Producto_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Producto_V_btn_del_Click(object sender, EventArgs e)
        {
            using (ferreteriaEntities1 db = new ferreteriaEntities1())
            {
                String id = dtvProducto.CurrentRow.Cells[0].Value.ToString();
                pro = db.producto.Find(int.Parse(id));
                db.producto.Remove(pro);
                db.SaveChanges();
            }
            MessageBox.Show("Eliminado con exito");
            CargarDatos();
        }
    }
}
