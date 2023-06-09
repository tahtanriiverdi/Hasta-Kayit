using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TahaProjehastakyt.BL;
using TahaProjehastakyt.UI;

namespace TahaProjehastakyt
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        
        Hastalarr mf = new Hastalarr();

        Doktorlarr uf= new Doktorlarr();
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frmtedavitarih frm = new Frmtedavitarih()
            {
                Text = "Randevu al",
                Tedavitarih= new Tedavitarih()
                {
                    ID=Guid.NewGuid()
                }
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.RandevuEkle(frm.Tedavitarih);

                if (b)
                {
                    DataSet ds1 = BLogic.RandevuDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnRandevuduzenle(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Frmtedavitarih frm = new Frmtedavitarih()
            {
                Text = "Randevu Güncelle",
                Guncelleme = true,
                Tedavitarih = new Tedavitarih()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    HastalarimizID = Guid.Parse(row.Cells[1].Value.ToString()),
                    DoktorlarimizID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Tarih =DateTime.Parse(row.Cells[7].Value.ToString()),
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.RandevuGuncelle(frm.Tedavitarih);

                if (b)
                {
                    row.Cells[1].Value = frm.Tedavitarih.HastalarimizID;
                    row.Cells[2].Value = frm.Tedavitarih.DoktorlarimizID;
                    row.Cells[7].Value = frm.Tedavitarih.Tarih;
                }
            }
        }

        private void btnRandevusil(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.RandevuSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.RandevuDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }

        private void btnRandevubul(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.RandevuDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}
