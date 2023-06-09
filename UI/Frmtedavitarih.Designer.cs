namespace TahaProjehastakyt.UI
{
    partial class Frmtedavitarih
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
            this.txtdoktor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHastasec = new System.Windows.Forms.Button();
            this.btndoktorsec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(239, 143);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 5;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(148, 143);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 4;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // txtdoktor
            // 
            this.txtdoktor.Location = new System.Drawing.Point(77, 68);
            this.txtdoktor.Name = "txtdoktor";
            this.txtdoktor.ReadOnly = true;
            this.txtdoktor.Size = new System.Drawing.Size(248, 22);
            this.txtdoktor.TabIndex = 2;
            this.txtdoktor.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doktorlar";
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(77, 40);
            this.txthasta.Name = "txthasta";
            this.txthasta.ReadOnly = true;
            this.txthasta.Size = new System.Drawing.Size(248, 22);
            this.txthasta.TabIndex = 1;
            this.txthasta.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hastalar";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 22);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(77, 102);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(248, 22);
            this.dtTarih.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHastasec
            // 
            this.btnHastasec.Location = new System.Drawing.Point(331, 38);
            this.btnHastasec.Name = "btnHastasec";
            this.btnHastasec.Size = new System.Drawing.Size(140, 27);
            this.btnHastasec.TabIndex = 15;
            this.btnHastasec.Text = "Hasta seç";
            this.btnHastasec.UseVisualStyleBackColor = true;
            this.btnHastasec.Click += new System.EventHandler(this.btnHastasec_Click);
            // 
            // btndoktorsec
            // 
            this.btndoktorsec.Location = new System.Drawing.Point(331, 72);
            this.btndoktorsec.Name = "btndoktorsec";
            this.btndoktorsec.Size = new System.Drawing.Size(140, 27);
            this.btndoktorsec.TabIndex = 16;
            this.btndoktorsec.Text = "Doktor seç";
            this.btndoktorsec.UseVisualStyleBackColor = true;
            this.btndoktorsec.Click += new System.EventHandler(this.btndoktorsec_Click);
            // 
            // Frmtedavitarih
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(540, 211);
            this.Controls.Add(this.btndoktorsec);
            this.Controls.Add(this.btnHastasec);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.İptalbutonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdoktor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmtedavitarih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmtedavitarih";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.TextBox txtdoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHastasec;
        private System.Windows.Forms.Button btndoktorsec;
    }
}