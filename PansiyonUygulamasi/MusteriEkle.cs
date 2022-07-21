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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void lblCikisTar_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan gun = cikisTarihi - girisTarihi;
            lblGunSayisi.Text = gun.TotalDays.ToString();

            ucret = Convert.ToInt32(lblGunSayisi.Text) * 100;
            txtUcret.Text = ucret.ToString();
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Oda");
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Oda.");
        }

        private void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            comboBox1.Text = "";
            txtMail.Clear();
            txtOdaNo.Clear();
            txtTc.Clear();
            txtUcret.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
        
        int Mus_id = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || dateTimePicker1.Value < DateTime.Today || dateTimePicker2.Value<= DateTime.Now) 
            {
                MessageBox.Show("Yanlış bilgiler girdiniz. Lütfen kontrol ediniz.");
            }
            else
            {
                string ad, soyad, telefon, mail, tc, cinsiyet, odano, gTarih, cTarih, ucret;
                ad = txtAd.Text;
                soyad = txtSoyad.Text;
                mail = txtMail.Text;
                telefon = maskedTextBox1.Text;
                tc = txtTc.Text;
                cinsiyet = comboBox1.Text;
                odano = txtOdaNo.Text;
                gTarih = dateTimePicker1.Value.ToString("yyyy - MM - dd");
                cTarih = dateTimePicker2.Value.ToString("yyyy - MM - dd");
                ucret = txtUcret.Text;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle" +
                    "(Mus_adi,Mus_soyadi,Mus_tel,Mus_mail,Mus_tc, Mus_cinsiyet,Oda_no,g_Tarihi,c_Tarihi,ucret)"
                    + "values('" + ad + "','" + soyad + "','" + telefon + "', '" + mail + "', + '" + tc + "', '" + cinsiyet + "', '" + odano + "', '" + gTarih + "','" + cTarih + "','" + ucret + "')", baglanti);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("select * from MusteriEkle order by Mus_id desc offset 0 rows fetch next 1 rows only", baglanti);
                SqlDataReader oku = komut2.ExecuteReader();
                if (oku.Read())
                {
                    Mus_id = Convert.ToInt32(oku["Mus_id"]);
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("INSERT INTO OdaMusKayit" +
                    "(oda_id,Mus_id,Mus_adi,Mus_soyadi,c_Tarihi)" +
                    "values('" + txtOdaNo.Text + "', '" + Mus_id + "', '" + txtAd.Text + "', '" + txtSoyad.Text
                    + "', '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Müşteri Kaydedildi.");
                temizle();
            }
            
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OdaMusKayit where c_tarihi >= getdate(); ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["oda_id"].ToString() == "101")
                {
                    btn101.Text = oku["Mus_adi"].ToString();
                    btn101.BackColor = Color.Red;
                    btn101.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "102")
                {
                    btn102.Text = oku["Mus_adi"].ToString();
                    btn102.BackColor = Color.Red;
                    btn102.Enabled = false;
                }

                if (oku["Mus_adi"].ToString() == "103")
                {
                    btn103.Text = oku["Mus_adi"].ToString();
                    btn103.BackColor = Color.Red;
                    btn103.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "104")
                {
                    btn104.Text = oku["Mus_adi"].ToString();
                    btn104.BackColor = Color.Red;
                    btn104.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "105")
                {
                    btn105.Text = oku["Mus_adi"].ToString();
                    btn105.BackColor = Color.Red;
                    btn105.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "106")
                {
                    btn106.Text = oku["Mus_adi"].ToString();
                    btn106.BackColor = Color.Red;
                    btn106.Enabled = false;
                }
            }
            baglanti.Close();


        }
    }
    //Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True
}
