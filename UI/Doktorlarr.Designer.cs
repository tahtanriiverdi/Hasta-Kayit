namespace TahaProjehastakyt.UI
{
    partial class Doktorlarr
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
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnDoktorekle = new System.Windows.Forms.ToolStripButton();
            this.btnDoktorduzenle = new System.Windows.Forms.ToolStripButton();
            this.btnDoktorsil = new System.Windows.Forms.ToolStripButton();
            this.btnDoktorbul = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.İptalbutonu = new System.Windows.Forms.Button();
            this.Tamambutonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 421);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(802, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 28);
            this.toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 34);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 307);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoktorekle,
            this.btnDoktorduzenle,
            this.btnDoktorsil,
            this.toolStripSeparator2,
            this.btnDoktorbul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(788, 31);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnDoktorekle
            // 
            this.btnDoktorekle.Image = global::TahaProjehastakyt.Properties.Resources.people_doctor_add;
            this.btnDoktorekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoktorekle.Name = "btnDoktorekle";
            this.btnDoktorekle.Size = new System.Drawing.Size(64, 28);
            this.btnDoktorekle.Text = "Ekle";
            this.btnDoktorekle.Click += new System.EventHandler(this.btnDoktorekle_Click);
            // 
            // btnDoktorduzenle
            // 
            this.btnDoktorduzenle.Image = global::TahaProjehastakyt.Properties.Resources.people_doctor_edit;
            this.btnDoktorduzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoktorduzenle.Name = "btnDoktorduzenle";
            this.btnDoktorduzenle.Size = new System.Drawing.Size(91, 28);
            this.btnDoktorduzenle.Text = "Düzenle";
            this.btnDoktorduzenle.Click += new System.EventHandler(this.btnDoktorduzenle_Click);
            // 
            // btnDoktorsil
            // 
            this.btnDoktorsil.Image = global::TahaProjehastakyt.Properties.Resources.people_doctor_remove;
            this.btnDoktorsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoktorsil.Name = "btnDoktorsil";
            this.btnDoktorsil.Size = new System.Drawing.Size(53, 28);
            this.btnDoktorsil.Text = "Sil";
            this.btnDoktorsil.Click += new System.EventHandler(this.btnDoktorsil_Click);
            // 
            // btnDoktorbul
            // 
            this.btnDoktorbul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDoktorbul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoktorbul.Image = global::TahaProjehastakyt.Properties.Resources.people_doctor_browse;
            this.btnDoktorbul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoktorbul.Name = "btnDoktorbul";
            this.btnDoktorbul.Size = new System.Drawing.Size(29, 28);
            this.btnDoktorbul.Text = "Bul";
            this.btnDoktorbul.ToolTipText = "btnHastabul";
            this.btnDoktorbul.Click += new System.EventHandler(this.btnDoktorbul_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.İptalbutonu);
            this.tabPage2.Controls.Add(this.Tamambutonu);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DOKTORLAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 443);
            this.tabControl1.TabIndex = 2;
            // 
            // İptalbutonu
            // 
            this.İptalbutonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.İptalbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptalbutonu.Location = new System.Drawing.Point(691, 347);
            this.İptalbutonu.Name = "İptalbutonu";
            this.İptalbutonu.Size = new System.Drawing.Size(86, 32);
            this.İptalbutonu.TabIndex = 9;
            this.İptalbutonu.Text = "İptal";
            this.İptalbutonu.UseVisualStyleBackColor = true;
            this.İptalbutonu.Click += new System.EventHandler(this.İptalbutonu_Click);
            // 
            // Tamambutonu
            // 
            this.Tamambutonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tamambutonu.Location = new System.Drawing.Point(600, 347);
            this.Tamambutonu.Name = "Tamambutonu";
            this.Tamambutonu.Size = new System.Drawing.Size(85, 32);
            this.Tamambutonu.TabIndex = 8;
            this.Tamambutonu.Text = "Tamam";
            this.Tamambutonu.UseVisualStyleBackColor = true;
            this.Tamambutonu.Click += new System.EventHandler(this.Tamambutonu_Click);
            // 
            // Doktorlarr
            // 
            this.AcceptButton = this.Tamambutonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptalbutonu;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doktorlarr";
            this.Text = "Doktorlarr";
            this.Load += new System.EventHandler(this.Doktorlarr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnDoktorbul;
        private System.Windows.Forms.ToolStripButton btnDoktorduzenle;
        private System.Windows.Forms.ToolStripButton btnDoktorekle;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnDoktorsil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button İptalbutonu;
        private System.Windows.Forms.Button Tamambutonu;
    }
}