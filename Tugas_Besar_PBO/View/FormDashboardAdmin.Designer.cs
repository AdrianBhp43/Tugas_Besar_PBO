namespace Tugas_Besar_PBO.View
{
    partial class FormDashboardAdmin
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCalonMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPrestasiMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCalonMahasiswaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPembiayaanMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataCalonMahasiswaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // dataCalonMahasiswaToolStripMenuItem
            // 
            this.dataCalonMahasiswaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataCalonMahasiswaToolStripMenuItem1,
            this.dataPrestasiMahasiswaToolStripMenuItem,
            this.dataPembiayaanMahasiswaToolStripMenuItem});
            this.dataCalonMahasiswaToolStripMenuItem.Name = "dataCalonMahasiswaToolStripMenuItem";
            this.dataCalonMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.dataCalonMahasiswaToolStripMenuItem.Text = "&Administrasi";
            // 
            // dataPrestasiMahasiswaToolStripMenuItem
            // 
            this.dataPrestasiMahasiswaToolStripMenuItem.Name = "dataPrestasiMahasiswaToolStripMenuItem";
            this.dataPrestasiMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dataPrestasiMahasiswaToolStripMenuItem.Text = "&Data Prestasi Mahasiswa";
            this.dataPrestasiMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataPrestasiMahasiswaToolStripMenuItem_Click);
            // 
            // dataCalonMahasiswaToolStripMenuItem1
            // 
            this.dataCalonMahasiswaToolStripMenuItem1.Name = "dataCalonMahasiswaToolStripMenuItem1";
            this.dataCalonMahasiswaToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.dataCalonMahasiswaToolStripMenuItem1.Text = "&Data Calon Mahasiswa";
            this.dataCalonMahasiswaToolStripMenuItem1.Click += new System.EventHandler(this.dataCalonMahasiswaToolStripMenuItem1_Click);
            // 
            // dataPembiayaanMahasiswaToolStripMenuItem
            // 
            this.dataPembiayaanMahasiswaToolStripMenuItem.Name = "dataPembiayaanMahasiswaToolStripMenuItem";
            this.dataPembiayaanMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dataPembiayaanMahasiswaToolStripMenuItem.Text = "&Data Pembiayaan Mahasiswa";
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashboardAdmin";
            this.Text = "FormDashboardAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCalonMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPrestasiMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCalonMahasiswaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataPembiayaanMahasiswaToolStripMenuItem;
    }
}