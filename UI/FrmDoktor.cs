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
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void İptalbutonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Doktorlar Doktorlar { get; set; }
        public bool Guncelleme { get; set; } = false;

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtdoktorad)) return;
            if (!ErrorControl(txtdoktorsoyad)) return;
            if (!ErrorControl(Brans)) return;

            Doktorlar.Ad = txtdoktorad.Text;
            Doktorlar.Soyad= txtdoktorsoyad.Text;
            Doktorlar.Brans = Brans.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value ==0)
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

        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            txtID.Text = Doktorlar.ID.ToString();
            if (Guncelleme)
            {
                txtdoktorad.Text = Doktorlar.Ad;
                txtdoktorsoyad.Text = Doktorlar.Soyad;
                Brans.Text = Doktorlar.Brans;
            }
        }
    }
}
