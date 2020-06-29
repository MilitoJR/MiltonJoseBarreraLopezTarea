namespace Ferreteria_I.Views
{
    partial class Categoria_V_Add
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
            this.Categoria_Add_btn_cancel = new System.Windows.Forms.Button();
            this.Categoria_Add_btn_save = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.Categoria_Add_lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Categoria_Add_btn_cancel
            // 
            this.Categoria_Add_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Categoria_Add_btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria_Add_btn_cancel.Location = new System.Drawing.Point(304, 288);
            this.Categoria_Add_btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Categoria_Add_btn_cancel.Name = "Categoria_Add_btn_cancel";
            this.Categoria_Add_btn_cancel.Size = new System.Drawing.Size(88, 42);
            this.Categoria_Add_btn_cancel.TabIndex = 17;
            this.Categoria_Add_btn_cancel.Text = "Cancelar";
            this.Categoria_Add_btn_cancel.UseVisualStyleBackColor = true;
            this.Categoria_Add_btn_cancel.Click += new System.EventHandler(this.Categoria_Add_btn_cancel_Click);
            // 
            // Categoria_Add_btn_save
            // 
            this.Categoria_Add_btn_save.Location = new System.Drawing.Point(146, 157);
            this.Categoria_Add_btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Categoria_Add_btn_save.Name = "Categoria_Add_btn_save";
            this.Categoria_Add_btn_save.Size = new System.Drawing.Size(165, 75);
            this.Categoria_Add_btn_save.TabIndex = 16;
            this.Categoria_Add_btn_save.Text = "Guardar";
            this.Categoria_Add_btn_save.UseVisualStyleBackColor = true;
            this.Categoria_Add_btn_save.Click += new System.EventHandler(this.Categoria_Add_btn_save_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(104, 63);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(253, 26);
            this.txtCategoria.TabIndex = 15;
            // 
            // Categoria_Add_lbl_name
            // 
            this.Categoria_Add_lbl_name.AutoSize = true;
            this.Categoria_Add_lbl_name.Location = new System.Drawing.Point(26, 68);
            this.Categoria_Add_lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria_Add_lbl_name.Name = "Categoria_Add_lbl_name";
            this.Categoria_Add_lbl_name.Size = new System.Drawing.Size(78, 20);
            this.Categoria_Add_lbl_name.TabIndex = 14;
            this.Categoria_Add_lbl_name.Text = "Categoria";
            // 
            // Categoria_V_Add
            // 
            this.AcceptButton = this.Categoria_Add_btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Categoria_Add_btn_cancel;
            this.ClientSize = new System.Drawing.Size(411, 348);
            this.Controls.Add(this.Categoria_Add_btn_cancel);
            this.Controls.Add(this.Categoria_Add_btn_save);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.Categoria_Add_lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Categoria_V_Add";
            this.Text = "Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Categoria_Add_btn_cancel;
        private System.Windows.Forms.Label Categoria_Add_lbl_name;
        public System.Windows.Forms.Button Categoria_Add_btn_save;
        public System.Windows.Forms.TextBox txtCategoria;
    }
}