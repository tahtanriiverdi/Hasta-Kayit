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
    public partial class Hastalarr : Form
    {
        public Hastalarr()
        {
            InitializeComponent();
        }
        private void btnHastaekle_Click(object sender, EventArgs e)
        {
            FrmHasta frmHasta = new FrmHasta()
            {
                Text = "Hasta Ekle",
                Hastalar = new Hastalar() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frmHasta.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HastaEkle(frmHasta.Hastalar);

                if (b)
                {
                    DataSet ds = BLogic.Hastagetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnHastaduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmHasta frmHasta = new FrmHasta()
            {
                Text = "Hasta Güncelle",
                Guncelleme = true,
                Hastalar = new Hastalar()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    doktorid = row.Cells[3].Value.ToString(),
                    Odano = row.Cells[4].Value.ToString(),
                    Yatakno = row.Cells[5].Value.ToString(),

                },
            };

            var sonuc = frmHasta.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HastaGuncelle(frmHasta.Hastalar);

                if (b)
                {
                    row.Cells[1].Value = frmHasta.Hastalar.Ad;
                    row.Cells[2].Value = frmHasta.Hastalar.Soyad;
                    row.Cells[3].Value = frmHasta.Hastalar.doktorid;
                    row.Cells[4].Value = frmHasta.Hastalar.Odano;
                    row.Cells[5].Value = frmHasta.Hastalar.Yatakno;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Hastagetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Hastagetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnHastasil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HastaSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.Hastagetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }

        private void Hastalarr_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.Hastagetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Hastalar Hastalar { get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Hastalar = new Hastalar()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Soyad = row.Cells[2].Value.ToString(),
                doktorid = row.Cells[3].Value.ToString(),
                Odano = row.Cells[4].Value.ToString(),
                Yatakno = row.Cells[5].Value.ToString(),

            };
            DialogResult = DialogResult.OK;
        }

        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
