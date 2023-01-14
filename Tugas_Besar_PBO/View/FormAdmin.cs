using MySql.Data.MySqlClient;
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
    public partial class FormAdmin : Form
    {
        Koneksi koneksi = new Koneksi();
        //m_admin m_adm = new m_admin();
        //m_register m_reg = new m_register();
        m_biodata m_bio = new m_biodata();
       // m_prestasi m_pres = new m_prestasi();   
        string id;

        public void Tampil()
        {
            //Query DB
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM pendaftaran");
            /*DataMahasiswa.DataSource = koneksi.ShowData("SELECT id, nama, jenis_kelamin, pendaftaran.nisn, tahun_lulus,alamat, email, no_hp "
            + "FROM pendaftaran JOIN t_prestasi on t_prestasi.nisn = pendaftaran.nisn");*/
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM biodata ");



            //Mengubah Nama Kolom Tabel
            DataMahasiswa.Columns[0].HeaderText = "Id";
            DataMahasiswa.Columns[0].HeaderText = "Nama";
            DataMahasiswa.Columns[0].HeaderText = "TTL";
            DataMahasiswa.Columns[0].HeaderText = "Jenis Kelamin";
            DataMahasiswa.Columns[0].HeaderText = "Asal Sekolah";
            DataMahasiswa.Columns[0].HeaderText = "NISN";
            DataMahasiswa.Columns[0].HeaderText = "Tahun Lulus";
            DataMahasiswa.Columns[0].HeaderText = "Alamat";
            DataMahasiswa.Columns[0].HeaderText = "Email";
            DataMahasiswa.Columns[0].HeaderText = "No HP";
        }

        public FormAdmin()
        {
            InitializeComponent();
        }

       

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
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
                cbTa.SelectedIndex = -1;
                tbAlamat.Text = "";
                tbEmail.Text = "";
                tbNoHp.Text = "";

                Tampil();
            }
        }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTtl.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbJenisKelamin.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbAsalSekolah.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNisn.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbTa.Text = DataMahasiswa.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbNoHp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
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

                biodata.Update(m_bio, id);

                tbNama.Text = "";
                tbTtl.Text = "";
                cbJenisKelamin.SelectedIndex = -1;
                tbAsalSekolah.Text = "";
                tbNisn.Text = "";
                cbTa.SelectedIndex = -1;
                tbAlamat.Text = "";
                tbEmail.Text = "";
                tbNoHp.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Biodata biodata = new Biodata();
            biodata.Delete(id);

            tbNama.Text = "";
            tbTtl.Text = "";
            cbJenisKelamin.SelectedIndex = -1;
            tbAsalSekolah.Text = "";
            tbNisn.Text = "";
            cbTa.SelectedIndex = -1;
            tbAlamat.Text = "";
            tbEmail.Text = "";
            tbNoHp.Text = "";

            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbNama.Text = "";
            tbTtl.Text = "";
            cbJenisKelamin.SelectedIndex = -1;
            tbAsalSekolah.Text = "";
            tbNisn.Text = "";
            cbTa.SelectedIndex = -1;
            tbAlamat.Text = "";
            tbEmail.Text = "";
            tbNoHp.Text = "";

            Tampil();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM pendaftaran WHERE nama LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%'");
        }
    }
}
