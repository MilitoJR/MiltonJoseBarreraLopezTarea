namespace Ferreteria_I.Views
{
    partial class Municipio_V_Add
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
            this.Municipio_btn_cancel = new System.Windows.Forms.Button();
            this.Municipio_btn_Add = new System.Windows.Forms.Button();
            this.Municipio_txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Municipio_btn_cancel
            // 
            this.Municipio_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Municipio_btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Municipio_btn_cancel.Location = new System.Drawing.Point(234, 215);
            this.Municipio_btn_cancel.Name = "Municipio_btn_cancel";
            this.Municipio_btn_cancel.Size = new System.Drawing.Size(59, 27);
            this.Municipio_btn_cancel.TabIndex = 21;
            this.Municipio_btn_cancel.Text = "Cancelar";
            this.Municipio_btn_cancel.UseVisualStyleBackColor = true;
            this.Municipio_btn_cancel.Click += new System.EventHandler(this.Municipio_btn_cancel_Click);
            // 
            // Municipio_btn_Add
            // 
            this.Municipio_btn_Add.Location = new System.Drawing.Point(91, 123);
            this.Municipio_btn_Add.Name = "Municipio_btn_Add";
            this.Municipio_btn_Add.Size = new System.Drawing.Size(110, 49);
            this.Municipio_btn_Add.TabIndex = 19;
            this.Municipio_btn_Add.Text = "Guardar";
            this.Municipio_btn_Add.UseVisualStyleBackColor = true;
            this.Municipio_btn_Add.Click += new System.EventHandler(this.Municipio_btn_Add_Click);
            // 
            // Municipio_txt_name
            // 
            this.Municipio_txt_name.Location = new System.Drawing.Point(91, 47);
            this.Municipio_txt_name.Name = "Municipio_txt_name";
            this.Municipio_txt_name.Size = new System.Drawing.Size(170, 20);
            this.Municipio_txt_name.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Municipio";
            // 
            // Municipio_V_Add
            // 
            this.AcceptButton = this.Municipio_btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Municipio_btn_cancel;
            this.ClientSize = new System.Drawing.Size(305, 254);
            this.Controls.Add(this.Municipio_btn_cancel);
            this.Controls.Add(this.Municipio_btn_Add);
            this.Controls.Add(this.Municipio_txt_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Municipio_V_Add";
            this.ShowIcon = false;
            this.Text = "Municipio";
            this.Load += new System.EventHandler(this.Municipio_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Municipio_btn_cancel;
        private System.Windows.Forms.Button Municipio_btn_Add;
        private System.Windows.Forms.TextBox Municipio_txt_name;
        private System.Windows.Forms.Label label1;
    }
}