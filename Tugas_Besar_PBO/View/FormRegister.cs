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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tugas_Besar_PBO.View
{
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();
        m_register m_reg = new m_register();
        string id;
        public FormRegister()
        {
            InitializeComponent();
        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            Show();
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
                Register register = new Register();
                m_reg.Nama = tbNama.Text;
                m_reg.Username = tbUser.Text;
                m_reg.Password = tbPasswordd.Text;


                register.Insert(m_reg);

                tbNama.Text = "";
                tbUser.Text = "";
                tbPasswordd.Text = "";

                Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            FormLogin fl = new FormLogin();
            fl.Show();
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
