using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tugas_Besar_PBO.Model
{
    internal class m_prestasi
    {
        string nama_kegiatan,jenis_kegiatan, tingkat, tahun_perolehan, pencapaian;

        public m_prestasi()
        {

        }

        public m_prestasi(string nama_kegiatan, string jenis_kegiatan, string tingkat, string tahun_perolehan, string pencapaian)
        {
            this.nama_kegiatan = nama_kegiatan;
            this.jenis_kegiatan = jenis_kegiatan;
            this.tingkat = tingkat;
            this.tahun_perolehan = tahun_perolehan;
            this.pencapaian = pencapaian;
        }

        public string Nama_kegiatan { get => nama_kegiatan; set => nama_kegiatan = value; }
        public string Jenis_kegiatan { get => jenis_kegiatan; set => jenis_kegiatan = value; }
        public string Tingkat { get => tingkat; set => tingkat = value; }
        public string Tahun_perolehan { get => tahun_perolehan; set => tahun_perolehan = value; }
        public string Pencapaian { get => pencapaian; set => pencapaian = value; }
    }
}
