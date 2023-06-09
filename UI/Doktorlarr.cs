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

namespace TahaProjehastakyt.UI
{
    public partial class Doktorlarr : Form
    {
        public Doktorlarr()
        {
            InitializeComponent();
        }
        private void btnDoktorekle_Click(object sender, EventArgs e)
        {
            FrmDoktor frm = new FrmDoktor()
            {
                Text = "Doktor ekle",
                Doktorlar = new Doktorlar()
                {
                    ID = Guid.NewGuid()
                }
            };
        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.DoktorEkle(frm.Doktorlar);

                if (b)
                {
                    DataSet ds = BLogic.Doktorgetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnDoktorbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Doktorgetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnDoktorduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmDoktor frm = new FrmDoktor()
            {
                Text = "Doktor Güncelle",
                Guncelleme = true,
                Doktorlar = new Doktorlar()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Brans = row.Cells[3].Value.ToString(),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.DoktorGuncelle(frm.Doktorlar);

                if (b)
                {
                    row.Cells[1].Value = frm.Doktorlar.Ad;
                    row.Cells[2].Value = frm.Doktorlar.Soyad;
                    row.Cells[3].Value = frm.Doktorlar.Brans;
                }
            }
        }

        private void btnDoktorsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.DoktorSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.Doktorgetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
            }
        }

        private void Doktorlarr_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.Doktorgetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }
            
        public Doktorlar Doktorlar { get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            Doktorlar = new Doktorlar()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                Brans = row.Cells[3].Value.ToString(),

            };
            DialogResult= DialogResult.OK;
        }

        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }

}
