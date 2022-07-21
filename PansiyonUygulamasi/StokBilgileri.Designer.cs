
namespace PansiyonUygulamasi
{
    partial class StokBilgileri
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
            this.txticecek = new System.Windows.Forms.TextBox();
            this.txtYiyecek = new System.Windows.Forms.TextBox();
            this.lblicecek = new System.Windows.Forms.Label();
            this.lblTemizlik = new System.Windows.Forms.Label();
            this.txtTemizlik = new System.Windows.Forms.TextBox();
            this.lblYiyecek = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonAzalt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txticecek
            // 
            this.txticecek.Location = new System.Drawing.Point(257, 88);
            this.txticecek.Name = "txticecek";
            this.txticecek.Size = new System.Drawing.Size(216, 22);
            this.txticecek.TabIndex = 14;
            this.txticecek.TextChanged += new System.EventHandler(this.txticecek_TextChanged);
            // 
            // txtYiyecek
            // 
            this.txtYiyecek.Location = new System.Drawing.Point(257, 43);
            this.txtYiyecek.Name = "txtYiyecek";
            this.txtYiyecek.Size = new System.Drawing.Size(216, 22);
            this.txtYiyecek.TabIndex = 13;
            this.txtYiyecek.TextChanged += new System.EventHandler(this.txtYiyecek_TextChanged);
            // 
            // lblicecek
            // 
            this.lblicecek.AutoSize = true;
            this.lblicecek.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblicecek.Location = new System.Drawing.Point(111, 88);
            this.lblicecek.Name = "lblicecek";
            this.lblicecek.Size = new System.Drawing.Size(131, 21);
            this.lblicecek.TabIndex = 12;
            this.lblicecek.Text = "İçecek Miktarı:";
            this.lblicecek.Click += new System.EventHandler(this.lblicecek_Click);
            // 
            // lblTemizlik
            // 
            this.lblTemizlik.AutoSize = true;
            this.lblTemizlik.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemizlik.Location = new System.Drawing.Point(49, 137);
            this.lblTemizlik.Name = "lblTemizlik";
            this.lblTemizlik.Size = new System.Drawing.Size(193, 21);
            this.lblTemizlik.TabIndex = 15;
            this.lblTemizlik.Text = "Temizlik Malzemeleri:";
            this.lblTemizlik.Click += new System.EventHandler(this.lblTemizlik_Click);
            // 
            // txtTemizlik
            // 
            this.txtTemizlik.Location = new System.Drawing.Point(257, 137);
            this.txtTemizlik.Name = "txtTemizlik";
            this.txtTemizlik.Size = new System.Drawing.Size(216, 22);
            this.txtTemizlik.TabIndex = 16;
            this.txtTemizlik.TextChanged += new System.EventHandler(this.txtTemizlik_TextChanged);
            // 
            // lblYiyecek
            // 
            this.lblYiyecek.AutoSize = true;
            this.lblYiyecek.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYiyecek.Location = new System.Drawing.Point(100, 43);
            this.lblYiyecek.Name = "lblYiyecek";
            this.lblYiyecek.Size = new System.Drawing.Size(142, 21);
            this.lblYiyecek.TabIndex = 17;
            this.lblYiyecek.Text = "Yiyecek Miktarı:";
            this.lblYiyecek.Click += new System.EventHandler(this.lblYiyecek_Click_1);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(365, 189);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(108, 47);
            this.buttonEkle.TabIndex = 18;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonAzalt
            // 
            this.buttonAzalt.Location = new System.Drawing.Point(257, 189);
            this.buttonAzalt.Name = "buttonAzalt";
            this.buttonAzalt.Size = new System.Drawing.Size(102, 47);
            this.buttonAzalt.TabIndex = 19;
            this.buttonAzalt.Text = "Azalt";
            this.buttonAzalt.UseVisualStyleBackColor = true;
            this.buttonAzalt.Click += new System.EventHandler(this.buttonAzalt_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 142);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "no";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yiyecek Stoğu";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İçecek Stoğu";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Temizlik Mal. Stoğu";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Tarihi";
            this.columnHeader5.Width = 108;
            // 
            // StokBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonAzalt);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.lblYiyecek);
            this.Controls.Add(this.txtTemizlik);
            this.Controls.Add(this.lblTemizlik);
            this.Controls.Add(this.txticecek);
            this.Controls.Add(this.txtYiyecek);
            this.Controls.Add(this.lblicecek);
            this.Name = "StokBilgileri";
            this.Text = "Stok Bilgileri";
            this.Load += new System.EventHandler(this.StokBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txticecek;
        private System.Windows.Forms.TextBox txtYiyecek;
        private System.Windows.Forms.Label lblicecek;
        private System.Windows.Forms.Label lblTemizlik;
        private System.Windows.Forms.TextBox txtTemizlik;
        private System.Windows.Forms.Label lblYiyecek;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonAzalt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}