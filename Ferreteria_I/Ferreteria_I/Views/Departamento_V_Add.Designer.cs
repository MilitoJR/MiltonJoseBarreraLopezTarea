namespace Ferreteria_I.Views
{
    partial class Departamento_V_Add
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
            this.Departamento_btn_cancel = new System.Windows.Forms.Button();
            this.Departamento_btn_Add = new System.Windows.Forms.Button();
            this.Departamento_txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Departamento_btn_cancel
            // 
            this.Departamento_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Departamento_btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento_btn_cancel.Location = new System.Drawing.Point(229, 189);
            this.Departamento_btn_cancel.Name = "Departamento_btn_cancel";
            this.Departamento_btn_cancel.Size = new System.Drawing.Size(59, 27);
            this.Departamento_btn_cancel.TabIndex = 17;
            this.Departamento_btn_cancel.Text = "Cancelar";
            this.Departamento_btn_cancel.UseVisualStyleBackColor = true;
            this.Departamento_btn_cancel.Click += new System.EventHandler(this.Usuario_btn_Add_cancel_Click);
            // 
            // Departamento_btn_Add
            // 
            this.Departamento_btn_Add.Location = new System.Drawing.Point(92, 110);
            this.Departamento_btn_Add.Name = "Departamento_btn_Add";
            this.Departamento_btn_Add.Size = new System.Drawing.Size(110, 49);
            this.Departamento_btn_Add.TabIndex = 1;
            this.Departamento_btn_Add.Text = "Guardar";
            this.Departamento_btn_Add.UseVisualStyleBackColor = true;
            this.Departamento_btn_Add.Click += new System.EventHandler(this.Departamento_btn_add_Click);
            // 
            // Departamento_txt_name
            // 
            this.Departamento_txt_name.Location = new System.Drawing.Point(92, 39);
            this.Departamento_txt_name.Name = "Departamento_txt_name";
            this.Departamento_txt_name.Size = new System.Drawing.Size(170, 20);
            this.Departamento_txt_name.TabIndex = 0;
            this.Departamento_txt_name.TextChanged += new System.EventHandler(this.Departamento_txt_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Departamento";
            // 
            // Departamento_V_Add
            // 
            this.AcceptButton = this.Departamento_btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Departamento_btn_cancel;
            this.ClientSize = new System.Drawing.Size(300, 228);
            this.Controls.Add(this.Departamento_btn_cancel);
            this.Controls.Add(this.Departamento_btn_Add);
            this.Controls.Add(this.Departamento_txt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Departamento_V_Add";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Departamento_btn_cancel;
        private System.Windows.Forms.Button Departamento_btn_Add;
        private System.Windows.Forms.TextBox Departamento_txt_name;
        private System.Windows.Forms.Label label1;
    }
}