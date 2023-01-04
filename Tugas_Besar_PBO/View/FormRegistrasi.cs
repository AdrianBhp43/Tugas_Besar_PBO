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
    public partial class FormRegistrasi : Form
    {
        public FormRegistrasi()
        {
            InitializeComponent();
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbUser.Text == "" || tbPasswordd.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang brg = new Barang();
                m_brg.barang = tbNamaBarang.Text;
                m_brg.hrg = tbHarga.Text;

                brg.Insert(m_brg);

                tbNamaBarang.Text = "";
                tbHarga.Text = "";

                Show();
            }
        }
    }
}
