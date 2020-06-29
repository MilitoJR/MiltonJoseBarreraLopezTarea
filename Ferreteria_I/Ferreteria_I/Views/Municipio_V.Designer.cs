namespace Ferreteria_I.Views
{
    partial class Municipio_V
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Municipio_V_btn_del = new System.Windows.Forms.Button();
            this.Municipio_V_btn_edit = new System.Windows.Forms.Button();
            this.Municipio_V_btn_cancel = new System.Windows.Forms.Button();
            this.Municipio_V_btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Municipio_list = new System.Windows.Forms.DataGridView();
            this.idmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombremunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioModBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.Municipio_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioModBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Municipio_V_btn_del
            // 
            this.Municipio_V_btn_del.Location = new System.Drawing.Point(783, 47);
            this.Municipio_V_btn_del.Name = "Municipio_V_btn_del";
            this.Municipio_V_btn_del.Size = new System.Drawing.Size(58, 49);
            this.Municipio_V_btn_del.TabIndex = 14;
            this.Municipio_V_btn_del.Text = "Eliminar";
            this.Municipio_V_btn_del.UseVisualStyleBackColor = true;
            this.Municipio_V_btn_del.Click += new System.EventHandler(this.Municipio_V_btn_del_Click);
            // 
            // Municipio_V_btn_edit
            // 
            this.Municipio_V_btn_edit.Location = new System.Drawing.Point(707, 47);
            this.Municipio_V_btn_edit.Name = "Municipio_V_btn_edit";
            this.Municipio_V_btn_edit.Size = new System.Drawing.Size(58, 49);
            this.Municipio_V_btn_edit.TabIndex = 12;
            this.Municipio_V_btn_edit.Text = "Editar";
            this.Municipio_V_btn_edit.UseVisualStyleBackColor = true;
            this.Municipio_V_btn_edit.Click += new System.EventHandler(this.Dep_V_btn_edit_Click);
            // 
            // Municipio_V_btn_cancel
            // 
            this.Municipio_V_btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Municipio_V_btn_cancel.Location = new System.Drawing.Point(782, 366);
            this.Municipio_V_btn_cancel.Name = "Municipio_V_btn_cancel";
            this.Municipio_V_btn_cancel.Size = new System.Drawing.Size(59, 27);
            this.Municipio_V_btn_cancel.TabIndex = 16;
            this.Municipio_V_btn_cancel.Text = "Cancelar";
            this.Municipio_V_btn_cancel.UseVisualStyleBackColor = true;
            this.Municipio_V_btn_cancel.Click += new System.EventHandler(this.Municipio_V_btn_cancel_Click);
            // 
            // Municipio_V_btn_add
            // 
            this.Municipio_V_btn_add.Location = new System.Drawing.Point(631, 47);
            this.Municipio_V_btn_add.Name = "Municipio_V_btn_add";
            this.Municipio_V_btn_add.Size = new System.Drawing.Size(58, 49);
            this.Municipio_V_btn_add.TabIndex = 11;
            this.Municipio_V_btn_add.Text = "Agregar";
            this.Municipio_V_btn_add.UseVisualStyleBackColor = true;
            this.Municipio_V_btn_add.Click += new System.EventHandler(this.Dep_V_btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar / Editar Municipio";
            // 
            // Municipio_list
            // 
            this.Municipio_list.AllowUserToAddRows = false;
            this.Municipio_list.AllowUserToDeleteRows = false;
            this.Municipio_list.AllowUserToOrderColumns = true;
            this.Municipio_list.AutoGenerateColumns = false;
            this.Municipio_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Municipio_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Municipio_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Municipio_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmunicipioDataGridViewTextBoxColumn,
            this.nombremunicipioDataGridViewTextBoxColumn});
            this.Municipio_list.DataSource = this.municipioModBindingSource;
            this.Municipio_list.Location = new System.Drawing.Point(283, 100);
            this.Municipio_list.Name = "Municipio_list";
            this.Municipio_list.ReadOnly = true;
            this.Municipio_list.RowHeadersVisible = false;
            this.Municipio_list.Size = new System.Drawing.Size(255, 243);
            this.Municipio_list.TabIndex = 15;
            this.Municipio_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Municipio_list_CellContentClick);
            // 
            // idmunicipioDataGridViewTextBoxColumn
            // 
            this.idmunicipioDataGridViewTextBoxColumn.DataPropertyName = "Id_municipio";
            this.idmunicipioDataGridViewTextBoxColumn.HeaderText = "Id_municipio";
            this.idmunicipioDataGridViewTextBoxColumn.Name = "idmunicipioDataGridViewTextBoxColumn";
            this.idmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmunicipioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombremunicipioDataGridViewTextBoxColumn
            // 
            this.nombremunicipioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_municipio";
            this.nombremunicipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.nombremunicipioDataGridViewTextBoxColumn.Name = "nombremunicipioDataGridViewTextBoxColumn";
            this.nombremunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombremunicipioDataGridViewTextBoxColumn.Width = 250;
            // 
            // municipioModBindingSource
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
            this.menuStrip1.Size = new System.Drawing.Size(853, 29);
            this.menuStrip1.TabIndex = 35;
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
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Enabled = false;
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            this.municipioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.municipioToolStripMenuItem.Text = "Municipio";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // Municipio_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 405);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Municipio_V_btn_del);
            this.Controls.Add(this.Municipio_V_btn_edit);
            this.Controls.Add(this.Municipio_V_btn_cancel);
            this.Controls.Add(this.Municipio_V_btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Municipio_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Municipio_V";
            this.ShowIcon = false;
            this.Text = "Municipio";
            this.Load += new System.EventHandler(this.Municipio_V_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Municipio_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioModBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Municipio_V_btn_del;
        private System.Windows.Forms.Button Municipio_V_btn_edit;
        private System.Windows.Forms.Button Municipio_V_btn_cancel;
        private System.Windows.Forms.Button Municipio_V_btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Municipio_list;
        private System.Windows.Forms.BindingSource municipioModBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombremunicipioDataGridViewTextBoxColumn;
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