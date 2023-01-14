using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_PBO.Model
{
    internal class m_biaya
    {
        string jenjang, studi,
        biaya;
        public m_biaya()
        {
        }
        public m_biaya(string jenjang, string studi, string biaya)
        {
            this.jenjang = jenjang;
            this.studi = studi;
            this.biaya = biaya;
        }
        public string Jenjang { get => jenjang; set => jenjang = value; }
        public string Studi { get => studi; set => studi = value; }
        public string Biaya { get => biaya; set => biaya = value; }
    }
}