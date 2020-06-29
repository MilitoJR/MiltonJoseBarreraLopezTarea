namespace Ferreteria_I.Views
{
    partial class Usuarios_V
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_V));
            this.usuario_list = new System.Windows.Forms.DataGridView();
            this.dtgusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuario_btn = new System.Windows.Forms.Button();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.Usuario_btn_add = new System.Windows.Forms.Button();
            this.Usuario_btn_edit = new System.Windows.Forms.Button();
            this.Usuario_btn_del = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.usuario_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuario_list
            // 
            this.usuario_list.AllowUserToAddRows = false;
            this.usuario_list.AllowUserToDeleteRows = false;
            this.usuario_list.AllowUserToOrderColumns = true;
            this.usuario_list.AllowUserToResizeRows = false;
            this.usuario_list.AutoGenerateColumns = false;
            this.usuario_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.usuario_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usuario_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usuario_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuario_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuario_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuario_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgusuario});
            this.usuario_list.DataSource = this.usuarioModBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuario_list.GridColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.usuario_list, "usuario_list");
            this.usuario_list.MultiSelect = false;
            this.usuario_list.Name = "usuario_list";
            this.usuario_list.ReadOnly = true;
            this.usuario_list.RowHeadersVisible = false;
            this.usuario_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuario_list.StandardTab = true;
            // 
            // dtgusuario
            // 
            this.dtgusuario.DataPropertyName = "Id_usuario";
            resources.ApplyResources(this.dtgusuario, "dtgusuario");
            this.dtgusuario.Name = "dtgusuario";
            this.dtgusuario.ReadOnly = true;
            // 
            // usuario_btn
            // 
            resources.ApplyResources(this.usuario_btn, "usuario_btn");
            this.usuario_btn.Name = "usuario_btn";
            this.usuario_btn.UseVisualStyleBackColor = true;
            this.usuario_btn.Click += new System.EventHandler(this.usuario_btn_Click_1);
            // 
            // usuario_txt
            // 
            resources.ApplyResources(this.usuario_txt, "usuario_txt");
            this.usuario_txt.Name = "usuario_txt";
            // 
            // Usuario_btn_add
            // 
            resources.ApplyResources(this.Usuario_btn_add, "Usuario_btn_add");
            this.Usuario_btn_add.Name = "Usuario_btn_add";
            this.Usuario_btn_add.UseVisualStyleBackColor = true;
            this.Usuario_btn_add.Click += new System.EventHandler(this.Usuario_btn_add_Click);
            // 
            // Usuario_btn_edit
            // 
            resources.ApplyResources(this.Usuario_btn_edit, "Usuario_btn_edit");
            this.Usuario_btn_edit.Name = "Usuario_btn_edit";
            this.Usuario_btn_edit.UseVisualStyleBackColor = true;
            this.Usuario_btn_edit.Click += new System.EventHandler(this.Usuario_btn_edit_Click);
            // 
            // Usuario_btn_del
            // 
            resources.ApplyResources(this.Usuario_btn_del, "Usuario_btn_del");
            this.Usuario_btn_del.Name = "Usuario_btn_del";
            this.Usuario_btn_del.UseVisualStyleBackColor = true;
            this.Usuario_btn_del.Click += new System.EventHandler(this.Usuario_btn_del_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productoToolStripMenuItem.Checked = true;
            this.productoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            resources.ApplyResources(this.productoToolStripMenuItem, "productoToolStripMenuItem");
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            resources.ApplyResources(this.marcasToolStripMenuItem, "marcasToolStripMenuItem");
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            resources.ApplyResources(this.proveedoresToolStripMenuItem, "proveedoresToolStripMenuItem");
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            resources.ApplyResources(this.categoriaToolStripMenuItem, "categoriaToolStripMenuItem");
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            resources.ApplyResources(this.presentacionToolStripMenuItem, "presentacionToolStripMenuItem");
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            resources.ApplyResources(this.metodoDePagoToolStripMenuItem, "metodoDePagoToolStripMenuItem");
            this.metodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.metodoDePagoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.rolesToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            // 
            // rolesToolStripMenuItem
            // 
            resources.ApplyResources(this.rolesToolStripMenuItem, "rolesToolStripMenuItem");
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            // 
            // rolesToolStripMenuItem1
            // 
            this.rolesToolStripMenuItem1.Name = "rolesToolStripMenuItem1";
            resources.ApplyResources(this.rolesToolStripMenuItem1, "rolesToolStripMenuItem1");
            this.rolesToolStripMenuItem1.Click += new System.EventHandler(this.rolesToolStripMenuItem1_Click);
            // 
            // direccionToolStripMenuItem
            // 
            this.direccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.municipioToolStripMenuItem});
            this.direccionToolStripMenuItem.Name = "direccionToolStripMenuItem";
            resources.ApplyResources(this.direccionToolStripMenuItem, "direccionToolStripMenuItem");
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            resources.ApplyResources(this.departamentoToolStripMenuItem, "departamentoToolStripMenuItem");
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            resources.ApplyResources(this.municipioToolStripMenuItem, "municipioToolStripMenuItem");
            this.municipioToolStripMenuItem.Click += new System.EventHandler(this.municipioToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            resources.ApplyResources(this.ventaToolStripMenuItem, "ventaToolStripMenuItem");
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // Usuarios_V
            // 
            this.AcceptButton = this.usuario_btn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Usuario_btn_del);
            this.Controls.Add(this.Usuario_btn_edit);
            this.Controls.Add(this.Usuario_btn_add);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.usuario_btn);
            this.Controls.Add(this.usuario_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Usuarios_V";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Usuarios_V_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.usuario_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuarioModBindingSource;
        private System.Windows.Forms.Button usuario_btn;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.DataGridView usuario_list;
        private System.Windows.Forms.Button Usuario_btn_add;
        private System.Windows.Forms.Button Usuario_btn_edit;
        private System.Windows.Forms.Button Usuario_btn_del;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    }
}