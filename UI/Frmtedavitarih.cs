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
    public partial class Frmtedavitarih : Form
    {

        public Tedavitarih Tedavitarih { get; set; }

        public bool Guncelleme { get; set; } = false;
        public Frmtedavitarih()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(dtTarih)) return;

            Tedavitarih.Tarih = dtTarih.Value;
            Tedavitarih.HastalarimizID = Guid.Parse(txthasta.Text);
            Tedavitarih.DoktorlarimizID = Guid.Parse(txtdoktor.Text);

            DialogResult = DialogResult.OK;
        }

        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
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
            return true;
        }
        private void Frmtedavitarih_Load(object sender, EventArgs e)
        {
            txtID.Text =Tedavitarih.ID.ToString();
            if (Guncelleme)
            {
                txthasta.Text=Tedavitarih.HastalarimizID.ToString();
                txtdoktor.Text=Tedavitarih.DoktorlarimizID.ToString();
                dtTarih.Value = Tedavitarih.Tarih;
            }
        }

        private void btnHastasec_Click(object sender, EventArgs e)
        {
            Hastalarr frm = new Hastalarr();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txthasta.Text = frm.Hastalar.ID.ToString();
            }

        }

        private void btndoktorsec_Click(object sender, EventArgs e)
        {
            Doktorlarr frm = new Doktorlarr();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtdoktor.Text = frm.Doktorlar.ID.ToString();
            }
        }
    }
}
