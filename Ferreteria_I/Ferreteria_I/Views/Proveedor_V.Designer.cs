﻿namespace Ferreteria_I.Views
{
    partial class Proveedor_V
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
            this.Proveedor_V_btn_del = new System.Windows.Forms.Button();
            this.Proveedor_V_btn_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgprov = new System.Windows.Forms.DataGridView();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprov)).BeginInit();
            this.SuspendLayout();
            // 
            // Proveedor_V_btn_del
            // 
            this.Proveedor_V_btn_del.Location = new System.Drawing.Point(1179, 77);
            this.Proveedor_V_btn_del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Proveedor_V_btn_del.Name = "Proveedor_V_btn_del";
            this.Proveedor_V_btn_del.Size = new System.Drawing.Size(87, 75);
            this.Proveedor_V_btn_del.TabIndex = 2;
            this.Proveedor_V_btn_del.Text = "Eliminar";
            this.Proveedor_V_btn_del.UseVisualStyleBackColor = true;
            this.Proveedor_V_btn_del.Click += new System.EventHandler(this.Proveedor_V_btn_del_Click);
            // 
            // Proveedor_V_btn_edit
            // 
            this.Proveedor_V_btn_edit.Location = new System.Drawing.Point(1065, 77);
            this.Proveedor_V_btn_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Proveedor_V_btn_edit.Name = "Proveedor_V_btn_edit";
            this.Proveedor_V_btn_edit.Size = new System.Drawing.Size(87, 75);
            this.Proveedor_V_btn_edit.TabIndex = 1;
            this.Proveedor_V_btn_edit.Text = "Editar";
            this.Proveedor_V_btn_edit.UseVisualStyleBackColor = true;
            this.Proveedor_V_btn_edit.Click += new System.EventHandler(this.Proveedor_V_btn_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar / Editar Proveedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.presentacionToolStripMenuItem,
            this.metodoDePagoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.direccionToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1284, 40);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productoToolStripMenuItem.Checked = true;
            this.productoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.ShowShortcutKeys = false;
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(137, 36);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Enabled = false;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(167, 36);
            this.presentacionToolStripMenuItem.Text = "Presentacion";
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(211, 36);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de pago";
            this.metodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.metodoDePagoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.rolesToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(308, 40);
            this.rolesToolStripMenuItem.Text = "Lista de usuarioas";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem1
            // 
            this.rolesToolStripMenuItem1.Name = "rolesToolStripMenuItem1";
            this.rolesToolStripMenuItem1.Size = new System.Drawing.Size(308, 40);
            this.rolesToolStripMenuItem1.Text = "Roles";
            this.rolesToolStripMenuItem1.Click += new System.EventHandler(this.rolesToolStripMenuItem1_Click);
            // 
            // direccionToolStripMenuItem
            // 
            this.direccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.municipioToolStripMenuItem});
            this.direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            this.direccionToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.direccionToolStripMenuItem.Text = "Direccion";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            this.municipioToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.municipioToolStripMenuItem.Text = "Municipio";
            this.municipioToolStripMenuItem.Click += new System.EventHandler(this.municipioToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // dtgprov
            // 
            this.dtgprov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgprov.Location = new System.Drawing.Point(12, 260);
            this.dtgprov.Name = "dtgprov";
            this.dtgprov.RowHeadersWidth = 62;
            this.dtgprov.RowTemplate.Height = 28;
            this.dtgprov.Size = new System.Drawing.Size(1272, 395);
            this.dtgprov.TabIndex = 38;
            this.dtgprov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgprov_CellClick);
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(485, 188);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(239, 26);
            this.txtProv.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Proveedor";
            this.label2.TextChanged += new System.EventHandler(this.P);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 75);
            this.button1.TabIndex = 41;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveedor_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.dtgprov);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Proveedor_V_btn_del);
            this.Controls.Add(this.Proveedor_V_btn_edit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Proveedor_V";
            this.ShowIcon = false;
            this.Text = "Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Proveedor_V_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Proveedor_V_btn_del;
        private System.Windows.Forms.Button Proveedor_V_btn_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource proveedorModBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontaxtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem direccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municipioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgprov;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}