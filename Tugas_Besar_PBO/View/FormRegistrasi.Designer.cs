namespace Tugas_Besar_PBO.View
{
    partial class FormRegistrasi
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPasswordd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(104, 63);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(249, 20);
            this.tbNama.TabIndex = 0;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(104, 110);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(249, 20);
            this.tbUser.TabIndex = 1;
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Location = new System.Drawing.Point(159, 208);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(114, 45);
            this.btnRegistrasi.TabIndex = 2;
            this.btnRegistrasi.Text = "Daftar";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // tbPasswordd
            // 
            this.tbPasswordd.Location = new System.Drawing.Point(104, 157);
            this.tbPasswordd.Name = "tbPasswordd";
            this.tbPasswordd.Size = new System.Drawing.Size(249, 20);
            this.tbPasswordd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registrasi";
            // 
            // FormRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPasswordd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbNama);
            this.Name = "FormRegistrasi";
            this.Text = "FormRegistrasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPasswordd;
        private System.Windows.Forms.Label label5;
    }
}