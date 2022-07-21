
namespace PansiyonUygulamasi
{
    partial class Anasayfa
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
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.musteriEkleTableAdapter1 = new PansiyonUygulamasi.PansiyonDataSetTableAdapters.MusteriEkleTableAdapter();
            this.butonMusteriler = new System.Windows.Forms.Button();
            this.buttonStok = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.Location = new System.Drawing.Point(42, 67);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(127, 73);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = true;
            this.BtnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.Location = new System.Drawing.Point(226, 67);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(127, 73);
            this.BtnMusteriEkle.TabIndex = 1;
            this.BtnMusteriEkle.Text = "Müşteri Ekle";
            this.BtnMusteriEkle.UseVisualStyleBackColor = true;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.Location = new System.Drawing.Point(410, 67);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(127, 73);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = true;
            this.BtnOdalar.Click += new System.EventHandler(this.BtnOdalar_Click);
            // 
            // musteriEkleTableAdapter1
            // 
            this.musteriEkleTableAdapter1.ClearBeforeFill = true;
            // 
            // butonMusteriler
            // 
            this.butonMusteriler.Location = new System.Drawing.Point(42, 191);
            this.butonMusteriler.Name = "butonMusteriler";
            this.butonMusteriler.Size = new System.Drawing.Size(127, 73);
            this.butonMusteriler.TabIndex = 3;
            this.butonMusteriler.Text = "Müşteriler";
            this.butonMusteriler.UseVisualStyleBackColor = true;
            this.butonMusteriler.Click += new System.EventHandler(this.butonMusteriler_Click);
            // 
            // buttonStok
            // 
            this.buttonStok.Location = new System.Drawing.Point(226, 191);
            this.buttonStok.Name = "buttonStok";
            this.buttonStok.Size = new System.Drawing.Size(127, 73);
            this.buttonStok.TabIndex = 4;
            this.buttonStok.Text = "Stok Bilgisi";
            this.buttonStok.UseVisualStyleBackColor = true;
            this.buttonStok.Click += new System.EventHandler(this.buttonStok_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(410, 191);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(127, 73);
            this.buttonCikis.TabIndex = 5;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 354);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonStok);
            this.Controls.Add(this.butonMusteriler);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Controls.Add(this.BtnAdminGiris);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnOdalar;
        private PansiyonDataSetTableAdapters.MusteriEkleTableAdapter musteriEkleTableAdapter1;
        private System.Windows.Forms.Button butonMusteriler;
        private System.Windows.Forms.Button buttonStok;
        private System.Windows.Forms.Button buttonCikis;
    }
}