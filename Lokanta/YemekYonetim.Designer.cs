namespace Lokanta
{
    partial class YemekYonetim
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
            dgv_YemekListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_YemekListe).BeginInit();
            SuspendLayout();
            // 
            // dgv_YemekListe
            // 
            dgv_YemekListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_YemekListe.Location = new Point(12, 288);
            dgv_YemekListe.Name = "dgv_YemekListe";
            dgv_YemekListe.Size = new Size(776, 340);
            dgv_YemekListe.TabIndex = 0;
            // 
            // YemekYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 640);
            Controls.Add(dgv_YemekListe);
            Name = "YemekYonetim";
            Text = "YemekYonetim";
            Load += YemekYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_YemekListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_YemekListe;
    }
}