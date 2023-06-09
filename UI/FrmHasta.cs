using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahaProjehastakyt.UI
{
    public partial class FrmHasta : Form
    {
        public Doktorlar Doktorlar { get; set; }

        public bool Guncelleme { get; set; } = false;
        public FrmHasta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        public Hastalar Hastalar { get; set; }

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtdoktor)) return;
            if (!ErrorControl(txtodano)) return;
            if (!ErrorControl(txtyatakno)) return;
            //doktor id hata verirse geri dön buraya

            Hastalar.Ad = txtAd.Text;
            Hastalar.Soyad = txtSoyad.Text;
            Hastalar.doktorid = txtdoktor.Text;
            Hastalar.Odano = txtodano.Text;
            Hastalar.Yatakno = txtyatakno.Text;

            //burda hata alıyoruz neden?

            Hastalar.DoktorlarimizID = Guid.Parse(txtdoktor.Text);

            DialogResult = DialogResult.OK;
        }

        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            // frmhatasını kontrol et videodan
            return true;
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            txtID.Text = Hastalar.ID.ToString();
            if (Guncelleme)
            {
                txtAd.Text = Hastalar.Ad;
                txtSoyad.Text= Hastalar.Soyad;
                txtdoktor.Text = Hastalar.doktorid;
                txtodano.Text = Hastalar.Odano;
                txtyatakno.Text = Hastalar.Yatakno;
            }//ters çevir
            else
            {

            }
        }

        private void btnHastasec_Click(object sender, EventArgs e)
        {
            Doktorlarr frm = new Doktorlarr();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtdoktor.Text = frm.Doktorlar.ID.ToString();
            }
        }
    }
}
