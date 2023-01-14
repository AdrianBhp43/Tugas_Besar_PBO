namespace Tugas_Besar_PBO.View
{
    partial class FormPrestasiAdmin
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
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNamaKegiatan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbKabupaten = new System.Windows.Forms.RadioButton();
            this.rbNasional = new System.Windows.Forms.RadioButton();
            this.rbProvinsi = new System.Windows.Forms.RadioButton();
            this.rbInternasional = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.rbKelompok = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbTahunPerolehan = new System.Windows.Forms.ComboBox();
            this.cbPencapaian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(16, 17);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(1400, 289);
            this.DataMahasiswa.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPencapaian);
            this.groupBox2.Controls.Add(this.cbTahunPerolehan);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.rbKelompok);
            this.groupBox2.Controls.Add(this.rbIndividual);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNamaKegiatan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Size = new System.Drawing.Size(862, 422);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Nilai";
            // 
            // tbNamaKegiatan
            // 
            this.tbNamaKegiatan.Location = new System.Drawing.Point(252, 66);
            this.tbNamaKegiatan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbNamaKegiatan.Name = "tbNamaKegiatan";
            this.tbNamaKegiatan.Size = new System.Drawing.Size(422, 26);
            this.tbNamaKegiatan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tahun Perolehan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tingkat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kegiatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kegiatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pencapaian";
            // 
            // rbKabupaten
            // 
            this.rbKabupaten.AutoSize = true;
            this.rbKabupaten.Location = new System.Drawing.Point(9, 28);
            this.rbKabupaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKabupaten.Name = "rbKabupaten";
            this.rbKabupaten.Size = new System.Drawing.Size(112, 24);
            this.rbKabupaten.TabIndex = 21;
            this.rbKabupaten.Text = "Kabupaten";
            this.rbKabupaten.UseVisualStyleBackColor = true;
            // 
            // rbNasional
            // 
            this.rbNasional.AutoSize = true;
            this.rbNasional.Location = new System.Drawing.Point(315, 28);
            this.rbNasional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNasional.Name = "rbNasional";
            this.rbNasional.Size = new System.Drawing.Size(95, 24);
            this.rbNasional.TabIndex = 23;
            this.rbNasional.Text = "Nasional";
            this.rbNasional.UseVisualStyleBackColor = true;
            // 
            // rbProvinsi
            // 
            this.rbProvinsi.AutoSize = true;
            this.rbProvinsi.Location = new System.Drawing.Point(165, 28);
            this.rbProvinsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbProvinsi.Name = "rbProvinsi";
            this.rbProvinsi.Size = new System.Drawing.Size(88, 24);
            this.rbProvinsi.TabIndex = 22;
            this.rbProvinsi.Text = "Provinsi";
            this.rbProvinsi.UseVisualStyleBackColor = true;
            // 
            // rbInternasional
            // 
            this.rbInternasional.AutoSize = true;
            this.rbInternasional.Location = new System.Drawing.Point(465, 28);
            this.rbInternasional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbInternasional.Name = "rbInternasional";
            this.rbInternasional.Size = new System.Drawing.Size(126, 24);
            this.rbInternasional.TabIndex = 24;
            this.rbInternasional.Text = "Internasional";
            this.rbInternasional.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInternasional);
            this.groupBox1.Controls.Add(this.rbProvinsi);
            this.groupBox1.Controls.Add(this.rbNasional);
            this.groupBox1.Controls.Add(this.rbKabupaten);
            this.groupBox1.Location = new System.Drawing.Point(252, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(604, 60);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Location = new System.Drawing.Point(252, 131);
            this.rbIndividual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(100, 24);
            this.rbIndividual.TabIndex = 22;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = true;
            // 
            // rbKelompok
            // 
            this.rbKelompok.AutoSize = true;
            this.rbKelompok.Location = new System.Drawing.Point(431, 131);
            this.rbKelompok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKelompok.Name = "rbKelompok";
            this.rbKelompok.Size = new System.Drawing.Size(133, 24);
            this.rbKelompok.TabIndex = 23;
            this.rbKelompok.Text = "Kelompok/ tim";
            this.rbKelompok.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(950, 351);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(466, 303);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(21, 222);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(414, 35);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(21, 155);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(414, 35);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(21, 91);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(414, 35);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(21, 32);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(414, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
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
            this.cbTahunPerolehan.Location = new System.Drawing.Point(252, 252);
            this.cbTahunPerolehan.Name = "cbTahunPerolehan";
            this.cbTahunPerolehan.Size = new System.Drawing.Size(422, 28);
            this.cbTahunPerolehan.TabIndex = 25;
            // 
            // cbPencapaian
            // 
            this.cbPencapaian.FormattingEnabled = true;
            this.cbPencapaian.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbPencapaian.Location = new System.Drawing.Point(252, 301);
            this.cbPencapaian.Name = "cbPencapaian";
            this.cbPencapaian.Size = new System.Drawing.Size(422, 28);
            this.cbPencapaian.TabIndex = 26;
            // 
            // FormPrestasiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 709);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataMahasiswa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrestasiAdmin";
            this.Text = "FormPrestasiAdmin";
            this.Load += new System.EventHandler(this.FormPrestasiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaKegiatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInternasional;
        private System.Windows.Forms.RadioButton rbProvinsi;
        private System.Windows.Forms.RadioButton rbNasional;
        private System.Windows.Forms.RadioButton rbKabupaten;
        private System.Windows.Forms.RadioButton rbKelompok;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbPencapaian;
        private System.Windows.Forms.ComboBox cbTahunPerolehan;
    }
}