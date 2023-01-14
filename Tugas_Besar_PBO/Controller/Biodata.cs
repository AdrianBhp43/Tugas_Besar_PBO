using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Biodata
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(m_biodata biodata)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO pendaftaran (nama, ttl, jenis_kelamin, asal_sekolah, nisn, tahun_lulus, alamat, email, no_hp) " +
                    "VALUES('" + biodata.Nama + "', '" + biodata.Ttl + "','" + biodata.Jenis_kelamin + "','" + biodata.Asal_sekolah + "', '" +
                biodata.Nisn + "','" + biodata.Tahun_lulus + "','" + biodata.Alamat + "', '" +
                biodata.Email + "','" + biodata.No_hp + "')");
                status = true;
                MessageBox.Show("Input Behasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(m_biodata biodata, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE pendaftaran SET id='" + biodata.Id + "', " + "nama='" + biodata.Nama + "'," + "ttl='" + biodata.Ttl + "'," + "jenis_kelamin='" +biodata.Jenis_kelamin + "'," + "asal_sekolah='" +
                    biodata.Asal_sekolah + "', " + "nisn='" + biodata.Nisn + "'," + "tahun_lulus='" + biodata.Tahun_lulus + "'," + "alamat='" +
                    biodata.Alamat + "'," +"email='" + biodata.Email + "'," + "no_hp='" + biodata.No_hp + "'WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Update Behasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM pendaftaran WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Delete Behasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
