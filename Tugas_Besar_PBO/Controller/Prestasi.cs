using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Prestasi
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(m_prestasi prestasi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_prestasi (nama_kegiatan, tingkat, tahun_perolehan, pencapaian) VALUES('" +
                prestasi.Nama_kegiatan + "', '" + prestasi.Jenis_kegiatan + "', '" + prestasi.Tingkat + "','" + prestasi.Tahun_perolehan + "','" + prestasi.Pencapaian + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;

         } 
    }
}
