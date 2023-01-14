using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tugas_Besar_PBO.Model
{
    internal class m_biodata
    {
        string id, nama, ttl, jenis_kelamin, asal_sekolah, nisn, tahun_lulus, alamat, email, no_hp;
        public m_biodata()
        {
        }

        public m_biodata(string id, string nama, string ttl, string jenis_kelamin, string asal_sekolah, string nisn, string tahun_lulus, string alamat, string email, string no_hp)
        {
            this.id = id;
            this.nama = nama;
            this.ttl = ttl;
            this.jenis_kelamin = jenis_kelamin;
            this.asal_sekolah = asal_sekolah;
            this.nisn = nisn;
            this.tahun_lulus = tahun_lulus;
            this.alamat = alamat;
            this.email = email;
            this.no_hp = no_hp;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Ttl { get => ttl; set => ttl = value; }
        public string Jenis_kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public string Asal_sekolah { get => asal_sekolah; set => asal_sekolah = value; }
        public string Nisn { get => nisn; set => nisn = value; }
        public string Tahun_lulus { get => tahun_lulus; set => tahun_lulus = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }

    }
}

