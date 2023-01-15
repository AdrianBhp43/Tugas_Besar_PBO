using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_PBO.View
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void dataCalonMahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.MdiParent = this;
            fa.Show();
        }

        private void dataPrestasiMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestasiAdmin fpa = new FormPrestasiAdmin();
            fpa.MdiParent = this;
            fpa.Show();
        }

        private void dataPembiayaanMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiAdmin fps = new FormTransaksiAdmin();
            fps.MdiParent = this;
            fps.Show();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
