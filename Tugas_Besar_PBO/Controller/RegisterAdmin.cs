using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class RegisterAdmin
    {
        //Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(m_register_admin register_admin)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO admin(nama, username, password) VALUES('" + register_admin.Nama + "', '" +
                register_admin.Username + "','" + register_admin.Password + "')");
                status = true;
                MessageBox.Show("Register Behasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
