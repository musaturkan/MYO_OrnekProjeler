namespace Lokanta
{
    partial class LokantaBaslat
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
            btn_Merhaba = new Button();
            lbl_Merhaba = new Label();
            btn_Giris = new Button();
            lbl_KullaniciAd = new Label();
            lbl_Parola = new Label();
            tb_KullaniciAd = new TextBox();
            tb_Parola = new TextBox();
            btn_Kapat = new Button();
            SuspendLayout();
            // 
            // btn_Merhaba
            // 
            btn_Merhaba.Font = new Font("Candara", 18F, FontStyle.Bold);
            btn_Merhaba.ForeColor = Color.Maroon;
            btn_Merhaba.Location = new Point(12, 600);
            btn_Merhaba.Name = "btn_Merhaba";
            btn_Merhaba.Size = new Size(206, 78);
            btn_Merhaba.TabIndex = 0;
            btn_Merhaba.Text = "Merhaba Butonu";
            btn_Merhaba.UseVisualStyleBackColor = true;
            btn_Merhaba.Click += btn_Merhaba_Click;
            // 
            // lbl_Merhaba
            // 
            lbl_Merhaba.AutoSize = true;
            lbl_Merhaba.Location = new Point(12, 566);
            lbl_Merhaba.Name = "lbl_Merhaba";
            lbl_Merhaba.Size = new Size(52, 21);
            lbl_Merhaba.TabIndex = 1;
            lbl_Merhaba.Text = "label1";
            // 
            // btn_Giris
            // 
            btn_Giris.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_Giris.Location = new Point(411, 201);
            btn_Giris.Name = "btn_Giris";
            btn_Giris.Size = new Size(327, 60);
            btn_Giris.TabIndex = 6;
            btn_Giris.Text = "Giriş";
            btn_Giris.UseVisualStyleBackColor = true;
            btn_Giris.Click += btn_Giris_Click;
            // 
            // lbl_KullaniciAd
            // 
            lbl_KullaniciAd.AutoSize = true;
            lbl_KullaniciAd.Location = new Point(261, 86);
            lbl_KullaniciAd.Name = "lbl_KullaniciAd";
            lbl_KullaniciAd.Size = new Size(95, 21);
            lbl_KullaniciAd.TabIndex = 7;
            lbl_KullaniciAd.Text = "Kullanıcı Adı";
            // 
            // lbl_Parola
            // 
            lbl_Parola.AutoSize = true;
            lbl_Parola.Location = new Point(261, 147);
            lbl_Parola.Name = "lbl_Parola";
            lbl_Parola.Size = new Size(77, 21);
            lbl_Parola.TabIndex = 8;
            lbl_Parola.Text = "lbl_Parola";
            // 
            // tb_KullaniciAd
            // 
            tb_KullaniciAd.Location = new Point(411, 86);
            tb_KullaniciAd.Name = "tb_KullaniciAd";
            tb_KullaniciAd.Size = new Size(327, 29);
            tb_KullaniciAd.TabIndex = 9;
            // 
            // tb_Parola
            // 
            tb_Parola.BackColor = Color.White;
            tb_Parola.Location = new Point(411, 139);
            tb_Parola.Name = "tb_Parola";
            tb_Parola.PasswordChar = '*';
            tb_Parola.Size = new Size(327, 29);
            tb_Parola.TabIndex = 10;
            // 
            // btn_Kapat
            // 
            btn_Kapat.BackColor = Color.DarkRed;
            btn_Kapat.ForeColor = SystemColors.ButtonHighlight;
            btn_Kapat.Location = new Point(994, 629);
            btn_Kapat.Name = "btn_Kapat";
            btn_Kapat.Size = new Size(124, 49);
            btn_Kapat.TabIndex = 11;
            btn_Kapat.Text = "KAPAT";
            btn_Kapat.UseVisualStyleBackColor = false;
            btn_Kapat.Click += btn_Kapat_Click;
            // 
            // LokantaBaslat
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1119, 679);
            Controls.Add(btn_Kapat);
            Controls.Add(tb_Parola);
            Controls.Add(tb_KullaniciAd);
            Controls.Add(lbl_Parola);
            Controls.Add(lbl_KullaniciAd);
            Controls.Add(btn_Giris);
            Controls.Add(lbl_Merhaba);
            Controls.Add(btn_Merhaba);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            Name = "LokantaBaslat";
            Text = "Bol Kepçe Lokantası";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Merhaba;
        private Label lbl_Merhaba;
        private Button btn_Giris;
        private Label lbl_KullaniciAd;
        private Label lbl_Parola;
        private TextBox tb_KullaniciAd;
        private TextBox tb_Parola;
        private Button btn_Kapat;
    }
}
