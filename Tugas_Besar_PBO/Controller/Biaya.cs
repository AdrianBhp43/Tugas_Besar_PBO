using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Biaya
    {
        Koneksi koneksi = new Koneksi();
        public bool Insert(m_biaya biaya)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO biaya (jenjang, studi, biaya) " +
                    "VALUES('" + biaya.Jenjang + "', '" + biaya.Studi + "','" + biaya.Biaya + "')");
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
    }
}