namespace Lokanta2
{
    partial class YemekBilgi_UC
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
            lblFiyat = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(13, 14);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(38, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "label1";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(14, 53);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(38, 15);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(160, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // YemekBilgi_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblFiyat);
            Controls.Add(lblAd);
            Name = "YemekBilgi_UC";
            Size = new Size(250, 96);
            Load += YemekBilgi_UC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblFiyat;
        private PictureBox pictureBox1;
    }
}
