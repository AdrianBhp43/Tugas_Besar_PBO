using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.View;

namespace Tugas_Besar_PBO
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pendaftaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiodata fb = new FormBiodata();
            fb.MdiParent = this;
            fb.Show();
        }

        private void tambahPrestasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputPrestasi fip = new FormInputPrestasi();
            fip.MdiParent = this;
            fip.Show();
        }
    }
}
