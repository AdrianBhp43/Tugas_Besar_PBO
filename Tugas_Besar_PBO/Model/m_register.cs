using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tugas_Besar_PBO.Model
{
    internal class m_register
    {
        string nama, username, password;

        public m_register()
        {

        }

        public m_register(string nama, string username, string password)
        {
           
            this.Nama = nama;
            this.Username = username;
            this.Password = password;   
        }

        public string Nama { get => nama; set => nama = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
