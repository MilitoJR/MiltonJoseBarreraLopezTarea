namespace Ferreteria_I.Views
{
    partial class MetodoP_V_Add
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
            this.mpago_btn_Add_cancel = new System.Windows.Forms.Button();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mpago_btn_Add_cancel
            // 
            this.mpago_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mpago_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpago_btn_Add_cancel.Location = new System.Drawing.Point(300, 315);
            this.mpago_btn_Add_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mpago_btn_Add_cancel.Name = "mpago_btn_Add_cancel";
            this.mpago_btn_Add_cancel.Size = new System.Drawing.Size(88, 42);
            this.mpago_btn_Add_cancel.TabIndex = 17;
            this.mpago_btn_Add_cancel.Text = "Cancelar";
            this.mpago_btn_Add_cancel.UseVisualStyleBackColor = true;
            this.mpago_btn_Add_cancel.Click += new System.EventHandler(this.mpago_btn_Add_cancel_Click);
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(111, 94);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(253, 26);
            this.txtpago.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "M de Pago";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 98);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MetodoP_V_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mpago_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(406, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mpago_btn_Add_cancel);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MetodoP_V_Add";
            this.ShowIcon = false;
            this.Text = "Metodo de Pago";
            this.Load += new System.EventHandler(this.MetodoP_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mpago_btn_Add_cancel;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}