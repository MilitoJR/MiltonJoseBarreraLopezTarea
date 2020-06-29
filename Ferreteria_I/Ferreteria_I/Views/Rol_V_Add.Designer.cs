namespace Ferreteria_I.Views
{
    partial class Rol_V_Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rol_txt_name = new System.Windows.Forms.TextBox();
            this.Rol_btn_add = new System.Windows.Forms.Button();
            this.Usuario_btn_Add_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";

            // 
            // Rol_txt_name
            // 
            this.Rol_txt_name.Location = new System.Drawing.Point(64, 64);
            this.Rol_txt_name.Name = "Rol_txt_name";
            this.Rol_txt_name.Size = new System.Drawing.Size(170, 20);

            // 
            // Rol_btn_add
            // 
            this.Rol_btn_add.Location = new System.Drawing.Point(92, 125);
            this.Rol_btn_add.Name = "Rol_btn_add";
            this.Rol_btn_add.Size = new System.Drawing.Size(110, 49);
            this.Rol_btn_add.TabIndex = 2;
            this.Rol_btn_add.Text = "Guardar";
            this.Rol_btn_add.UseVisualStyleBackColor = true;
            this.Rol_btn_add.Click += new System.EventHandler(this.Rol_btn_add_Click);
            // 
            // Usuario_btn_Add_cancel
            // 
            this.Usuario_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Usuario_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_btn_Add_cancel.Location = new System.Drawing.Point(197, 207);
            this.Usuario_btn_Add_cancel.Name = "Usuario_btn_Add_cancel";
            this.Usuario_btn_Add_cancel.Size = new System.Drawing.Size(59, 27);
            this.Usuario_btn_Add_cancel.TabIndex = 13;
            this.Usuario_btn_Add_cancel.Text = "Cancelar";
            this.Usuario_btn_Add_cancel.UseVisualStyleBackColor = true;

            // 
            // Rol_V_Add
            // 
            this.AcceptButton = this.Rol_btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Usuario_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(268, 246);
            this.Controls.Add(this.Usuario_btn_Add_cancel);
            this.Controls.Add(this.Rol_btn_add);
            this.Controls.Add(this.Rol_txt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Rol_V_Add";
            this.ShowIcon = false;
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Rol_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Rol_txt_name;
        private System.Windows.Forms.Button Rol_btn_add;
        private System.Windows.Forms.Button Usuario_btn_Add_cancel;
    }
}