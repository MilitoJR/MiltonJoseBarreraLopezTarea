namespace Ferreteria_I.Views
{
    partial class Presentacion_V_Add
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
            this.Presentacion_Add_btn_cancel = new System.Windows.Forms.Button();
            this.Presentacion_Add_btn_save = new System.Windows.Forms.Button();
            this.Presentacion_Add_txt_nombre = new System.Windows.Forms.TextBox();
            this.Categoria_Add_lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Presentacion_Add_btn_cancel
            // 
            this.Presentacion_Add_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Presentacion_Add_btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presentacion_Add_btn_cancel.Location = new System.Drawing.Point(211, 205);
            this.Presentacion_Add_btn_cancel.Name = "Presentacion_Add_btn_cancel";
            this.Presentacion_Add_btn_cancel.Size = new System.Drawing.Size(59, 27);
            this.Presentacion_Add_btn_cancel.TabIndex = 21;
            this.Presentacion_Add_btn_cancel.Text = "Cancelar";
            this.Presentacion_Add_btn_cancel.UseVisualStyleBackColor = true;
            this.Presentacion_Add_btn_cancel.Click += new System.EventHandler(this.Presentacion_Add_btn_cancel_Click);
            // 
            // Presentacion_Add_btn_save
            // 
            this.Presentacion_Add_btn_save.Location = new System.Drawing.Point(95, 119);
            this.Presentacion_Add_btn_save.Name = "Presentacion_Add_btn_save";
            this.Presentacion_Add_btn_save.Size = new System.Drawing.Size(110, 49);
            this.Presentacion_Add_btn_save.TabIndex = 20;
            this.Presentacion_Add_btn_save.Text = "Guardar";
            this.Presentacion_Add_btn_save.UseVisualStyleBackColor = true;
            this.Presentacion_Add_btn_save.Click += new System.EventHandler(this.Presentacion_Add_btn_save_Click);
            // 
            // Presentacion_Add_txt_nombre
            // 
            this.Presentacion_Add_txt_nombre.Location = new System.Drawing.Point(82, 58);
            this.Presentacion_Add_txt_nombre.Name = "Presentacion_Add_txt_nombre";
            this.Presentacion_Add_txt_nombre.Size = new System.Drawing.Size(170, 20);
            this.Presentacion_Add_txt_nombre.TabIndex = 19;
            // 
            // Categoria_Add_lbl_name
            // 
            this.Categoria_Add_lbl_name.AutoSize = true;
            this.Categoria_Add_lbl_name.Location = new System.Drawing.Point(7, 61);
            this.Categoria_Add_lbl_name.Name = "Categoria_Add_lbl_name";
            this.Categoria_Add_lbl_name.Size = new System.Drawing.Size(69, 13);
            this.Categoria_Add_lbl_name.TabIndex = 18;
            this.Categoria_Add_lbl_name.Text = "Presentacion";
            // 
            // Presentacion_V_Add
            // 
            this.AcceptButton = this.Presentacion_Add_btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Presentacion_Add_btn_cancel;
            this.ClientSize = new System.Drawing.Size(282, 244);
            this.Controls.Add(this.Presentacion_Add_btn_cancel);
            this.Controls.Add(this.Presentacion_Add_btn_save);
            this.Controls.Add(this.Presentacion_Add_txt_nombre);
            this.Controls.Add(this.Categoria_Add_lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Presentacion_V_Add";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Presentacion_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Presentacion_Add_btn_cancel;
        private System.Windows.Forms.Button Presentacion_Add_btn_save;
        private System.Windows.Forms.TextBox Presentacion_Add_txt_nombre;
        private System.Windows.Forms.Label Categoria_Add_lbl_name;
    }
}