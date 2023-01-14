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
    public partial class FormPrestasiAdmin : Form
    {
        Koneksi koneksi = new Koneksi();
        //m_admin m_adm = new m_admin();
        //m_register m_reg = new m_register();
        m_biodata m_bio = new m_biodata();
        m_prestasi m_pres = new m_prestasi();

        public void Show()
        {
            //Query DB
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_prestasi");
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT t_prestasi.nisn ,nama,nama_kegiatan ,jenis_kegiatan, tingkat, tahun_perolehan, pencapaian"
            + " FROM t_prestasi JOIN pendaftaran on pendaftaran.nisn = t_prestasi.nisn");
            /*DataMahasiswa.DataSource = koneksi.ShowData("SELECT" + " t_prestasi.nisn, nama, nama_kegiatan ,jenis_kegiatan, tingkat, tahun_perolehan, pencapaian"
            + " FROM t_prestasi JOIN pendaftaran on pendaftaran.nisn = t_prestasi.nisn");*/


            DataMahasiswa.Columns[0].HeaderText = "NISN";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Nama Kegiatan";
            DataMahasiswa.Columns[3].HeaderText = "Jenis Kegiatan";
            DataMahasiswa.Columns[4].HeaderText = "Tingkat";
            DataMahasiswa.Columns[5].HeaderText = "Tahun Perolehan";
            DataMahasiswa.Columns[6].HeaderText = "Pencapaian";
        }
        public FormPrestasiAdmin()
        {
            InitializeComponent();
        }

        private void FormPrestasiAdmin_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (tbNamaKegiatan.Text == "" || cbTahunPerolehan.SelectedIndex == -1 || cbPencapaian.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                Prestasi prestasi = new Prestasi();
                m_pres.Nama_kegiatan = tbNamaKegiatan.Text;
                m_pres.Jenis_kegiatan = rbIndividual.Text;
                m_pres.Jenis_kegiatan = rbKelompok.Text;
                m_pres.Tingkat = rbKabupaten.Text;
                m_pres.Tingkat = rbProvinsi.Text;
                m_pres.Tingkat = rbNasional.Text;
                m_pres.Tingkat = rbInternasional.Text;
                m_pres.Tahun_perolehan = cbTahunPerolehan.Text;
                m_pres.Pencapaian = cbPencapaian.Text;

                prestasi.Insert(m_pres);

                tbNamaKegiatan.Text = "";
                rbIndividual.Checked = true;
                rbKelompok.Checked = true;
                rbKabupaten.Checked = true;
                rbProvinsi.Checked = true;
                rbNasional.Checked = true;
                rbInternasional.Checked = true;
                cbTahunPerolehan.SelectedIndex = -1;
                cbPencapaian.SelectedIndex = -1;

                Show();
            }
        }
    }
}
