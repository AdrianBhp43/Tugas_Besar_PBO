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
            this.DataPrestasi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataPrestasi)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPrestasi
            // 
            this.DataPrestasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPrestasi.Location = new System.Drawing.Point(9, 9);
            this.DataPrestasi.Name = "DataPrestasi";
            this.DataPrestasi.RowHeadersWidth = 62;
            this.DataPrestasi.Size = new System.Drawing.Size(670, 161);
            this.DataPrestasi.TabIndex = 26;
            // 
            // FormPrestasiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 180);
            this.Controls.Add(this.DataPrestasi);
            this.Name = "FormPrestasiAdmin";
            this.Text = "FormPrestasiAdmin";
            this.Load += new System.EventHandler(this.FormPrestasiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPrestasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataPrestasi;
    }
}