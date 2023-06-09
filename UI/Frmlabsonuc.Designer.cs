namespace TahaProjehastakyt.UI
{
    partial class Frmlabsonuc
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
            this.label5 = new System.Windows.Forms.Label();
            this.txttestsonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttestad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthastalab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttarihlab = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(232, 176);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 6;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Location = new System.Drawing.Point(141, 176);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 5;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarih";
            // 
            // txttestsonuc
            // 
            this.txttestsonuc.Location = new System.Drawing.Point(89, 109);
            this.txttestsonuc.Name = "txttestsonuc";
            this.txttestsonuc.Size = new System.Drawing.Size(248, 22);
            this.txttestsonuc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Test sonuç";
            // 
            // txttestad
            // 
            this.txttestad.Location = new System.Drawing.Point(89, 81);
            this.txttestad.Name = "txttestad";
            this.txttestad.Size = new System.Drawing.Size(248, 22);
            this.txttestad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Test adı";
            // 
            // txthastalab
            // 
            this.txthastalab.Location = new System.Drawing.Point(89, 53);
            this.txthastalab.Name = "txthastalab";
            this.txthastalab.ReadOnly = true;
            this.txthastalab.Size = new System.Drawing.Size(248, 22);
            this.txthastalab.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hastalar";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 22);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txttarihlab
            // 
            this.txttarihlab.Location = new System.Drawing.Point(89, 133);
            this.txttarihlab.Name = "txttarihlab";
            this.txttarihlab.Size = new System.Drawing.Size(248, 22);
            this.txttarihlab.TabIndex = 15;
            // 
            // Frmlabsonuc
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(349, 242);
            this.Controls.Add(this.txttarihlab);
            this.Controls.Add(this.İptalbutonu);
            this.Controls.Add(this.Tamambutonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttestsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttestad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthastalab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Frmlabsonuc";
            this.Text = "Frmlabsonuc";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.Button Tamambutonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttestsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttestad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthastalab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker txttarihlab;
    }
}