namespace AppConsole.Vista.FormulariosBusqueda
{
    partial class frmBusqueda
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
            this.dtvBusqueda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvBusqueda
            // 
            this.dtvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvBusqueda.Location = new System.Drawing.Point(0, 169);
            this.dtvBusqueda.Name = "dtvBusqueda";
            this.dtvBusqueda.RowHeadersWidth = 62;
            this.dtvBusqueda.RowTemplate.Height = 28;
            this.dtvBusqueda.Size = new System.Drawing.Size(947, 324);
            this.dtvBusqueda.TabIndex = 0;
            this.dtvBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvBusqueda_CellDoubleClick);
            this.dtvBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtvBusqueda_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(337, 91);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(468, 26);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 553);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvBusqueda);
            this.Name = "frmBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}