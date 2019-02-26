namespace quiz1
{
    partial class FormTakip
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
            this.btnAracDurumKaydet = new System.Windows.Forms.Button();
            this.btnGunlukArsiv = new System.Windows.Forms.Button();
            this.lstGunlukKayitArsivi = new System.Windows.Forms.ListBox();
            this.lstTarih = new System.Windows.Forms.ListBox();
            this.lstHasilat = new System.Windows.Forms.ListBox();
            this.lstPlaka = new System.Windows.Forms.ListBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.cbOtobus = new System.Windows.Forms.ComboBox();
            this.btnAracHareketlendir = new System.Windows.Forms.Button();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblSefer = new System.Windows.Forms.Label();
            this.lblHasilat = new System.Windows.Forms.Label();
            this.lblGunlukKayit = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblOtobus = new System.Windows.Forms.Label();
            this.cmbSefer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAracDurumKaydet
            // 
            this.btnAracDurumKaydet.Location = new System.Drawing.Point(178, 199);
            this.btnAracDurumKaydet.Name = "btnAracDurumKaydet";
            this.btnAracDurumKaydet.Size = new System.Drawing.Size(75, 31);
            this.btnAracDurumKaydet.TabIndex = 39;
            this.btnAracDurumKaydet.Text = "Araç Durum Kaydet";
            this.btnAracDurumKaydet.UseVisualStyleBackColor = true;
            this.btnAracDurumKaydet.Click += new System.EventHandler(this.btnAracDurumKaydet_Click);
            // 
            // btnGunlukArsiv
            // 
            this.btnGunlukArsiv.Location = new System.Drawing.Point(657, 81);
            this.btnGunlukArsiv.Name = "btnGunlukArsiv";
            this.btnGunlukArsiv.Size = new System.Drawing.Size(75, 43);
            this.btnGunlukArsiv.TabIndex = 38;
            this.btnGunlukArsiv.Text = "Günlük Arşiv";
            this.btnGunlukArsiv.UseVisualStyleBackColor = true;
            this.btnGunlukArsiv.Click += new System.EventHandler(this.btnGunlukArsiv_Click);
            // 
            // lstGunlukKayitArsivi
            // 
            this.lstGunlukKayitArsivi.FormattingEnabled = true;
            this.lstGunlukKayitArsivi.Location = new System.Drawing.Point(522, 130);
            this.lstGunlukKayitArsivi.Name = "lstGunlukKayitArsivi";
            this.lstGunlukKayitArsivi.Size = new System.Drawing.Size(210, 173);
            this.lstGunlukKayitArsivi.TabIndex = 37;
            // 
            // lstTarih
            // 
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.Location = new System.Drawing.Point(133, 98);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(155, 95);
            this.lstTarih.TabIndex = 36;
            // 
            // lstHasilat
            // 
            this.lstHasilat.FormattingEnabled = true;
            this.lstHasilat.Location = new System.Drawing.Point(297, 98);
            this.lstHasilat.Name = "lstHasilat";
            this.lstHasilat.Size = new System.Drawing.Size(120, 95);
            this.lstHasilat.TabIndex = 35;
            // 
            // lstPlaka
            // 
            this.lstPlaka.FormattingEnabled = true;
            this.lstPlaka.Location = new System.Drawing.Point(9, 96);
            this.lstPlaka.Name = "lstPlaka";
            this.lstPlaka.Size = new System.Drawing.Size(120, 95);
            this.lstPlaka.TabIndex = 34;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Enabled = false;
            this.txtKisiSayisi.Location = new System.Drawing.Point(346, 27);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(152, 20);
            this.txtKisiSayisi.TabIndex = 33;
            // 
            // cbOtobus
            // 
            this.cbOtobus.FormattingEnabled = true;
            this.cbOtobus.Location = new System.Drawing.Point(0, 27);
            this.cbOtobus.Name = "cbOtobus";
            this.cbOtobus.Size = new System.Drawing.Size(145, 21);
            this.cbOtobus.TabIndex = 31;
            this.cbOtobus.SelectedIndexChanged += new System.EventHandler(this.cbOtobus_SelectedIndexChanged);
            // 
            // btnAracHareketlendir
            // 
            this.btnAracHareketlendir.Location = new System.Drawing.Point(522, 12);
            this.btnAracHareketlendir.Name = "btnAracHareketlendir";
            this.btnAracHareketlendir.Size = new System.Drawing.Size(112, 39);
            this.btnAracHareketlendir.TabIndex = 30;
            this.btnAracHareketlendir.Text = "Araç Hareketlendir";
            this.btnAracHareketlendir.UseVisualStyleBackColor = true;
            this.btnAracHareketlendir.Click += new System.EventHandler(this.btnAracHareketlendir_Click);
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(343, 11);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(53, 13);
            this.lblKisiSayisi.TabIndex = 28;
            this.lblKisiSayisi.Text = "Kişi Sayısı";
            // 
            // lblSefer
            // 
            this.lblSefer.AutoSize = true;
            this.lblSefer.Location = new System.Drawing.Point(197, 9);
            this.lblSefer.Name = "lblSefer";
            this.lblSefer.Size = new System.Drawing.Size(32, 13);
            this.lblSefer.TabIndex = 27;
            this.lblSefer.Text = "Sefer";
            // 
            // lblHasilat
            // 
            this.lblHasilat.AutoSize = true;
            this.lblHasilat.Location = new System.Drawing.Point(294, 66);
            this.lblHasilat.Name = "lblHasilat";
            this.lblHasilat.Size = new System.Drawing.Size(77, 13);
            this.lblHasilat.TabIndex = 26;
            this.lblHasilat.Text = "Toplam Hasılat";
            // 
            // lblGunlukKayit
            // 
            this.lblGunlukKayit.AutoSize = true;
            this.lblGunlukKayit.Location = new System.Drawing.Point(556, 96);
            this.lblGunlukKayit.Name = "lblGunlukKayit";
            this.lblGunlukKayit.Size = new System.Drawing.Size(95, 13);
            this.lblGunlukKayit.TabIndex = 25;
            this.lblGunlukKayit.Text = "Günlük Kayıt Arşivi";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(143, 66);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 24;
            this.lblTarih.Text = "Tarih";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(13, 66);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 29;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblOtobus
            // 
            this.lblOtobus.AutoSize = true;
            this.lblOtobus.Location = new System.Drawing.Point(6, 9);
            this.lblOtobus.Name = "lblOtobus";
            this.lblOtobus.Size = new System.Drawing.Size(41, 13);
            this.lblOtobus.TabIndex = 23;
            this.lblOtobus.Text = "Otobüs";
            // 
            // cmbSefer
            // 
            this.cmbSefer.Enabled = false;
            this.cmbSefer.FormattingEnabled = true;
            this.cmbSefer.Location = new System.Drawing.Point(163, 27);
            this.cmbSefer.Name = "cmbSefer";
            this.cmbSefer.Size = new System.Drawing.Size(145, 21);
            this.cmbSefer.TabIndex = 31;
            this.cmbSefer.SelectedIndexChanged += new System.EventHandler(this.cbOtobus_SelectedIndexChanged);
            // 
            // FormTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 304);
            this.Controls.Add(this.btnAracDurumKaydet);
            this.Controls.Add(this.btnGunlukArsiv);
            this.Controls.Add(this.lstGunlukKayitArsivi);
            this.Controls.Add(this.lstTarih);
            this.Controls.Add(this.lstHasilat);
            this.Controls.Add(this.lstPlaka);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.cmbSefer);
            this.Controls.Add(this.cbOtobus);
            this.Controls.Add(this.btnAracHareketlendir);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.lblSefer);
            this.Controls.Add(this.lblHasilat);
            this.Controls.Add(this.lblGunlukKayit);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblOtobus);
            this.Name = "FormTakip";
            this.Text = "FormTakip";
            this.Load += new System.EventHandler(this.FormTakip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracDurumKaydet;
        private System.Windows.Forms.Button btnGunlukArsiv;
        private System.Windows.Forms.ListBox lstGunlukKayitArsivi;
        private System.Windows.Forms.ListBox lstTarih;
        private System.Windows.Forms.ListBox lstHasilat;
        private System.Windows.Forms.ListBox lstPlaka;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.ComboBox cbOtobus;
        private System.Windows.Forms.Button btnAracHareketlendir;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblSefer;
        private System.Windows.Forms.Label lblHasilat;
        private System.Windows.Forms.Label lblGunlukKayit;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblOtobus;
        private System.Windows.Forms.ComboBox cmbSefer;
    }
}