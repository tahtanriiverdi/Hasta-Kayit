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
    public partial class Frmlabsonuc : Form
    {
        public Frmlabsonuc()
        {
            InitializeComponent();
        }

        public Hastalar Hastalar { get; set; }
        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        public Laboratuvarsonuc Laboratuvarsonuc { get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txttestad)) return;
            if (!ErrorControl(txttestsonuc)) return;
            if (!ErrorControl(txttarihlab)) return;

            Laboratuvarsonuc.Testad = txttestad.Text;
            Laboratuvarsonuc.Sonuc = txttestsonuc.Text;
            Laboratuvarsonuc.Tarih = txttarihlab.Value;

            DialogResult = DialogResult.OK;
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
    }
}
