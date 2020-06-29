namespace Ferreteria_I.Views
{
    partial class Marca_V_Add
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
            this.Marca_btn_Add_cancel = new System.Windows.Forms.Button();
            this.Marca_btn_add = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combopro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Marca_btn_Add_cancel
            // 
            this.Marca_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Marca_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca_btn_Add_cancel.Location = new System.Drawing.Point(342, 357);
            this.Marca_btn_Add_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Marca_btn_Add_cancel.Name = "Marca_btn_Add_cancel";
            this.Marca_btn_Add_cancel.Size = new System.Drawing.Size(88, 42);
            this.Marca_btn_Add_cancel.TabIndex = 17;
            this.Marca_btn_Add_cancel.Text = "Cerrar";
            this.Marca_btn_Add_cancel.UseVisualStyleBackColor = true;
            this.Marca_btn_Add_cancel.Click += new System.EventHandler(this.Marca_btn_Add_cancel_Click);
            // 
            // Marca_btn_add
            // 
            this.Marca_btn_add.Location = new System.Drawing.Point(154, 245);
            this.Marca_btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Marca_btn_add.Name = "Marca_btn_add";
            this.Marca_btn_add.Size = new System.Drawing.Size(165, 75);
            this.Marca_btn_add.TabIndex = 16;
            this.Marca_btn_add.Text = "Guardar";
            this.Marca_btn_add.UseVisualStyleBackColor = true;
            this.Marca_btn_add.Click += new System.EventHandler(this.Marca_btn_add_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(128, 66);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(253, 26);
            this.txtmarca.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca";
            // 
            // combopro
            // 
            this.combopro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopro.FormattingEnabled = true;
            this.combopro.Location = new System.Drawing.Point(128, 148);
            this.combopro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combopro.Name = "combopro";
            this.combopro.Size = new System.Drawing.Size(253, 28);
            this.combopro.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Proveedor";
            // 
            // Marca_V_Add
            // 
            this.AcceptButton = this.Marca_btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Marca_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(448, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combopro);
            this.Controls.Add(this.Marca_btn_Add_cancel);
            this.Controls.Add(this.Marca_btn_add);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Marca_V_Add";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_V_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Marca_btn_Add_cancel;
        private System.Windows.Forms.Button Marca_btn_add;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combopro;
        private System.Windows.Forms.Label label2;
    }
}