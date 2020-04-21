namespace MiltonBarrera.Vista
{
    partial class materias
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombreMat = new System.Windows.Forms.TextBox();
            this.dtvMat = new System.Windows.Forms.DataGridView();
            this.MateriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la materia ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(287, 102);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 26);
            this.txtId.TabIndex = 2;
            // 
            // txtNombreMat
            // 
            this.txtNombreMat.Location = new System.Drawing.Point(287, 194);
            this.txtNombreMat.Name = "txtNombreMat";
            this.txtNombreMat.Size = new System.Drawing.Size(160, 26);
            this.txtNombreMat.TabIndex = 3;
            // 
            // dtvMat
            // 
            this.dtvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaId});
            this.dtvMat.Location = new System.Drawing.Point(162, 265);
            this.dtvMat.Name = "dtvMat";
            this.dtvMat.RowHeadersWidth = 62;
            this.dtvMat.RowTemplate.Height = 28;
            this.dtvMat.Size = new System.Drawing.Size(374, 150);
            this.dtvMat.TabIndex = 4;
            this.dtvMat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtvMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMat_CellContentClick);
            // 
            // MateriaId
            // 
            this.MateriaId.HeaderText = "MateriaId";
            this.MateriaId.MinimumWidth = 8;
            this.MateriaId.Name = "MateriaId";
            this.MateriaId.Visible = false;
            this.MateriaId.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvMat);
            this.Controls.Add(this.txtNombreMat);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "materias";
            this.Text = "materias";
            this.Load += new System.EventHandler(this.materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombreMat;
        private System.Windows.Forms.DataGridView dtvMat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaId;
    }
}