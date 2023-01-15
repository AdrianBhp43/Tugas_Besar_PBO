namespace Tugas_Besar_PBO.View
{
    partial class FormProgramstudi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbds = new System.Windows.Forms.CheckBox();
            this.cbec = new System.Windows.Forms.CheckBox();
            this.cbak = new System.Windows.Forms.CheckBox();
            this.cbmt = new System.Windows.Forms.CheckBox();
            this.cbmb = new System.Windows.Forms.CheckBox();
            this.cblb = new System.Windows.Forms.CheckBox();
            this.cbsi = new System.Windows.Forms.CheckBox();
            this.cbmi = new System.Windows.Forms.CheckBox();
            this.cbti = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbs1 = new System.Windows.Forms.RadioButton();
            this.rbd4 = new System.Windows.Forms.RadioButton();
            this.rbd3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbbiaya = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 216);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.cbds);
            this.groupBox2.Controls.Add(this.cbec);
            this.groupBox2.Controls.Add(this.cbak);
            this.groupBox2.Controls.Add(this.cbmt);
            this.groupBox2.Controls.Add(this.cbmb);
            this.groupBox2.Controls.Add(this.cblb);
            this.groupBox2.Controls.Add(this.cbsi);
            this.groupBox2.Controls.Add(this.cbmi);
            this.groupBox2.Controls.Add(this.cbti);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(285, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fakultas / Progam studi";
            // 
            // cbds
            // 
            this.cbds.AutoSize = true;
            this.cbds.Location = new System.Drawing.Point(333, 81);
            this.cbds.Name = "cbds";
            this.cbds.Size = new System.Drawing.Size(106, 17);
            this.cbds.TabIndex = 7;
            this.cbds.Text = "Data Scientist";
            this.cbds.UseVisualStyleBackColor = true;
            this.cbds.CheckedChanged += new System.EventHandler(this.cbds_CheckedChanged);
            // 
            // cbec
            // 
            this.cbec.AutoSize = true;
            this.cbec.Location = new System.Drawing.Point(333, 56);
            this.cbec.Name = "cbec";
            this.cbec.Size = new System.Drawing.Size(95, 17);
            this.cbec.TabIndex = 7;
            this.cbec.Text = "E-commerce";
            this.cbec.UseVisualStyleBackColor = true;
            // 
            // cbak
            // 
            this.cbak.AutoSize = true;
            this.cbak.Location = new System.Drawing.Point(333, 31);
            this.cbak.Name = "cbak";
            this.cbak.Size = new System.Drawing.Size(75, 17);
            this.cbak.TabIndex = 6;
            this.cbak.Text = "Akuntasi";
            this.cbak.UseVisualStyleBackColor = true;
            // 
            // cbmt
            // 
            this.cbmt.AutoSize = true;
            this.cbmt.Location = new System.Drawing.Point(169, 77);
            this.cbmt.Name = "cbmt";
            this.cbmt.Size = new System.Drawing.Size(164, 17);
            this.cbmt.TabIndex = 5;
            this.cbmt.Text = "Manajemen Transportasi";
            this.cbmt.UseVisualStyleBackColor = true;
            // 
            // cbmb
            // 
            this.cbmb.AutoSize = true;
            this.cbmb.Location = new System.Drawing.Point(169, 54);
            this.cbmb.Name = "cbmb";
            this.cbmb.Size = new System.Drawing.Size(127, 17);
            this.cbmb.TabIndex = 4;
            this.cbmb.Text = "Manajemen Bisnis";
            this.cbmb.UseVisualStyleBackColor = true;
            // 
            // cblb
            // 
            this.cblb.AutoSize = true;
            this.cblb.Location = new System.Drawing.Point(169, 31);
            this.cblb.Name = "cblb";
            this.cblb.Size = new System.Drawing.Size(107, 17);
            this.cblb.TabIndex = 3;
            this.cblb.Text = "Logistik Bisnis";
            this.cblb.UseVisualStyleBackColor = true;
            // 
            // cbsi
            // 
            this.cbsi.AutoSize = true;
            this.cbsi.Location = new System.Drawing.Point(6, 77);
            this.cbsi.Name = "cbsi";
            this.cbsi.Size = new System.Drawing.Size(118, 17);
            this.cbsi.TabIndex = 2;
            this.cbsi.Text = "Sistem Informasi";
            this.cbsi.UseVisualStyleBackColor = true;
            // 
            // cbmi
            // 
            this.cbmi.AutoSize = true;
            this.cbmi.Location = new System.Drawing.Point(6, 54);
            this.cbmi.Name = "cbmi";
            this.cbmi.Size = new System.Drawing.Size(157, 17);
            this.cbmi.TabIndex = 1;
            this.cbmi.Text = "Manajemen Informatika";
            this.cbmi.UseVisualStyleBackColor = true;
            // 
            // cbti
            // 
            this.cbti.AutoSize = true;
            this.cbti.Location = new System.Drawing.Point(6, 31);
            this.cbti.Name = "cbti";
            this.cbti.Size = new System.Drawing.Size(132, 17);
            this.cbti.TabIndex = 0;
            this.cbti.Text = "Teknik Informatika";
            this.cbti.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rbs1);
            this.groupBox1.Controls.Add(this.rbd4);
            this.groupBox1.Controls.Add(this.rbd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan  ";
            // 
            // rbs1
            // 
            this.rbs1.AutoSize = true;
            this.rbs1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbs1.Location = new System.Drawing.Point(6, 79);
            this.rbs1.Name = "rbs1";
            this.rbs1.Size = new System.Drawing.Size(104, 19);
            this.rbs1.TabIndex = 6;
            this.rbs1.Text = "STRATA 1 (S1)";
            this.rbs1.UseVisualStyleBackColor = true;
            this.rbs1.CheckedChanged += new System.EventHandler(this.rbs1_CheckedChanged);
            // 
            // rbd4
            // 
            this.rbd4.AutoSize = true;
            this.rbd4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd4.Location = new System.Drawing.Point(6, 54);
            this.rbd4.Name = "rbd4";
            this.rbd4.Size = new System.Drawing.Size(124, 19);
            this.rbd4.TabIndex = 5;
            this.rbd4.Text = "DIPLOMA IV  (D4)";
            this.rbd4.UseVisualStyleBackColor = true;
            this.rbd4.CheckedChanged += new System.EventHandler(this.rbd4_CheckedChanged);
            // 
            // rbd3
            // 
            this.rbd3.AutoSize = true;
            this.rbd3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd3.Location = new System.Drawing.Point(6, 29);
            this.rbd3.Name = "rbd3";
            this.rbd3.Size = new System.Drawing.Size(121, 19);
            this.rbd3.TabIndex = 4;
            this.rbd3.Text = "DIPLOMA III (D3)";
            this.rbd3.UseVisualStyleBackColor = true;
            this.rbd3.CheckedChanged += new System.EventHandler(this.rbd3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memilih Program Studi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 10);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIVERSITAS LOGISTIK DAN BISNIS INTERNASIONAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Biaya";
            // 
            // tbbiaya
            // 
            this.tbbiaya.Location = new System.Drawing.Point(371, 257);
            this.tbbiaya.Name = "tbbiaya";
            this.tbbiaya.Size = new System.Drawing.Size(100, 20);
            this.tbbiaya.TabIndex = 6;
            this.tbbiaya.TextChanged += new System.EventHandler(this.tbbiaya_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tampilkan Biaya";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormProgramstudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbbiaya);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormProgramstudi";
            this.Text = "FormProgramstudi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbds;
        private System.Windows.Forms.CheckBox cbec;
        private System.Windows.Forms.CheckBox cbak;
        private System.Windows.Forms.CheckBox cbmt;
        private System.Windows.Forms.CheckBox cbmb;
        private System.Windows.Forms.CheckBox cblb;
        private System.Windows.Forms.CheckBox cbsi;
        private System.Windows.Forms.CheckBox cbmi;
        private System.Windows.Forms.CheckBox cbti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbs1;
        private System.Windows.Forms.RadioButton rbd4;
        private System.Windows.Forms.RadioButton rbd3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbbiaya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}