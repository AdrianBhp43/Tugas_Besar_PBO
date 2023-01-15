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

        public void Tampilkan()
        {
            //Query DB
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_prestasi");
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT t_prestasi.nisn ,nama,nama_kegiatan ,jenis_kegiatan, tingkat, tahun_perolehan, pencapaian"
            //+ " FROM t_prestasi JOIN pendaftaran on pendaftaran.nisn = t_prestasi.nisn");
            DataPrestasi.DataSource = koneksi.ShowData("SELECT id, pendaftaran.nisn, nama, nama_kegiatan ,jenis_kegiatan, tingkat, tahun_perolehan, pencapaian"
            + " FROM pendaftaran JOIN t_prestasi on t_prestasi.nisn = pendaftaran.nisn");


            DataPrestasi.Columns[0].HeaderText = "NISN";
            DataPrestasi.Columns[1].HeaderText = "Nama";
            DataPrestasi.Columns[2].HeaderText = "Nama Kegiatan";
            DataPrestasi.Columns[3].HeaderText = "Jenis Kegiatan";
            DataPrestasi.Columns[4].HeaderText = "Tingkat";
            DataPrestasi.Columns[5].HeaderText = "Tahun Perolehan";
            DataPrestasi.Columns[6].HeaderText = "Pencapaian";
        }
        public FormPrestasiAdmin()
        {
            InitializeComponent();
        }

        private void FormPrestasiAdmin_Load(object sender, EventArgs e)
        {
            Tampilkan();
        }
    }
}
