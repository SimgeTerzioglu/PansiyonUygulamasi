
namespace PansiyonUygulamasi
{
    partial class FormMusteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GirisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CikisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butonListele = new System.Windows.Forms.Button();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblGirisTar = new System.Windows.Forms.Label();
            this.lblCikisTar = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.labelAra = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.Adı,
            this.Soyadı,
            this.Telefon,
            this.Mail,
            this.Tc,
            this.Cinsiyet,
            this.Odano,
            this.GirisTarihi,
            this.CikisTarihi,
            this.Ucret});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 369);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1052, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // no
            // 
            this.no.Text = "No";
            this.no.Width = 39;
            // 
            // Adı
            // 
            this.Adı.Text = "Adı";
            this.Adı.Width = 57;
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "Soyadi";
            this.Soyadı.Width = 82;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 77;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 73;
            // 
            // Tc
            // 
            this.Tc.Text = "Tc";
            this.Tc.Width = 69;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.Width = 64;
            // 
            // Odano
            // 
            this.Odano.Text = "Oda no";
            this.Odano.Width = 67;
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.Text = "GirişTarihi";
            this.GirisTarihi.Width = 81;
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.Text = "ÇıkışTarihi";
            this.CikisTarihi.Width = 93;
            // 
            // Ucret
            // 
            this.Ucret.Text = "Ucret";
            this.Ucret.Width = 70;
            // 
            // butonListele
            // 
            this.butonListele.Location = new System.Drawing.Point(896, 12);
            this.butonListele.Name = "butonListele";
            this.butonListele.Size = new System.Drawing.Size(168, 40);
            this.butonListele.TabIndex = 1;
            this.butonListele.Text = "Listele";
            this.butonListele.UseVisualStyleBackColor = true;
            this.butonListele.Click += new System.EventHandler(this.butonListele_Click);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Location = new System.Drawing.Point(415, 65);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(185, 22);
            this.txtOdaNo.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(415, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(94, 182);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(185, 22);
            this.maskedTextBox1.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(415, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(12, 183);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(76, 21);
            this.lblTelNo.TabIndex = 40;
            this.lblTelNo.Text = "Telefon:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(415, 182);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(185, 22);
            this.txtUcret.TabIndex = 36;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 64);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 22);
            this.txtSoyad.TabIndex = 35;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(94, 104);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(185, 22);
            this.txtTc.TabIndex = 34;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(94, 145);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 22);
            this.txtMail.TabIndex = 33;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 22);
            this.txtAd.TabIndex = 32;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(45, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 21);
            this.lblAd.TabIndex = 31;
            this.lblAd.Text = "Adı:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(19, 64);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(69, 21);
            this.lblSoyad.TabIndex = 30;
            this.lblSoyad.Text = "Soyadı:";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcNo.Location = new System.Drawing.Point(28, 105);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(60, 21);
            this.lblTcNo.TabIndex = 29;
            this.lblTcNo.Text = "Tc No:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(36, 145);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 21);
            this.lblMail.TabIndex = 28;
            this.lblMail.Text = "Mail:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(327, 28);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(82, 21);
            this.lblCinsiyet.TabIndex = 27;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaNo.Location = new System.Drawing.Point(333, 66);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(76, 21);
            this.lblOdaNo.TabIndex = 26;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // lblGirisTar
            // 
            this.lblGirisTar.AutoSize = true;
            this.lblGirisTar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisTar.Location = new System.Drawing.Point(301, 102);
            this.lblGirisTar.Name = "lblGirisTar";
            this.lblGirisTar.Size = new System.Drawing.Size(108, 21);
            this.lblGirisTar.TabIndex = 25;
            this.lblGirisTar.Text = "Giriş Tarihi:";
            // 
            // lblCikisTar
            // 
            this.lblCikisTar.AutoSize = true;
            this.lblCikisTar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikisTar.Location = new System.Drawing.Point(300, 143);
            this.lblCikisTar.Name = "lblCikisTar";
            this.lblCikisTar.Size = new System.Drawing.Size(109, 21);
            this.lblCikisTar.TabIndex = 24;
            this.lblCikisTar.Text = "Çıkış Tarihi:";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcret.Location = new System.Drawing.Point(350, 183);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(59, 21);
            this.lblUcret.TabIndex = 23;
            this.lblUcret.Text = "Ücret:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(896, 66);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(168, 40);
            this.btnGuncelle.TabIndex = 43;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(896, 238);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(168, 40);
            this.buttonAra.TabIndex = 44;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(896, 124);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(168, 40);
            this.buttonSil.TabIndex = 45;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(896, 293);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(168, 22);
            this.txtAra.TabIndex = 46;
            // 
            // labelAra
            // 
            this.labelAra.AutoSize = true;
            this.labelAra.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAra.Location = new System.Drawing.Point(838, 293);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(52, 21);
            this.labelAra.TabIndex = 47;
            this.labelAra.Text = "İsim:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(896, 182);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(168, 40);
            this.buttonTemizle.TabIndex = 48;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // FormMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 531);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.labelAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.lblGirisTar);
            this.Controls.Add(this.lblCikisTar);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.butonListele);
            this.Controls.Add(this.listView1);
            this.Name = "FormMusteriler";
            this.Text = "Müşteri Bilgisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Odano;
        private System.Windows.Forms.ColumnHeader GirisTarihi;
        private System.Windows.Forms.ColumnHeader CikisTarihi;
        private System.Windows.Forms.ColumnHeader Ucret;
        private System.Windows.Forms.Button butonListele;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblGirisTar;
        private System.Windows.Forms.Label lblCikisTar;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label labelAra;
        private System.Windows.Forms.Button buttonTemizle;
    }
}