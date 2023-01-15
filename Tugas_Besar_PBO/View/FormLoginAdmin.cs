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

namespace Tugas_Besar_PBO.View
{
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        string koneksi = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_tubes_pbo;";

        public void login1()
        {
            string query = "SELECT * FROM admin WHERE username='" + tbUsername.Text + "' AND password='" + tbPassword.Text + "'";

            // Connecting MySql
            MySqlConnection databaseConnection = new MySqlConnection(koneksi);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login Admin Berhasil");
                    FormDashboardAdmin fa = new FormDashboardAdmin();
                    fa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / Password salah, silahkan ulangi kembali");
                }
                databaseConnection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Silahkan coba kembali");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                if (tbPassword.Text != "")
                {
                    login1();
                }
                else
                {
                    MessageBox.Show("Password tidak boleh kosong", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Username tidak boleh kosong", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegisterAdmin fra = new FormRegisterAdmin();
            fra.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart fl = new FormStart();
            fl.Show();
            this.Hide();
        }
    }
}
