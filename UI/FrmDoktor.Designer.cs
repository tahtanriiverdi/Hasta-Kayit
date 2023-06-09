namespace TahaProjehastakyt.UI
{
    partial class FrmDoktor
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
            this.İptalbutonu = new System.Windows.Forms.Button();
            this.Tamambutonu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdoktorsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdoktorad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brans = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(236, 142);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 5;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(145, 142);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 4;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branş";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdoktorsoyad
            // 
            this.txtdoktorsoyad.Location = new System.Drawing.Point(72, 71);
            this.txtdoktorsoyad.Name = "txtdoktorsoyad";
            this.txtdoktorsoyad.Size = new System.Drawing.Size(291, 22);
            this.txtdoktorsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad";
            // 
            // txtdoktorad
            // 
            this.txtdoktorad.Location = new System.Drawing.Point(72, 43);
            this.txtdoktorad.Name = "txtdoktorad";
            this.txtdoktorad.Size = new System.Drawing.Size(291, 22);
            this.txtdoktorad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(291, 22);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // Brans
            // 
            this.Brans.FormattingEnabled = true;
            this.Brans.Items.AddRange(new object[] {
            "GENEL CERRAHİ",
            "İÇ HASTALIKLARI",
            "ORTOPEDİ VE TRAVMATOLOJİ",
            "ÜROLOJİ",
            "KADIN HASTALIKLARI VE DOĞUM",
            "ANESTEZİYOLOJİ VE REANİMASYON",
            "KULAK BURUN BOĞAZ HASTALIKLARI",
            "ÇOCUK SAĞLIĞI VE HASTALIKLARI",
            "GÖZ HASTALIKLARI",
            "KARDİYOLOJİ"});
            this.Brans.Location = new System.Drawing.Point(72, 99);
            this.Brans.Name = "Brans";
            this.Brans.Size = new System.Drawing.Size(291, 24);
            this.Brans.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDoktor
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(388, 192);
            this.Controls.Add(this.Brans);
            this.Controls.Add(this.İptalbutonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdoktorsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdoktorad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDoktor";
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdoktorsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdoktorad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Brans;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}