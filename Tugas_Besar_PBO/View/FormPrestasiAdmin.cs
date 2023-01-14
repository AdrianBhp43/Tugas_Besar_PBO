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
        string id;

        public void Tampil()
        {
            //Query DB
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_prestasi");
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT t_prestasi.nisn ,nama,nama_kegiatan ,jenis_kegiatan, tingkat, tahun_perolehan,alamat, pencapaian"
            + " FROM t_prestasi JOIN pendaftaran on pendaftaran.nisn = t_prestasi.nisn");
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM biodata ");



            //Mengubah Nama Kolom Tabel
            //DataMahasiswa.Columns[0].HeaderText = "Id";
            //DataMahasiswa.Columns[0].HeaderText = "Id Prestasi";
            DataMahasiswa.Columns[0].HeaderText = "NISN";
            DataMahasiswa.Columns[0].HeaderText = "Nama";
            DataMahasiswa.Columns[0].HeaderText = "Nama Kegiatan";
            DataMahasiswa.Columns[0].HeaderText = "Jenis Kegiatan";
            DataMahasiswa.Columns[0].HeaderText = "Tingkat";
            DataMahasiswa.Columns[0].HeaderText = "Tahun Peroleh";
            DataMahasiswa.Columns[0].HeaderText = "Pencapaian";
        }
        public FormPrestasiAdmin()
        {
            InitializeComponent();
        }

        public void GetNisnPdf()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM pendaftaran");
            while (reader.Read())
            {
                tbNisn.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetNamaPdf()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM pendaftaran + " + 
                "WHERE nisn = '" + tbNisn.Text + "'");
            while (reader.Read())
            {
                tbNama.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void FormPrestasiAdmin_Load(object sender, EventArgs e)
        {
            Tampil();
            //GetNamaPdf();
            //GetNisnPdf();
        }
    }
}
