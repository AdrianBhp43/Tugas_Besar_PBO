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
    public partial class FormTransaksiAdmin : Form
    {
        Koneksi koneksi = new Koneksi();
        //m_admin m_adm = new m_admin();
        //m_register m_reg = new m_register();
        m_biaya m_bia = new m_biaya();
        m_biodata m_bio = new m_biodata();
        m_prestasi m_pres = new m_prestasi();
        string id;

        public void Tampilkan()
        {
            //Query DB
            //DataTransaksi.DataSource = koneksi.ShowData("SELECT id_prodi,nama,jenjang");
            DataTransaksi.DataSource = koneksi.ShowData("SELECT * FROM biaya ");
            //DataTransaksi.DataSource = koneksi.ShowData("SELECT id_prodi, biaya.id_biaya,nama,jenjang ,studi, biaya FROM biaya JOIN pendaftaran on pendaftaran.id_biaya = biaya.id_biaya");
            //DataTransaksi.DataSource = koneksi.ShowData("SELECT id, pendaftaran.nisn,"
            //+ " FROM pendaftaran JOIN t_prestasi on t_prestasi.nisn = pendaftaran.nisn");
            //DataTransaksi.DataSource = koneksi.ShowData("SELECT id_prodi, jenjang, studi, pendaftaran.id_biaya, nama, biaya " +
              //  "FROM biaya JOIN pendaftaran on pendaftaran.id_biaya = biaya.id_biaya.");


            DataTransaksi.Columns[0].HeaderText = "ID Prodi";
            DataTransaksi.Columns[1].HeaderText = "Jenjang";
            DataTransaksi.Columns[2].HeaderText = "Studi";
            DataTransaksi.Columns[3].HeaderText = "Biaya";
        }
        public FormTransaksiAdmin()
        {
            InitializeComponent();
        }

         public void GetNama()
        {
            //ambil data Nama Barang ketika combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM pendaftaran ");
            while (reader.Read())
            {
                //cbNama.Items.Add(reader.GetString("nama"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }



        private void FormTransaksiAdmin_Load(object sender, EventArgs e)
        {
            Tampilkan();
            //GetNama();
        }
    }
}
