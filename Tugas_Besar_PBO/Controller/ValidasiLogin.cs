using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_PBO.Controller
{
     class ValidasiLogin
    {
        Koneksi koneksi = new Koneksi();

        public bool validasi_login(string username, string password)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM user WHERE username='" +
                    username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi.CloseConnection();
            return false;
        }
    }
}
