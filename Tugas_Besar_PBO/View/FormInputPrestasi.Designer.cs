namespace Tugas_Besar_PBO.View
{
    partial class FormInputPrestasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInternasional = new System.Windows.Forms.RadioButton();
            this.rbProvinsi = new System.Windows.Forms.RadioButton();
            this.rbNasional = new System.Windows.Forms.RadioButton();
            this.rbKabupaten = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPencapaian = new System.Windows.Forms.ComboBox();
            this.cbTahunPerolehan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbKelompok = new System.Windows.Forms.RadioButton();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaKegiatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tugas_Besar_PBO.Properties.Resources.sd;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbPencapaian);
            this.panel1.Controls.Add(this.cbTahunPerolehan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbKelompok);
            this.panel1.Controls.Add(this.rbIndividual);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNamaKegiatan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 554);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbInternasional);
            this.groupBox1.Controls.Add(this.rbProvinsi);
            this.groupBox1.Controls.Add(this.rbNasional);
            this.groupBox1.Controls.Add(this.rbKabupaten);
            this.groupBox1.Location = new System.Drawing.Point(24, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 75);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tingkat";
            // 
            // rbInternasional
            // 
            this.rbInternasional.AutoSize = true;
            this.rbInternasional.Location = new System.Drawing.Point(254, 31);
            this.rbInternasional.Name = "rbInternasional";
            this.rbInternasional.Size = new System.Drawing.Size(85, 17);
            this.rbInternasional.TabIndex = 24;
            this.rbInternasional.Text = "Internasional";
            this.rbInternasional.UseVisualStyleBackColor = true;
            // 
            // rbProvinsi
            // 
            this.rbProvinsi.AutoSize = true;
            this.rbProvinsi.Location = new System.Drawing.Point(89, 31);
            this.rbProvinsi.Name = "rbProvinsi";
            this.rbProvinsi.Size = new System.Drawing.Size(62, 17);
            this.rbProvinsi.TabIndex = 22;
            this.rbProvinsi.Text = "Provinsi";
            this.rbProvinsi.UseVisualStyleBackColor = true;
            // 
            // rbNasional
            // 
            this.rbNasional.AutoSize = true;
            this.rbNasional.Location = new System.Drawing.Point(169, 31);
            this.rbNasional.Name = "rbNasional";
            this.rbNasional.Size = new System.Drawing.Size(66, 17);
            this.rbNasional.TabIndex = 23;
            this.rbNasional.Text = "Nasional";
            this.rbNasional.UseVisualStyleBackColor = true;
            // 
            // rbKabupaten
            // 
            this.rbKabupaten.AutoSize = true;
            this.rbKabupaten.Location = new System.Drawing.Point(6, 31);
            this.rbKabupaten.Name = "rbKabupaten";
            this.rbKabupaten.Size = new System.Drawing.Size(77, 17);
            this.rbKabupaten.TabIndex = 21;
            this.rbKabupaten.Text = "Kabupaten";
            this.rbKabupaten.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(699, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pencapaian";
            // 
            // cbPencapaian
            // 
            this.cbPencapaian.FormattingEnabled = true;
            this.cbPencapaian.Items.AddRange(new object[] {
            "JUARA I",
            "JUARA II",
            "JUARA III",
            "HARAPAN I",
            "HARAPAN II",
            "HARAPAN III"});
            this.cbPencapaian.Location = new System.Drawing.Point(30, 384);
            this.cbPencapaian.Name = "cbPencapaian";
            this.cbPencapaian.Size = new System.Drawing.Size(343, 21);
            this.cbPencapaian.TabIndex = 14;
            // 
            // cbTahunPerolehan
            // 
            this.cbTahunPerolehan.FormattingEnabled = true;
            this.cbTahunPerolehan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbTahunPerolehan.Location = new System.Drawing.Point(30, 333);
            this.cbTahunPerolehan.Name = "cbTahunPerolehan";
            this.cbTahunPerolehan.Size = new System.Drawing.Size(343, 21);
            this.cbTahunPerolehan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tahun Perolehan";
            // 
            // rbKelompok
            // 
            this.rbKelompok.AutoSize = true;
            this.rbKelompok.BackColor = System.Drawing.Color.White;
            this.rbKelompok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelompok.ForeColor = System.Drawing.Color.Black;
            this.rbKelompok.Location = new System.Drawing.Point(151, 199);
            this.rbKelompok.Name = "rbKelompok";
            this.rbKelompok.Size = new System.Drawing.Size(93, 17);
            this.rbKelompok.TabIndex = 5;
            this.rbKelompok.Text = "Kelompok/ tim";
            this.rbKelompok.UseVisualStyleBackColor = false;
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.BackColor = System.Drawing.Color.White;
            this.rbIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIndividual.ForeColor = System.Drawing.Color.Black;
            this.rbIndividual.Location = new System.Drawing.Point(30, 199);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbIndividual.TabIndex = 4;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Kegiatan";
            // 
            // tbNamaKegiatan
            // 
            this.tbNamaKegiatan.Location = new System.Drawing.Point(30, 129);
            this.tbNamaKegiatan.Name = "tbNamaKegiatan";
            this.tbNamaKegiatan.Size = new System.Drawing.Size(343, 20);
            this.tbNamaKegiatan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kegiatan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 32);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Prestasi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(415, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 430);
            this.panel3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(18, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 148);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 148);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormInputPrestasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(810, 606);
            this.Controls.Add(this.panel1);
            this.Name = "FormInputPrestasi";
            this.Text = "FormInputPrestasi";
            this.Load += new System.EventHandler(this.FormInputPrestasi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbKelompok;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaKegiatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPencapaian;
        private System.Windows.Forms.ComboBox cbTahunPerolehan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInternasional;
        private System.Windows.Forms.RadioButton rbProvinsi;
        private System.Windows.Forms.RadioButton rbNasional;
        private System.Windows.Forms.RadioButton rbKabupaten;
    }
}