namespace TahaProjehastakyt.UI
{
    partial class FrmYonetici
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
            this.txtparola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(250, 185);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 6;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(159, 185);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 5;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(88, 145);
            this.txtparola.Name = "txtparola";
            this.txtparola.Size = new System.Drawing.Size(248, 22);
            this.txtparola.TabIndex = 4;
            this.txtparola.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parola";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(88, 117);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(248, 22);
            this.txtkullaniciad.TabIndex = 3;
            this.txtkullaniciad.TextChanged += new System.EventHandler(this.txtodano_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanıcı adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 89);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(248, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(88, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 22);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmYonetici
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(376, 250);
            this.Controls.Add(this.İptalbutonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkullaniciad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}