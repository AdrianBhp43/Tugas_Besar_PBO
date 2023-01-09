using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class FormInputPrestasi : Form
    {
        Koneksi koneksi = new Koneksi();
        m_prestasi m_pres = new m_prestasi();

        public FormInputPrestasi()
        {
            InitializeComponent();
        }

        private void FormInputPrestasi_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNamaKegiatan.Text == "" || rbIndividual.Checked || rbKelompok.Checked || rbKabupaten.Checked || rbProvinsi.Checked || rbNasional.Checked || rbInternasional.Checked || cbTahunPerolehan.SelectedIndex == -1 || cbPencapaian.SelectedIndex == -1 )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string Jenis_kegiatan = null;
                if (rbIndividual.Checked)
                {
                    Jenis_kegiatan = rbIndividual.Text;
                }
                else
                {
                    Jenis_kegiatan = rbKelompok.Text;
                }

                string Tingkat = null;

                if (rbKabupaten.Checked)
                {
                    Tingkat = rbKabupaten.Text;
                }
                else if (rbProvinsi.Checked)
                {
                    Tingkat = rbProvinsi.Text;
                }
                else if (rbNasional.Checked)
                {
                    Tingkat = rbNasional.Text;
                }
                else
                {
                    Tingkat = rbNasional.Text;
                }

            }
            else
            {
                Prestasi prestasi = new Prestasi();
                m_pres.Nama_kegiatan = tbNamaKegiatan.Text;
                m_pres.Jenis_kegiatan = rbIndividual.Text;
                m_pres.Jenis_kegiatan = rbKelompok.Text;
                m_pres.Tingkat = rbKabupaten.Text;
                m_pres.Tingkat = rbProvinsi.Text;
                m_pres.Tingkat = rbNasional.Text;
                m_pres.Tingkat = rbInternasional.Text;
                m_pres.Tahun_perolehan = cbTahunPerolehan.Text;
                m_pres.Pencapaian = cbPencapaian.Text;

                prestasi.Insert(m_pres);

                tbNamaKegiatan.Text = "";
                rbIndividual.Checked = true;
                rbKelompok.Checked = true;
                rbKabupaten.Checked = true;
                rbProvinsi.Checked = true;
                rbNasional.Checked = true;
                rbInternasional.Checked = true;
                cbTahunPerolehan.SelectedIndex = -1;
                cbPencapaian.SelectedIndex = -1 ;

                Show();
            }
        }
    }
}
