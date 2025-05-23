namespace Lokanta2
{
    partial class GirisForm
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
            label1 = new Label();
            label2 = new Label();
            tbKullaniciAdi = new TextBox();
            tbParola = new TextBox();
            btnGiris = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // tbKullaniciAdi
            // 
            tbKullaniciAdi.Location = new Point(162, 46);
            tbKullaniciAdi.Name = "tbKullaniciAdi";
            tbKullaniciAdi.Size = new Size(262, 23);
            tbKullaniciAdi.TabIndex = 2;
            // 
            // tbParola
            // 
            tbParola.Location = new Point(162, 87);
            tbParola.Name = "tbParola";
            tbParola.Size = new Size(262, 23);
            tbParola.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGiris.Location = new Point(162, 123);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(124, 32);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Oturum Aç";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbParola);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbKullaniciAdi);
            groupBox1.Location = new Point(77, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 176);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oturum Başlatma";
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 317);
            Controls.Add(groupBox1);
            Name = "GirisForm";
            Text = "Giris";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbKullaniciAdi;
        private TextBox tbParola;
        private Button btnGiris;
        private GroupBox groupBox1;
    }
}