namespace Ferreteria_I.Views
{
    partial class Producto_V_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Usuario_btn_Add_cancel = new System.Windows.Forms.Button();
            this.Usuario_btn_Add_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combomarca = new System.Windows.Forms.ComboBox();
            this.comboproveedor = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpreciov = new System.Windows.Forms.TextBox();
            this.txtprecioc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.combopresentacion = new System.Windows.Forms.ComboBox();
            this.productoModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoModBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario_btn_Add_cancel
            // 
            this.Usuario_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Usuario_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_btn_Add_cancel.Location = new System.Drawing.Point(1029, 798);
            this.Usuario_btn_Add_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario_btn_Add_cancel.Name = "Usuario_btn_Add_cancel";
            this.Usuario_btn_Add_cancel.Size = new System.Drawing.Size(88, 42);
            this.Usuario_btn_Add_cancel.TabIndex = 15;
            this.Usuario_btn_Add_cancel.Text = "Cerrar";
            this.Usuario_btn_Add_cancel.UseVisualStyleBackColor = true;
            this.Usuario_btn_Add_cancel.Click += new System.EventHandler(this.Usuario_btn_Add_cancel_Click);
            // 
            // Usuario_btn_Add_Save
            // 
            this.Usuario_btn_Add_Save.Location = new System.Drawing.Point(452, 762);
            this.Usuario_btn_Add_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usuario_btn_Add_Save.Name = "Usuario_btn_Add_Save";
            this.Usuario_btn_Add_Save.Size = new System.Drawing.Size(165, 72);
            this.Usuario_btn_Add_Save.TabIndex = 14;
            this.Usuario_btn_Add_Save.Text = "Guardar";
            this.Usuario_btn_Add_Save.UseVisualStyleBackColor = true;
            this.Usuario_btn_Add_Save.Click += new System.EventHandler(this.Usuario_btn_Add_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 631);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 626);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Presentacion";
            // 
            // combomarca
            // 
            this.combomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomarca.FormattingEnabled = true;
            this.combomarca.Location = new System.Drawing.Point(735, 91);
            this.combomarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combomarca.Name = "combomarca";
            this.combomarca.Size = new System.Drawing.Size(226, 37);
            this.combomarca.TabIndex = 1;
            // 
            // comboproveedor
            // 
            this.comboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboproveedor.FormattingEnabled = true;
            this.comboproveedor.Location = new System.Drawing.Point(735, 623);
            this.comboproveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboproveedor.Name = "comboproveedor";
            this.comboproveedor.Size = new System.Drawing.Size(226, 37);
            this.comboproveedor.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(188, 91);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 35);
            this.txtnombre.TabIndex = 0;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(188, 505);
            this.txtdescrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(850, 35);
            this.txtdescrip.TabIndex = 8;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(188, 226);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(302, 35);
            this.txtcantidad.TabIndex = 3;

            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prod_txt_cantidad_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpreciov);
            this.groupBox1.Controls.Add(this.txtprecioc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combocategoria);
            this.groupBox1.Controls.Add(this.combopresentacion);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtdescrip);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.comboproveedor);
            this.groupBox1.Controls.Add(this.combomarca);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1089, 732);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar / Editar Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtpreciov
            // 
            this.txtpreciov.Location = new System.Drawing.Point(738, 368);
            this.txtpreciov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpreciov.Name = "txtpreciov";
            this.txtpreciov.ReadOnly = true;
            this.txtpreciov.Size = new System.Drawing.Size(300, 35);
            this.txtpreciov.TabIndex = 7;
            this.txtpreciov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prod_txt_pventa_KeyPress);
            // 
            // txtprecioc
            // 
            this.txtprecioc.Location = new System.Drawing.Point(190, 368);
            this.txtprecioc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprecioc.Name = "txtprecioc";
            this.txtprecioc.Size = new System.Drawing.Size(300, 35);
            this.txtprecioc.TabIndex = 6;
            this.txtprecioc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prod_txt_pcompra_KeyPress);
            this.txtprecioc.Leave += new System.EventHandler(this.Prod_txt_pcompra_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Precio Venta";
            // 
            // combocategoria
            // 
            this.combocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(188, 625);
            this.combocategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(226, 37);
            this.combocategoria.TabIndex = 9;
            // 
            // combopresentacion
            // 
            this.combopresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopresentacion.FormattingEnabled = true;
            this.combopresentacion.Location = new System.Drawing.Point(735, 226);
            this.combopresentacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combopresentacion.Name = "combopresentacion";
            this.combopresentacion.Size = new System.Drawing.Size(226, 37);
            this.combopresentacion.TabIndex = 4;
            // 
            // Producto_V_Add
            // 
            this.AcceptButton = this.Usuario_btn_Add_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Usuario_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(1136, 858);
            this.Controls.Add(this.Usuario_btn_Add_cancel);
            this.Controls.Add(this.Usuario_btn_Add_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Producto_V_Add";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Producto_V_Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoModBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productoModBindingSource;
        private System.Windows.Forms.Button Usuario_btn_Add_cancel;
        private System.Windows.Forms.Button Usuario_btn_Add_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combomarca;
        private System.Windows.Forms.ComboBox comboproveedor;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpreciov;
        private System.Windows.Forms.TextBox txtprecioc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.ComboBox combopresentacion;
    }
}