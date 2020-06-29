
using Ferreteria_I.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ferreteria_I.Views
{
    partial class Usuario_V_Add : Form
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
            this.Usuario_txt_Add_tel = new System.Windows.Forms.MaskedTextBox();
            this.Usuario_txt_Add_address = new System.Windows.Forms.TextBox();
            this.Usuario_txt_Add_pass = new System.Windows.Forms.TextBox();
            this.Usuario_txt_Add_LastN = new System.Windows.Forms.TextBox();
            this.Usuario_txt_Add_user = new System.Windows.Forms.TextBox();
            this.Usuario_txt_Add_Name = new System.Windows.Forms.TextBox();
            this.Usuario_cbox_Add_dep = new System.Windows.Forms.ComboBox();
            this.Usuario_cbox_Add_Mun = new System.Windows.Forms.ComboBox();
            this.Usuario_cbox_Add_Rol = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario_btn_Add_Save = new System.Windows.Forms.Button();
            this.Usuario_btn_Add_cancel = new System.Windows.Forms.Button();
            this.usuarioModBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Departamento_btn_add = new System.Windows.Forms.Button();
            this.Municipio_btn_add = new System.Windows.Forms.Button();
            this.Rol_btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_tel);
            this.groupBox1.Controls.Add(this.Departamento_btn_add);
            this.groupBox1.Controls.Add(this.Municipio_btn_add);
            this.groupBox1.Controls.Add(this.Rol_btn_add);
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_address);
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_pass);
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_LastN);
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_user);
            this.groupBox1.Controls.Add(this.Usuario_txt_Add_Name);
            this.groupBox1.Controls.Add(this.Usuario_cbox_Add_dep);
            this.groupBox1.Controls.Add(this.Usuario_cbox_Add_Mun);
            this.groupBox1.Controls.Add(this.Usuario_cbox_Add_Rol);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar nuevo usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Usuario_txt_Add_tel
            // 
            this.Usuario_txt_Add_tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Usuario_txt_Add_tel.Location = new System.Drawing.Point(490, 149);
            this.Usuario_txt_Add_tel.Mask = "0000-0000";
            this.Usuario_txt_Add_tel.Name = "Usuario_txt_Add_tel";
            this.Usuario_txt_Add_tel.Size = new System.Drawing.Size(151, 26);
            this.Usuario_txt_Add_tel.TabIndex = 4;
            this.Usuario_txt_Add_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario_txt_Add_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Usuario_txt_Add_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuario_txt_Add_tel_KeyPress_1);
            // 
            // Usuario_txt_Add_address
            // 
            this.Usuario_txt_Add_address.Location = new System.Drawing.Point(113, 330);
            this.Usuario_txt_Add_address.Name = "Usuario_txt_Add_address";
            this.Usuario_txt_Add_address.Size = new System.Drawing.Size(528, 26);
            this.Usuario_txt_Add_address.TabIndex = 7;
            // 
            // Usuario_txt_Add_pass
            // 
            this.Usuario_txt_Add_pass.Location = new System.Drawing.Point(490, 240);
            this.Usuario_txt_Add_pass.Name = "Usuario_txt_Add_pass";
            this.Usuario_txt_Add_pass.Size = new System.Drawing.Size(151, 26);
            this.Usuario_txt_Add_pass.TabIndex = 6;
            // 
            // Usuario_txt_Add_LastN
            // 
            this.Usuario_txt_Add_LastN.Location = new System.Drawing.Point(490, 59);
            this.Usuario_txt_Add_LastN.Name = "Usuario_txt_Add_LastN";
            this.Usuario_txt_Add_LastN.Size = new System.Drawing.Size(151, 26);
            this.Usuario_txt_Add_LastN.TabIndex = 1;
            this.Usuario_txt_Add_LastN.TextChanged += new System.EventHandler(this.Usuario_txt_Add_LastN_TextChanged);
            // 
            // Usuario_txt_Add_user
            // 
            this.Usuario_txt_Add_user.Location = new System.Drawing.Point(113, 239);
            this.Usuario_txt_Add_user.Name = "Usuario_txt_Add_user";
            this.Usuario_txt_Add_user.Size = new System.Drawing.Size(152, 26);
            this.Usuario_txt_Add_user.TabIndex = 5;
            // 
            // Usuario_txt_Add_Name
            // 
            this.Usuario_txt_Add_Name.Location = new System.Drawing.Point(113, 61);
            this.Usuario_txt_Add_Name.Name = "Usuario_txt_Add_Name";
            this.Usuario_txt_Add_Name.Size = new System.Drawing.Size(152, 26);
            this.Usuario_txt_Add_Name.TabIndex = 0;
            this.Usuario_txt_Add_Name.TextChanged += new System.EventHandler(this.Usuario_txt_Add_Name_TextChanged);
            // 
            // Usuario_cbox_Add_dep
            // 
            this.Usuario_cbox_Add_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuario_cbox_Add_dep.FormattingEnabled = true;
            this.Usuario_cbox_Add_dep.Location = new System.Drawing.Point(490, 418);
            this.Usuario_cbox_Add_dep.Name = "Usuario_cbox_Add_dep";
            this.Usuario_cbox_Add_dep.Size = new System.Drawing.Size(151, 28);
            this.Usuario_cbox_Add_dep.TabIndex = 9;
            // 
            // Usuario_cbox_Add_Mun
            // 
            this.Usuario_cbox_Add_Mun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuario_cbox_Add_Mun.FormattingEnabled = true;
            this.Usuario_cbox_Add_Mun.Location = new System.Drawing.Point(113, 419);
            this.Usuario_cbox_Add_Mun.Name = "Usuario_cbox_Add_Mun";
            this.Usuario_cbox_Add_Mun.Size = new System.Drawing.Size(152, 28);
            this.Usuario_cbox_Add_Mun.TabIndex = 7;
            // 
            // Usuario_cbox_Add_Rol
            // 
            this.Usuario_cbox_Add_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Usuario_cbox_Add_Rol.FormattingEnabled = true;
            this.Usuario_cbox_Add_Rol.Location = new System.Drawing.Point(113, 152);
            this.Usuario_cbox_Add_Rol.Name = "Usuario_cbox_Add_Rol";
            this.Usuario_cbox_Add_Rol.Size = new System.Drawing.Size(152, 28);
            this.Usuario_cbox_Add_Rol.TabIndex = 2;
            this.Usuario_cbox_Add_Rol.SelectedIndexChanged += new System.EventHandler(this.Usuario_cbox_Add_Rol_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Municipio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Usuario_btn_Add_Save
            // 
            this.Usuario_btn_Add_Save.Location = new System.Drawing.Point(301, 495);
            this.Usuario_btn_Add_Save.Name = "Usuario_btn_Add_Save";
            this.Usuario_btn_Add_Save.Size = new System.Drawing.Size(110, 47);
            this.Usuario_btn_Add_Save.TabIndex = 11;
            this.Usuario_btn_Add_Save.Text = "Guardar";
            this.Usuario_btn_Add_Save.UseVisualStyleBackColor = true;
            this.Usuario_btn_Add_Save.Click += new System.EventHandler(this.Usuario_btn_Add_Save_Click);
            // 
            // Usuario_btn_Add_cancel
            // 
            this.Usuario_btn_Add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Usuario_btn_Add_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_btn_Add_cancel.Location = new System.Drawing.Point(657, 515);
            this.Usuario_btn_Add_cancel.Name = "Usuario_btn_Add_cancel";
            this.Usuario_btn_Add_cancel.Size = new System.Drawing.Size(59, 27);
            this.Usuario_btn_Add_cancel.TabIndex = 12;
            this.Usuario_btn_Add_cancel.Text = "Cancelar";
            this.Usuario_btn_Add_cancel.UseVisualStyleBackColor = true;
            this.Usuario_btn_Add_cancel.Click += new System.EventHandler(this.Usuario_btn_Add_cancel_Click);
            // 
            // usuarioModBindingSource

            // 
            // Departamento_btn_add
            // 
            this.Departamento_btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.Departamento_btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Departamento_btn_add.Location = new System.Drawing.Point(652, 418);
            this.Departamento_btn_add.Name = "Departamento_btn_add";
            this.Departamento_btn_add.Size = new System.Drawing.Size(37, 28);
            this.Departamento_btn_add.TabIndex = 10;
            this.Departamento_btn_add.Text = "+";
            this.Departamento_btn_add.UseVisualStyleBackColor = false;
            this.Departamento_btn_add.Click += new System.EventHandler(this.Departamento_btn_add_Click);
            // 
            // Municipio_btn_add
            // 
            this.Municipio_btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.Municipio_btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Municipio_btn_add.Location = new System.Drawing.Point(279, 419);
            this.Municipio_btn_add.Name = "Municipio_btn_add";
            this.Municipio_btn_add.Size = new System.Drawing.Size(37, 28);
            this.Municipio_btn_add.TabIndex = 8;
            this.Municipio_btn_add.Text = "+";
            this.Municipio_btn_add.UseVisualStyleBackColor = false;
            this.Municipio_btn_add.Click += new System.EventHandler(this.Municipio_btn_add_Click);
            // 
            // Rol_btn_add
            // 
            this.Rol_btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.Rol_btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rol_btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Rol_btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rol_btn_add.Location = new System.Drawing.Point(279, 152);
            this.Rol_btn_add.Name = "Rol_btn_add";
            this.Rol_btn_add.Size = new System.Drawing.Size(37, 28);
            this.Rol_btn_add.TabIndex = 3;
            this.Rol_btn_add.Text = "+";
            this.Rol_btn_add.UseVisualStyleBackColor = false;
            this.Rol_btn_add.Click += new System.EventHandler(this.Rol_btn_add_Click);
            // 
            // Usuario_V_Add
            // 
            this.AcceptButton = this.Usuario_btn_Add_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Usuario_btn_Add_cancel;
            this.ClientSize = new System.Drawing.Size(728, 554);
            this.Controls.Add(this.Usuario_btn_Add_cancel);
            this.Controls.Add(this.Usuario_btn_Add_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Usuario_V_Add";
            this.ShowIcon = false;
            this.Text = "Agregar / Actualizar Usuario";
            this.Load += new System.EventHandler(this.Usuario_V_Add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioModBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario_txt_Add_address;
        private System.Windows.Forms.TextBox Usuario_txt_Add_pass;
        private System.Windows.Forms.TextBox Usuario_txt_Add_LastN;
        private System.Windows.Forms.TextBox Usuario_txt_Add_user;
        private System.Windows.Forms.TextBox Usuario_txt_Add_Name;
        private System.Windows.Forms.ComboBox Usuario_cbox_Add_dep;
        private System.Windows.Forms.ComboBox Usuario_cbox_Add_Mun;
        private System.Windows.Forms.ComboBox Usuario_cbox_Add_Rol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Usuario_btn_Add_Save;
        private System.Windows.Forms.Button Usuario_btn_Add_cancel;
        private System.Windows.Forms.BindingSource usuarioModBindingSource;
        private MaskedTextBox Usuario_txt_Add_tel;
        private Button Departamento_btn_add;
        private Button Municipio_btn_add;
        private Button Rol_btn_add;
    }
}