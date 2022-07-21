using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PansiyonUygulamasi
{
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");

        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mus_id"].ToString();
                ekle.SubItems.Add(oku["Mus_adi"].ToString());
                ekle.SubItems.Add(oku["Mus_soyadi"].ToString());
                ekle.SubItems.Add(oku["Mus_tel"].ToString());
                ekle.SubItems.Add(oku["Mus_mail"].ToString());
                ekle.SubItems.Add(oku["Mus_tc"].ToString());
                ekle.SubItems.Add(oku["Mus_cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Oda_no"].ToString());
                ekle.SubItems.Add(oku["g_Tarihi"].ToString());
                ekle.SubItems.Add(oku["c_Tarihi"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());

                listView1.Items.Add(ekle);

            }

            baglanti.Close();
            

        }
        private void butonListele_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        int id = 0; 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Mus_id = ("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from OdaMusKayit where Mus_id = ("+id+")", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            comboBox1.Text= "";
            txtMail.Clear();
            txtOdaNo.Clear();
            txtTc.Clear();
            txtUcret.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Mus_adi = '" + txtAd.Text + "', Mus_soyadi = '" + txtSoyad.Text +
                "', Mus_tel= '" + maskedTextBox1.Text + "', Mus_mail = '" + txtMail.Text + "', Mus_tc = '" + txtTc.Text + "', Mus_cinsiyet = '" + comboBox1.Text +
                "', Oda_no = '" + txtOdaNo.Text + "', g_Tarihi = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                "', c_Tarihi = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', ucret = '" + txtUcret.Text + "' where Mus_id = "+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Mus_adi like '%"+txtAra.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mus_id"].ToString();
                ekle.SubItems.Add(oku["Mus_adi"].ToString());
                ekle.SubItems.Add(oku["Mus_soyadi"].ToString());
                ekle.SubItems.Add(oku["Mus_tel"].ToString());
                ekle.SubItems.Add(oku["Mus_mail"].ToString());
                ekle.SubItems.Add(oku["Mus_tc"].ToString());
                ekle.SubItems.Add(oku["Mus_cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Oda_no"].ToString());
                ekle.SubItems.Add(oku["g_Tarihi"].ToString());
                ekle.SubItems.Add(oku["c_Tarihi"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());

                listView1.Items.Add(ekle);

            }

            baglanti.Close();

        }
    }
}
