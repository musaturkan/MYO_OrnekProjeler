namespace Lokanta2
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_siparis_alma = new Label();
            tabPanel = new TabControl();
            tpSiparis = new TabPage();
            flpMasabutonListe = new FlowLayoutPanel();
            tpYemekYonetim = new TabPage();
            dgvYemekListe = new DataGridView();
            gbYemekEkle = new GroupBox();
            btnYemekEkle = new Button();
            tbYemeAdi = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tbKalori = new TextBox();
            tbFiyat = new TextBox();
            label2 = new Label();
            tpMasaYonetim = new TabPage();
            tpKullaniciYonetim = new TabPage();
            tpIsListesi = new TabPage();
            btnHavaDurumu = new Button();
            btnGonderiEkle = new Button();
            cbUserListe = new ComboBox();
            dgvTotoListe = new DataGridView();
            btnOturumKapat = new Button();
            lblOturumAd = new Label();
            kullaniciOturum_uc = new KullaniciBilgi_UC();
            tabPanel.SuspendLayout();
            tpSiparis.SuspendLayout();
            tpYemekYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemekListe).BeginInit();
            gbYemekEkle.SuspendLayout();
            tpIsListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotoListe).BeginInit();
            SuspendLayout();
            // 
            // lbl_siparis_alma
            // 
            lbl_siparis_alma.AutoSize = true;
            lbl_siparis_alma.Font = new Font("Segoe UI", 16F);
            lbl_siparis_alma.Location = new Point(23, 13);
            lbl_siparis_alma.Name = "lbl_siparis_alma";
            lbl_siparis_alma.Size = new Size(195, 30);
            lbl_siparis_alma.TabIndex = 0;
            lbl_siparis_alma.Text = "Sipariş Alma Ekranı";
            // 
            // tabPanel
            // 
            tabPanel.Controls.Add(tpSiparis);
            tabPanel.Controls.Add(tpYemekYonetim);
            tabPanel.Controls.Add(tpMasaYonetim);
            tabPanel.Controls.Add(tpKullaniciYonetim);
            tabPanel.Controls.Add(tpIsListesi);
            tabPanel.Location = new Point(12, 134);
            tabPanel.Name = "tabPanel";
            tabPanel.SelectedIndex = 0;
            tabPanel.Size = new Size(966, 626);
            tabPanel.TabIndex = 4;
            // 
            // tpSiparis
            // 
            tpSiparis.Controls.Add(flpMasabutonListe);
            tpSiparis.Controls.Add(lbl_siparis_alma);
            tpSiparis.Location = new Point(4, 24);
            tpSiparis.Name = "tpSiparis";
            tpSiparis.Padding = new Padding(3);
            tpSiparis.Size = new Size(958, 598);
            tpSiparis.TabIndex = 0;
            tpSiparis.Text = "Sipariş";
            tpSiparis.UseVisualStyleBackColor = true;
            // 
            // flpMasabutonListe
            // 
            flpMasabutonListe.Location = new Point(6, 60);
            flpMasabutonListe.Name = "flpMasabutonListe";
            flpMasabutonListe.Size = new Size(946, 598);
            flpMasabutonListe.TabIndex = 4;
            // 
            // tpYemekYonetim
            // 
            tpYemekYonetim.Controls.Add(dgvYemekListe);
            tpYemekYonetim.Controls.Add(gbYemekEkle);
            tpYemekYonetim.Location = new Point(4, 24);
            tpYemekYonetim.Name = "tpYemekYonetim";
            tpYemekYonetim.Padding = new Padding(3);
            tpYemekYonetim.Size = new Size(958, 598);
            tpYemekYonetim.TabIndex = 1;
            tpYemekYonetim.Text = "Yemek Yönetim";
            tpYemekYonetim.UseVisualStyleBackColor = true;
            //tpYemekYonetim.Enter += tpYemekYonetim_Enter;
            // 
            // dgvYemekListe
            // 
            dgvYemekListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekListe.Location = new Point(23, 295);
            dgvYemekListe.Name = "dgvYemekListe";
            dgvYemekListe.Size = new Size(396, 280);
            dgvYemekListe.TabIndex = 7;
            // 
            // gbYemekEkle
            // 
            gbYemekEkle.Controls.Add(btnYemekEkle);
            gbYemekEkle.Controls.Add(tbYemeAdi);
            gbYemekEkle.Controls.Add(label1);
            gbYemekEkle.Controls.Add(label3);
            gbYemekEkle.Controls.Add(tbKalori);
            gbYemekEkle.Controls.Add(tbFiyat);
            gbYemekEkle.Controls.Add(label2);
            gbYemekEkle.Location = new Point(23, 56);
            gbYemekEkle.Name = "gbYemekEkle";
            gbYemekEkle.Size = new Size(384, 220);
            gbYemekEkle.TabIndex = 6;
            gbYemekEkle.TabStop = false;
            gbYemekEkle.Text = "Yeni Yemek Ekleme";
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(107, 154);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(255, 38);
            btnYemekEkle.TabIndex = 7;
            btnYemekEkle.Text = "Kaydet";
            btnYemekEkle.UseVisualStyleBackColor = true;
            //btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // tbYemeAdi
            // 
            tbYemeAdi.Location = new Point(111, 35);
            tbYemeAdi.Name = "tbYemeAdi";
            tbYemeAdi.Size = new Size(251, 23);
            tbYemeAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Fiyat:";
            // 
            // tbKalori
            // 
            tbKalori.Location = new Point(111, 74);
            tbKalori.Name = "tbKalori";
            tbKalori.Size = new Size(251, 23);
            tbKalori.TabIndex = 2;
            // 
            // tbFiyat
            // 
            tbFiyat.Location = new Point(111, 115);
            tbFiyat.Name = "tbFiyat";
            tbFiyat.Size = new Size(251, 23);
            tbFiyat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Kaloriı:";
            // 
            // tpMasaYonetim
            // 
            tpMasaYonetim.Location = new Point(4, 24);
            tpMasaYonetim.Name = "tpMasaYonetim";
            tpMasaYonetim.Padding = new Padding(3);
            tpMasaYonetim.Size = new Size(958, 598);
            tpMasaYonetim.TabIndex = 2;
            tpMasaYonetim.Text = "Masa Yönetimi";
            tpMasaYonetim.UseVisualStyleBackColor = true;
            // 
            // tpKullaniciYonetim
            // 
            tpKullaniciYonetim.Location = new Point(4, 24);
            tpKullaniciYonetim.Name = "tpKullaniciYonetim";
            tpKullaniciYonetim.Padding = new Padding(3);
            tpKullaniciYonetim.Size = new Size(958, 598);
            tpKullaniciYonetim.TabIndex = 3;
            tpKullaniciYonetim.Text = "Kullanıcı Yönetimi";
            tpKullaniciYonetim.UseVisualStyleBackColor = true;
            // 
            // tpIsListesi
            // 
            tpIsListesi.Controls.Add(btnHavaDurumu);
            tpIsListesi.Controls.Add(btnGonderiEkle);
            tpIsListesi.Controls.Add(cbUserListe);
            tpIsListesi.Controls.Add(dgvTotoListe);
            tpIsListesi.Location = new Point(4, 24);
            tpIsListesi.Name = "tpIsListesi";
            tpIsListesi.Padding = new Padding(3);
            tpIsListesi.Size = new Size(958, 598);
            tpIsListesi.TabIndex = 4;
            tpIsListesi.Text = "İş Listesi (Web Servisten)";
            tpIsListesi.UseVisualStyleBackColor = true;
            //tpIsListesi.Enter += tpIsListesi_Enter;
            // 
            // btnHavaDurumu
            // 
            btnHavaDurumu.Location = new Point(748, 53);
            btnHavaDurumu.Name = "btnHavaDurumu";
            btnHavaDurumu.Size = new Size(184, 23);
            btnHavaDurumu.TabIndex = 3;
            btnHavaDurumu.Text = "Hava Durumu";
            btnHavaDurumu.UseVisualStyleBackColor = true;
            //btnHavaDurumu.Click += btnHavaDurumu_Click;
            // 
            // btnGonderiEkle
            // 
            btnGonderiEkle.Location = new Point(748, 24);
            btnGonderiEkle.Name = "btnGonderiEkle";
            btnGonderiEkle.Size = new Size(184, 23);
            btnGonderiEkle.TabIndex = 2;
            btnGonderiEkle.Text = "Gönderi Ekle";
            btnGonderiEkle.UseVisualStyleBackColor = true;
            //btnGonderiEkle.Click += btnGonderiEkle_Click;
            // 
            // cbUserListe
            // 
            cbUserListe.DisplayMember = "name";
            cbUserListe.FormattingEnabled = true;
            cbUserListe.Location = new Point(17, 78);
            cbUserListe.Name = "cbUserListe";
            cbUserListe.Size = new Size(343, 23);
            cbUserListe.TabIndex = 1;
            cbUserListe.ValueMember = "id";
            //cbUserListe.SelectedIndexChanged += cbUserListe_SelectedIndexChanged;
            // 
            // dgvTotoListe
            // 
            dgvTotoListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotoListe.Location = new Point(17, 107);
            dgvTotoListe.Name = "dgvTotoListe";
            dgvTotoListe.Size = new Size(634, 538);
            dgvTotoListe.TabIndex = 0;
            // 
            // btnOturumKapat
            // 
            btnOturumKapat.Location = new Point(870, 36);
            btnOturumKapat.Name = "btnOturumKapat";
            btnOturumKapat.Size = new Size(104, 27);
            btnOturumKapat.TabIndex = 5;
            btnOturumKapat.Text = "Oturumu Kapat";
            btnOturumKapat.UseVisualStyleBackColor = true;
            //btnOturumKapat.Click += btnOturumKapat_Click;
            // 
            // lblOturumAd
            // 
            lblOturumAd.AutoSize = true;
            lblOturumAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOturumAd.ForeColor = Color.Green;
            lblOturumAd.Location = new Point(774, 9);
            lblOturumAd.Name = "lblOturumAd";
            lblOturumAd.Size = new Size(0, 21);
            lblOturumAd.TabIndex = 6;
            // 
            // kullaniciOturum_uc
            // 
            kullaniciOturum_uc.Ad = "label1";
            kullaniciOturum_uc.BackColor = Color.AntiqueWhite;
            kullaniciOturum_uc.Cinsiyet = "label1";
            kullaniciOturum_uc.KayitTarihi = "label1";
            kullaniciOturum_uc.Location = new Point(596, 12);
            kullaniciOturum_uc.Name = "kullaniciOturum_uc";
            kullaniciOturum_uc.Size = new Size(268, 88);
            kullaniciOturum_uc.Soyad = "label1";
            kullaniciOturum_uc.TabIndex = 7;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 797);
            Controls.Add(kullaniciOturum_uc);
            Controls.Add(lblOturumAd);
            Controls.Add(btnOturumKapat);
            Controls.Add(tabPanel);
            Name = "AnaForm";
            Text = "Form1";
            //Load += Siparis_Load;
            tabPanel.ResumeLayout(false);
            tpSiparis.ResumeLayout(false);
            tpSiparis.PerformLayout();
            tpYemekYonetim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvYemekListe).EndInit();
            gbYemekEkle.ResumeLayout(false);
            gbYemekEkle.PerformLayout();
            tpIsListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTotoListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_siparis_alma;
        private ListBox lbx_yemekListesi;
        private Label lbl_yemekListesi;
        private ListBox lbx_masSiparisListe;
        private TabControl tabPanel;
        private TabPage tpSiparis;
        private TabPage tpYemekYonetim;
        private TabPage tpMasaYonetim;
        private TabPage tpKullaniciYonetim;
        private Label label1;
        private TextBox tbYemeAdi;
        private Label label3;
        private TextBox tbFiyat;
        private Label label2;
        private TextBox tbKalori;
        private GroupBox gbYemekEkle;
        private Button btnYemekEkle;
        private FlowLayoutPanel flpMasabutonListe;
        private DataGridView dgvYemekListe;
        private TabPage tpIsListesi;
        private DataGridView dgvTotoListe;
        private ComboBox cbUserListe;
        private Button btnGonderiEkle;
        private Button btnHavaDurumu;
        private Button btnOturumKapat;
        private Label lblOturumAd;
        private KullaniciBilgi_UC kullaniciOturum_uc;
    }
}
