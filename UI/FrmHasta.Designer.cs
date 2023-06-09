namespace TahaProjehastakyt.UI
{
    partial class FrmHasta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtodano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyatakno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdoktor = new System.Windows.Forms.TextBox();
            this.Tamambutonu = new System.Windows.Forms.Button();
            this.İptalbutonu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHastasec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 22);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(88, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 88);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(248, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda no";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtodano
            // 
            this.txtodano.Location = new System.Drawing.Point(88, 116);
            this.txtodano.Name = "txtodano";
            this.txtodano.Size = new System.Drawing.Size(248, 22);
            this.txtodano.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yatak no";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtyatakno
            // 
            this.txtyatakno.Location = new System.Drawing.Point(88, 144);
            this.txtyatakno.Name = "txtyatakno";
            this.txtyatakno.Size = new System.Drawing.Size(248, 22);
            this.txtyatakno.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doktor";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdoktor
            // 
            this.txtdoktor.Location = new System.Drawing.Point(88, 172);
            this.txtdoktor.Name = "txtdoktor";
            this.txtdoktor.ReadOnly = true;
            this.txtdoktor.Size = new System.Drawing.Size(248, 22);
            this.txtdoktor.TabIndex = 5;
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(159, 214);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 6;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(250, 214);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 7;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHastasec
            // 
            this.btnHastasec.Location = new System.Drawing.Point(342, 172);
            this.btnHastasec.Name = "btnHastasec";
            this.btnHastasec.Size = new System.Drawing.Size(103, 27);
            this.btnHastasec.TabIndex = 16;
            this.btnHastasec.Text = "Doktor seç";
            this.btnHastasec.UseVisualStyleBackColor = true;
            this.btnHastasec.Click += new System.EventHandler(this.btnHastasec_Click);
            // 
            // FrmHasta
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(468, 267);
            this.Controls.Add(this.btnHastasec);
            this.Controls.Add(this.İptalbutonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.txtdoktor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtyatakno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtodano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHasta";
            this.Load += new System.EventHandler(this.FrmHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtodano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyatakno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdoktor;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHastasec;
    }
}