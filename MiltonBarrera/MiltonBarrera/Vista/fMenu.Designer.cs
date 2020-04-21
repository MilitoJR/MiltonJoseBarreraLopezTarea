namespace MiltonBarrera.Vista
{
    partial class fMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMaterasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasPorEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.ingresoDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeEstudiantesToolStripMenuItem
            // 
            this.ingresoDeEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeEstudianteToolStripMenuItem});
            this.ingresoDeEstudiantesToolStripMenuItem.Name = "ingresoDeEstudiantesToolStripMenuItem";
            this.ingresoDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(208, 29);
            this.ingresoDeEstudiantesToolStripMenuItem.Text = "Ingreso de estudiantes";
            // 
            // datosDeEstudianteToolStripMenuItem
            // 
            this.datosDeEstudianteToolStripMenuItem.Name = "datosDeEstudianteToolStripMenuItem";
            this.datosDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.datosDeEstudianteToolStripMenuItem.Text = "Datos de Estudiante";
            this.datosDeEstudianteToolStripMenuItem.Click += new System.EventHandler(this.datosDeEstudianteToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeMaterasToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // mantenimientoDeMaterasToolStripMenuItem
            // 
            this.mantenimientoDeMaterasToolStripMenuItem.Name = "mantenimientoDeMaterasToolStripMenuItem";
            this.mantenimientoDeMaterasToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.mantenimientoDeMaterasToolStripMenuItem.Text = "Mantenimiento de materas";
            this.mantenimientoDeMaterasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMaterasToolStripMenuItem_Click);
            // 
            // ingresoDeNotasToolStripMenuItem
            // 
            this.ingresoDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasPorEstudianteToolStripMenuItem});
            this.ingresoDeNotasToolStripMenuItem.Name = "ingresoDeNotasToolStripMenuItem";
            this.ingresoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.ingresoDeNotasToolStripMenuItem.Text = "Ingreso de notas";
            // 
            // notasPorEstudianteToolStripMenuItem
            // 
            this.notasPorEstudianteToolStripMenuItem.Name = "notasPorEstudianteToolStripMenuItem";
            this.notasPorEstudianteToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.notasPorEstudianteToolStripMenuItem.Text = "Notas por estudiante";
            this.notasPorEstudianteToolStripMenuItem.Click += new System.EventHandler(this.notasPorEstudianteToolStripMenuItem_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMaterasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasPorEstudianteToolStripMenuItem;
    }
}