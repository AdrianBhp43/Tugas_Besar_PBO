using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class FormRegisterAdmin : Form
    {

        Koneksi koneksi = new Koneksi();
        m_register_admin m_regadmin = new m_register_admin();
        string id;
        public FormRegisterAdmin()
        {
            InitializeComponent();
        }

        private void FormRegisterAdmin_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbUser.Text == "" || tbPasswordd.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RegisterAdmin register = new RegisterAdmin();
                m_regadmin.Nama = tbNama.Text;
                m_regadmin.Username = tbUser.Text;
                m_regadmin.Password = tbPasswordd.Text;


                register.Insert(m_regadmin);

                tbNama.Text = "";
                tbUser.Text = "";
                tbPasswordd.Text = "";

                Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin fla = new FormLoginAdmin();
            fla.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart fl = new FormStart();
            fl.Show();
            this.Hide();
        }
    }
}

