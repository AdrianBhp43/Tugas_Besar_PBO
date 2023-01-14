namespace Tugas_Besar_PBO.View
{
    partial class FormAdmin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbTtl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAsalSekolah = new System.Windows.Forms.TextBox();
            this.tbNisn = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNoHp = new System.Windows.Forms.TextBox();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cbTa = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(8, 8);
            this.DataMahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(933, 188);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(628, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 197);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(14, 144);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(276, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(14, 101);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(276, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(14, 59);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(276, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(14, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(276, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(158, 234);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(267, 20);
            this.tbNama.TabIndex = 12;
            // 
            // tbTtl
            // 
            this.tbTtl.Location = new System.Drawing.Point(158, 267);
            this.tbTtl.Name = "tbTtl";
            this.tbTtl.Size = new System.Drawing.Size(267, 20);
            this.tbTtl.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "TTL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asal Sekolah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "NISN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tahun Lulus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "No Hp";
            // 
            // tbAsalSekolah
            // 
            this.tbAsalSekolah.Location = new System.Drawing.Point(158, 334);
            this.tbAsalSekolah.Name = "tbAsalSekolah";
            this.tbAsalSekolah.Size = new System.Drawing.Size(267, 20);
            this.tbAsalSekolah.TabIndex = 23;
            // 
            // tbNisn
            // 
            this.tbNisn.Location = new System.Drawing.Point(158, 367);
            this.tbNisn.Name = "tbNisn";
            this.tbNisn.Size = new System.Drawing.Size(267, 20);
            this.tbNisn.TabIndex = 24;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(158, 434);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(267, 54);
            this.tbAlamat.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(158, 494);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(267, 20);
            this.tbEmail.TabIndex = 26;
            // 
            // tbNoHp
            // 
            this.tbNoHp.Location = new System.Drawing.Point(158, 520);
            this.tbNoHp.Name = "tbNoHp";
            this.tbNoHp.Size = new System.Drawing.Size(267, 20);
            this.tbNoHp.TabIndex = 27;
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cbJenisKelamin.Location = new System.Drawing.Point(158, 300);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(267, 21);
            this.cbJenisKelamin.TabIndex = 28;
            // 
            // cbTa
            // 
            this.cbTa.FormattingEnabled = true;
            this.cbTa.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018"});
            this.cbTa.Location = new System.Drawing.Point(158, 400);
            this.cbTa.Name = "cbTa";
            this.cbTa.Size = new System.Drawing.Size(267, 21);
            this.cbTa.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(592, 203);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(349, 108);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(98, 42);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(243, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cari Data";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 549);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbTa);
            this.Controls.Add(this.cbJenisKelamin);
            this.Controls.Add(this.tbNoHp);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNisn);
            this.Controls.Add(this.tbAsalSekolah);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTtl);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DataMahasiswa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbTtl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAsalSekolah;
        private System.Windows.Forms.TextBox tbNisn;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNoHp;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.ComboBox cbTa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label10;
    }
}