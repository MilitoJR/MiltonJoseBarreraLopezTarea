namespace Ferreteria_I.Views
{
    partial class Proveedor_V_Add
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combomuni = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combodepa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprovee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorModBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedor_btn_Add_cancel = new System.Windows.Forms.Button();
            this.proveedor_btn_Add_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combomuni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combodepa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcontacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprovee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1016, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar / Editar Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttelefono
            // 
            this.txttelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txttelefono.Location = new System.Drawing.Point(186, 325);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(250, 35);
            this.txttelefono.TabIndex = 14;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // combomuni
            // 
            this.combomuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomuni.FormattingEnabled = true;
            this.combomuni.Location = new System.Drawing.Point(674, 209);
            this.combomuni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combomuni.Name = "combomuni";
            this.combomuni.Size = new System.Drawing.Size(250, 37);
            this.combomuni.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Municipio";
            // 
            // combodepa
            // 
            this.combodepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodepa.FormattingEnabled = true;
            this.combodepa.Location = new System.Drawing.Point(186, 211);
            this.combodepa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combodepa.Name = "combodepa";
            this.combodepa.Size = new System.Drawing.Size(250, 37);
            this.combodepa.TabIndex = 5;
            this.combodepa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departamento";
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(674, 94);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(250, 35);
            this.txtcontacto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contacto";
            // 
            // txtprovee
            // 
            this.txtprovee.Location = new System.Drawing.Point(186, 94);
            this.txtprovee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprovee.Name = "txtprovee";
            this.txtprovee.Size = new System.Drawing.Size(250, 35);
            this.txtprovee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // proveedor_btn_Add_cancel
            // 
            this.proveedor_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.proveedor_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor_btn_Add_cancel.Location = new System.Drawing.Point(944, 520);
            this.proveedor_btn_Add_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proveedor_btn_Add_cancel.Name = "proveedor_btn_Add_cancel";
            this.proveedor_btn_Add_cancel.Size = new System.Drawing.Size(88, 42);
            this.proveedor_btn_Add_cancel.TabIndex = 14;
            this.proveedor_btn_Add_cancel.Text = "Cerrar";
            this.proveedor_btn_Add_cancel.UseVisualStyleBackColor = true;
            this.proveedor_btn_Add_cancel.Click += new System.EventHandler(this.proveedor_btn_Add_cancel_Click);
            // 
            // proveedor_btn_Add_Save
            // 
            this.proveedor_btn_Add_Save.Location = new System.Drawing.Point(440, 460);
            this.proveedor_btn_Add_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proveedor_btn_Add_Save.Name = "proveedor_btn_Add_Save";
            this.proveedor_btn_Add_Save.Size = new System.Drawing.Size(165, 72);
            this.proveedor_btn_Add_Save.TabIndex = 13;
            this.proveedor_btn_Add_Save.Text = "Guardar";
            this.proveedor_btn_Add_Save.UseVisualStyleBackColor = true;
            this.proveedor_btn_Add_Save.Click += new System.EventHandler(this.Usuario_btn_Add_Save_Click);
            // 
            // Proveedor_V_Add
            // 
            this.AcceptButton = this.proveedor_btn_Add_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.proveedor_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.proveedor_btn_Add_cancel);
            this.Controls.Add(this.proveedor_btn_Add_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Proveedor_V_Add";
            this.ShowIcon = false;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_V_Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorModBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource proveedorModBindingSource;
        private System.Windows.Forms.BindingSource proveedorModBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprovee;
        private System.Windows.Forms.ComboBox combodepa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combomuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button proveedor_btn_Add_cancel;
        private System.Windows.Forms.Button proveedor_btn_Add_Save;
        private System.Windows.Forms.MaskedTextBox txttelefono;
    }
}