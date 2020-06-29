namespace Ferreteria_I.Views
{
    partial class Departamento_V
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dep_V_btn_del = new System.Windows.Forms.Button();
            this.Dep_V_btn_edit = new System.Windows.Forms.Button();
            this.Dep_V_btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dep_list = new System.Windows.Forms.DataGridView();
            this.iddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoModBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioModBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.Dep_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoModBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoModBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dep_V_btn_del
            // 
            this.Dep_V_btn_del.Location = new System.Drawing.Point(786, 40);
            this.Dep_V_btn_del.Name = "Dep_V_btn_del";
            this.Dep_V_btn_del.Size = new System.Drawing.Size(58, 49);
            this.Dep_V_btn_del.TabIndex = 8;
            this.Dep_V_btn_del.Text = "Eliminar";
            this.Dep_V_btn_del.UseVisualStyleBackColor = true;
            this.Dep_V_btn_del.Click += new System.EventHandler(this.Dep_V_btn_del_Click);
            // 
            // Dep_V_btn_edit
            // 
            this.Dep_V_btn_edit.Location = new System.Drawing.Point(710, 40);
            this.Dep_V_btn_edit.Name = "Dep_V_btn_edit";
            this.Dep_V_btn_edit.Size = new System.Drawing.Size(58, 49);
            this.Dep_V_btn_edit.TabIndex = 6;
            this.Dep_V_btn_edit.Text = "Editar";
            this.Dep_V_btn_edit.UseVisualStyleBackColor = true;
            this.Dep_V_btn_edit.Click += new System.EventHandler(this.Dep_V_btn_edit_Click);
            // 
            // Dep_V_btn_add
            // 
            this.Dep_V_btn_add.Location = new System.Drawing.Point(634, 40);
            this.Dep_V_btn_add.Name = "Dep_V_btn_add";
            this.Dep_V_btn_add.Size = new System.Drawing.Size(58, 49);
            this.Dep_V_btn_add.TabIndex = 5;
            this.Dep_V_btn_add.Text = "Agregar";
            this.Dep_V_btn_add.UseVisualStyleBackColor = true;
            this.Dep_V_btn_add.Click += new System.EventHandler(this.Dep_V_btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar / Editar Dep.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dep_list
            // 
            this.Dep_list.AllowUserToAddRows = false;
            this.Dep_list.AllowUserToDeleteRows = false;
            this.Dep_list.AllowUserToOrderColumns = true;
            this.Dep_list.AutoGenerateColumns = false;
            this.Dep_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dep_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dep_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dep_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddepartamentoDataGridViewTextBoxColumn,
            this.nombredepartamentoDataGridViewTextBoxColumn});
            this.Dep_list.DataSource = this.departamentoModBindingSource1;
            this.Dep_list.Location = new System.Drawing.Point(274, 98);
            this.Dep_list.Name = "Dep_list";
            this.Dep_list.ReadOnly = true;
            this.Dep_list.RowHeadersVisible = false;
            this.Dep_list.Size = new System.Drawing.Size(254, 243);
            this.Dep_list.TabIndex = 9;
            this.Dep_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dep_list_CellContentClick);
            // 
            // iddepartamentoDataGridViewTextBoxColumn
            // 
            this.iddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.HeaderText = "Id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.Name = "iddepartamentoDataGridViewTextBoxColumn";
            this.iddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddepartamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombredepartamentoDataGridViewTextBoxColumn
            // 
            this.nombredepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_departamento";
            this.nombredepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.nombredepartamentoDataGridViewTextBoxColumn.Name = "nombredepartamentoDataGridViewTextBoxColumn";
            this.nombredepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombredepartamentoDataGridViewTextBoxColumn.Width = 250;
            // 
            // departamentoModBindingSource1
            // 

            // 
            // departamentoModBindingSource
            // 

            // 
            // usuarioModBindingSource
            // 

            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(856, 29);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productoToolStripMenuItem.Checked = true;
            this.productoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.ShowShortcutKeys = false;
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.presentacionToolStripMenuItem.Text = "Presentacion";
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(136, 25);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de pago";
            this.metodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.metodoDePagoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.rolesToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.rolesToolStripMenuItem.Text = "Lista de usuarioas";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem1
            // 
            this.rolesToolStripMenuItem1.Name = "rolesToolStripMenuItem1";
            this.rolesToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.rolesToolStripMenuItem1.Text = "Roles";
            this.rolesToolStripMenuItem1.Click += new System.EventHandler(this.rolesToolStripMenuItem1_Click);
            // 
            // direccionToolStripMenuItem
            // 
            this.direccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.municipioToolStripMenuItem});
            this.direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            this.direccionToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.direccionToolStripMenuItem.Text = "Direccion";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Enabled = false;
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            this.municipioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.municipioToolStripMenuItem.Text = "Municipio";
            this.municipioToolStripMenuItem.Click += new System.EventHandler(this.municipioToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // Departamento_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 387);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Dep_V_btn_del);
            this.Controls.Add(this.Dep_V_btn_edit);
            this.Controls.Add(this.Dep_V_btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dep_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Departamento_V";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_V_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dep_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoModBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoModBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dep_V_btn_del;
        private System.Windows.Forms.Button Dep_V_btn_edit;
        private System.Windows.Forms.Button Dep_V_btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dep_list;
        private System.Windows.Forms.BindingSource usuarioModBindingSource;
        private System.Windows.Forms.BindingSource departamentoModBindingSource;
        private System.Windows.Forms.BindingSource departamentoModBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredepartamentoDataGridViewTextBoxColumn;
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
    }
}