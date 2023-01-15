using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Tugas_Besar_PBO.View
{
    public partial class FormProgramstudi : Form
    {
        Koneksi koneksi = new Koneksi();
        m_biaya m_bia = new m_biaya();
        m_biaya m_jnj = new m_biaya();
        public FormProgramstudi()
        {
            InitializeComponent();
        }

        private void cbds_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbd3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbd3.Checked)
            {
                cbti.Enabled = true; cbti.Checked = false;
                cbmi.Enabled = true; cbmi.Checked = false;
                cbsi.Enabled = true; cbsi.Checked = false;
                cblb.Enabled = true; cblb.Checked = false;
                cbmb.Enabled = true; cbmb.Checked = false;
                cbmt.Enabled = false; cbmt.Checked = false;
                cbak.Enabled = false; cbak.Checked = false;
                cbec.Enabled = false; cbec.Checked = false;
                cbds.Enabled = false; cbds.Checked = false;
            }
        }

        private void rbd4_CheckedChanged(object sender, EventArgs e)
        {
            cbti.Enabled = true; cbti.Checked = false;
            cbmi.Enabled = false; cbmi.Checked = false;
            cbsi.Enabled = false; cbsi.Checked = false;
            cblb.Enabled = true; cblb.Checked = false;
            cbmb.Enabled = true; cbmb.Checked = false;
            cbmt.Enabled = false; cbmt.Checked = false;
            cbak.Enabled = true; cbak.Checked = false;
            cbec.Enabled = true; cbec.Checked = false;
            cbds.Enabled = true; cbds.Checked = false;
        }

        private void rbs1_CheckedChanged(object sender, EventArgs e)
        {
            cbti.Enabled = false; cbti.Checked = false;
            cbmi.Enabled = false; cbmi.Checked = false;
            cbsi.Enabled = false; cbsi.Checked = false;
            cblb.Enabled = true; cblb.Checked = false;
            cbmb.Enabled = true; cbmb.Checked = false;
            cbmt.Enabled = true; cbmt.Checked = false;
            cbak.Enabled = true; cbak.Checked = false;
            cbec.Enabled = true; cbec.Checked = false;
            cbds.Enabled = true; cbds.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbd4.Checked || rbs1.Checked)
            {
                CheckBox[] pilihan = new CheckBox[9];
                int[] angka = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                pilihan[0] = cbti;
                pilihan[1] = cbmi;
                pilihan[2] = cbsi;
                pilihan[3] = cblb;
                pilihan[4] = cbmb;
                pilihan[5] = cbmt;
                pilihan[6] = cbak;
                pilihan[7] = cbec;
                pilihan[8] = cbds;
                int d3;
                d3 = 2000000;
                int harga1 = 7200000;
                int harga2 = 5600000;
                int harga3 = 5650000;
                int harga4 = 7000000;
                int harga5 = 7200000;
                int harga6 = 7000000;
                int harga7 = 7150000;
                int harga8 = 6900000;
                int harga9 = 7050000;
                int total = 0;
                int studid3 = 6;
                int studid4 = 8;

                {
                    if (pilihan[0].Checked)
                    {
                        total += harga1;
                    }
                    if (pilihan[1].Checked)
                    {
                        total += harga2;
                    }
                    if (pilihan[2].Checked)
                    {
                        total += harga3;
                    }
                    if (pilihan[3].Checked)
                    {
                        total += harga4;
                    }
                    if (pilihan[4].Checked)
                    {
                        total += harga5;
                    }
                    if (pilihan[5].Checked)
                    {
                        total += harga6;
                    }
                    if (pilihan[6].Checked)
                    {
                        total += harga7;
                    }
                    if (pilihan[7].Checked)
                    {
                        total += harga8;
                    }
                    if (pilihan[8].Checked)
                    {
                        total += harga9;
                    }
                    tbbiaya.Text = total.ToString();

                }

            }
            else
            {
                CheckBox[] pilihan = new CheckBox[9];
                int[] angka = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                pilihan[0] = cbti;
                pilihan[1] = cbmi;
                pilihan[2] = cbsi;
                pilihan[3] = cblb;
                pilihan[4] = cbmb;
                pilihan[5] = cbmt;
                pilihan[6] = cbak;
                pilihan[7] = cbec;
                pilihan[8] = cbds;
                int d3;
                d3 = 2000000;
                int harga1 = 7200000;
                int harga2 = 5600000;
                int harga3 = 5650000;
                int harga4 = 7000000;
                int harga5 = 7200000;
                int harga6 = 7000000;
                int harga7 = 7150000;
                int harga8 = 6900000;
                int harga9 = 7050000;
                int total = 0;
                int studid3 = 6;
                int studid4 = 8;

                {
                    if (pilihan[0].Checked)
                    {
                        total += harga1 - d3;
                    }
                    if (pilihan[1].Checked)
                    {
                        total += harga2;
                    }
                    if (pilihan[2].Checked)
                    {
                        total += harga3;
                    }
                    if (pilihan[3].Checked)
                    {
                        total += harga4 - d3;
                    }
                    if (pilihan[4].Checked)
                    {
                        total += harga5 - d3;
                    }
                    if (pilihan[5].Checked)
                    {
                        total += harga6;
                    }
                    if (pilihan[6].Checked)
                    {
                        total += harga7;
                    }
                    if (pilihan[7].Checked)
                    {
                        total += harga8;
                    }
                    if (pilihan[8].Checked)
                    {
                        total += harga9;
                    }
                    tbbiaya.Text = total.ToString();

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Biaya biaya = new Biaya();
            if (rbd3.Checked)
            {
                m_bia.Jenjang = rbd3.Text;
            }else if(rbd4.Checked)
            {
                m_bia.Jenjang = rbd4.Text;
            }else if (rbs1.Checked)
            {
                m_bia.Jenjang = rbs1.Text;
            }
            else
            {

            }
            if (cbak.Checked)
            {
                m_bia.Studi = cbak.Text;
            }
            else if (cbti.Checked)
            {
                m_bia.Studi = cbti.Text;
            }
            else if (cbmi.Checked)
            {
                m_bia.Studi = cbmi.Text;
            }
            else if (cbsi.Checked)
            {
                m_bia.Studi = cbsi.Text;
            }
            else if (cblb.Checked)
            {
                m_bia.Studi = cblb.Text;
            }
            else if (cbmb.Checked)
            {
                m_bia.Studi = cbmb.Text;
            }
            else if (cbmt.Checked)
            {
                m_bia.Studi = cbmt.Text;
            }
            else if (cbec.Checked)
            {
                m_bia.Studi = cbec.Text;
            }
            else if (cbds.Checked)
            {
                m_bia.Studi = cbds.Text;
            }
            else
            {

            }

            m_bia.Biaya = tbbiaya.Text;




            biaya.Insert(m_bia);

            rbd3.Checked = false;
            rbd4.Checked = false;
            rbs1.Checked = false;
            cbak.Checked = false;
            tbbiaya.Text = "";
            

            cbti.Checked = false;
            cbmi.Checked = false;
            cbsi.Checked = false;
            cblb.Checked = false;
            cbmb.Checked = false;
            cbmt.Checked = false;
            cbec.Checked = false;
            cbds.Checked = false;
            Show();
        }

        private void tbbiaya_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
