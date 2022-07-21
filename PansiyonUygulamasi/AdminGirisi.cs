using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonUygulamasi
{
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanicilar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                string kullaniciAdi, kullaniciSifre;
                kullaniciAdi = txtKullaniciAdi.Text;
                kullaniciSifre = txtKullaniciSifre.Text;

                if (oku["kullanici_adi"].ToString() == kullaniciAdi && oku["kullanici_sifre"].ToString() == kullaniciSifre)
                {
                    Anasayfa fr = new Anasayfa();
                    fr.Show();       
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız. Bilgilerinizi kontrol ediniz.");
                }
            }
            baglanti.Close();
        }
    }
}
