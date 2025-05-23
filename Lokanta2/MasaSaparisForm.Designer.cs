namespace Lokanta2
{
    partial class MasaSaparisForm
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
            lblMasaSiparisBaslik = new Label();
            dgvMasaSiparisListe = new DataGridView();
            label1 = new Label();
            cbYemekListe = new ComboBox();
            label2 = new Label();
            btnOdemeYap = new Button();
            lblHesap = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasaSiparisListe).BeginInit();
            SuspendLayout();
            // 
            // lblMasaSiparisBaslik
            // 
            lblMasaSiparisBaslik.AutoSize = true;
            lblMasaSiparisBaslik.Font = new Font("Segoe UI", 16F);
            lblMasaSiparisBaslik.ForeColor = Color.IndianRed;
            lblMasaSiparisBaslik.Location = new Point(262, 9);
            lblMasaSiparisBaslik.Name = "lblMasaSiparisBaslik";
            lblMasaSiparisBaslik.Size = new Size(71, 30);
            lblMasaSiparisBaslik.TabIndex = 0;
            lblMasaSiparisBaslik.Text = "label1";
            // 
            // dgvMasaSiparisListe
            // 
            dgvMasaSiparisListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasaSiparisListe.Location = new Point(12, 230);
            dgvMasaSiparisListe.Name = "dgvMasaSiparisListe";
            dgvMasaSiparisListe.Size = new Size(606, 292);
            dgvMasaSiparisListe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 206);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Sipariş Listesi";
            // 
            // cbYemekListe
            // 
            cbYemekListe.DisplayMember = "Ad";
            cbYemekListe.FormattingEnabled = true;
            cbYemekListe.Location = new Point(12, 43);
            cbYemekListe.Name = "cbYemekListe";
            cbYemekListe.Size = new Size(216, 23);
            cbYemekListe.TabIndex = 3;
            cbYemekListe.Tag = "Id";
            cbYemekListe.ValueMember = "Id";
            cbYemekListe.SelectedIndexChanged += cbYemekListe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 12);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Yemek Seçimi";
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = Color.Maroon;
            btnOdemeYap.Font = new Font("Segoe UI", 14F);
            btnOdemeYap.ForeColor = SystemColors.ControlLightLight;
            btnOdemeYap.Location = new Point(479, 12);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(139, 108);
            btnOdemeYap.TabIndex = 5;
            btnOdemeYap.Text = "Hesap Öde";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblHesap
            // 
            lblHesap.AutoSize = true;
            lblHesap.Font = new Font("Segoe UI", 16F);
            lblHesap.ForeColor = Color.Firebrick;
            lblHesap.Location = new Point(479, 180);
            lblHesap.Name = "lblHesap";
            lblHesap.Size = new Size(71, 30);
            lblHesap.TabIndex = 6;
            lblHesap.Text = "label3";
            // 
            // MasaSaparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 563);
            Controls.Add(lblHesap);
            Controls.Add(btnOdemeYap);
            Controls.Add(label2);
            Controls.Add(cbYemekListe);
            Controls.Add(label1);
            Controls.Add(dgvMasaSiparisListe);
            Controls.Add(lblMasaSiparisBaslik);
            Name = "MasaSaparisForm";
            Text = "MasaSaparis";
            FormClosed += MasaSaparisForm_FormClosed;
            Load += MasaSaparisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMasaSiparisListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasaSiparisBaslik;
        private DataGridView dgvMasaSiparisListe;
        private Label label1;
        private ComboBox cbYemekListe;
        private Label label2;
        private Button btnOdemeYap;
        private Label lblHesap;
    }
}