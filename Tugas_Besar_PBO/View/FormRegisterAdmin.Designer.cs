namespace Tugas_Besar_PBO.View
{
    partial class FormRegisterAdmin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPasswordd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(356, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 70);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Register Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // tbPasswordd
            // 
            this.tbPasswordd.Location = new System.Drawing.Point(158, 225);
            this.tbPasswordd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPasswordd.Multiline = true;
            this.tbPasswordd.Name = "tbPasswordd";
            this.tbPasswordd.PasswordChar = '*';
            this.tbPasswordd.Size = new System.Drawing.Size(372, 51);
            this.tbPasswordd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama";
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Location = new System.Drawing.Point(158, 302);
            this.btnRegistrasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(174, 70);
            this.btnRegistrasi.TabIndex = 14;
            this.btnRegistrasi.Text = "Daftar";
            this.btnRegistrasi.UseVisualStyleBackColor = true;
            this.btnRegistrasi.Click += new System.EventHandler(this.btnRegistrasi_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(158, 152);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(372, 51);
            this.tbUser.TabIndex = 13;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(158, 80);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(372, 51);
            this.tbNama.TabIndex = 12;
            // 
            // FormRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 419);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPasswordd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbNama);
            this.Name = "FormRegisterAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormRegisterAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPasswordd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbNama;
    }
}