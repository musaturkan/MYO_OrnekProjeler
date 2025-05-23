namespace Lokanta2
{
    partial class KullaniciBilgi_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblKayitTarihi = new Label();
            lblCinsiyet = new Label();
            pictureBox1 = new PictureBox();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(22, 22);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "label1";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(78, 22);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(38, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "label1";
            // 
            // lblKayitTarihi
            // 
            lblKayitTarihi.AutoSize = true;
            lblKayitTarihi.Location = new Point(24, 54);
            lblKayitTarihi.Name = "lblKayitTarihi";
            lblKayitTarihi.Size = new Size(38, 15);
            lblKayitTarihi.TabIndex = 2;
            lblKayitTarihi.Text = "label1";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(83, 54);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(38, 15);
            lblCinsiyet.TabIndex = 3;
            lblCinsiyet.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bseu_arkaplan;
            pictureBox1.Location = new Point(178, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(280, 22);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 47);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // KullaniciBilgi_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKapat);
            Controls.Add(pictureBox1);
            Controls.Add(lblCinsiyet);
            Controls.Add(lblKayitTarihi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "KullaniciBilgi_UC";
            Size = new Size(368, 96);
            Load += KullaniciBilgi_UC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblKayitTarihi;
        private Label lblCinsiyet;
        private PictureBox pictureBox1;
        private Button btnKapat;
    }
}
