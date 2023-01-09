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
    public partial class FormBiodata : Form
    {

        Koneksi koneksi = new Koneksi();
        m_biodata m_bio = new m_biodata();
        

        public FormBiodata()
        {
            InitializeComponent();
            this.Size = new Size(1237, 853);
        }

        private void FormBiodata_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbTtl.Text == "" || cbJenisKelamin.SelectedIndex == -1 || tbAsalSekolah.Text == "" || tbNisn.Text == "" || cbTa.SelectedIndex == -1 || tbAlamat.Text == "" || tbEmail.Text == "" || tbNoHp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Biodata biodata = new Biodata();
                m_bio.Nama = tbNama.Text;
                m_bio.Ttl = tbTtl.Text;
                m_bio.Jenis_kelamin = cbJenisKelamin.Text;
                m_bio.Asal_sekolah = tbAsalSekolah.Text;
                m_bio.Nisn = tbNisn.Text;
                m_bio.Tahun_lulus = cbTa.Text;
                m_bio.Alamat = tbAlamat.Text;
                m_bio.Email = tbEmail.Text;
                m_bio.No_hp = tbNoHp.Text;

                biodata.Insert(m_bio);

                tbNama.Text = "";
                tbTtl.Text = "";
                cbJenisKelamin.SelectedIndex = -1;
                tbAsalSekolah.Text = "";
                tbNisn.Text = "";
                cbTa.SelectedIndex = -1 ;
                tbAlamat.Text = "";
                tbEmail.Text = "";
                tbNoHp.Text = "";

                Show();
            }
        }
    }
}

