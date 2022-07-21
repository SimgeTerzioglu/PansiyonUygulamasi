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
    public partial class StokBilgileri : Form
    {
        public StokBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");


        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = (oku["stok_id"].ToString());
                ekle.SubItems.Add(oku["yiyecekler"].ToString());
                ekle.SubItems.Add(oku["icecekler"].ToString());
                ekle.SubItems.Add(oku["temizlik_malzemeleri"].ToString());
                ekle.SubItems.Add(oku["islem_tarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        int stok_id = 0;
        private void buttonAzalt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int yiyecek = Convert.ToInt32(txtYiyecek.Text);
            int icecek = Convert.ToInt32(txticecek.Text);
            int temizlik = Convert.ToInt32(txtTemizlik.Text);
            
            SqlCommand komut2 = new SqlCommand("select * from Stoklar order by stok_id desc offset 0 rows fetch next 1 rows only", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            
            if (oku.Read())
            {
                stok_id = Convert.ToInt32(oku["stok_id"]);

                int yeni_yiyecek = Convert.ToInt32(oku["yiyecekler"]) - yiyecek;
                int yeni_icecek = Convert.ToInt32(oku["icecekler"]) - icecek;
                int yeni_temizlik = Convert.ToInt32(oku["temizlik_malzemeleri"]) - temizlik;

                baglanti.Close();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Stoklar" +
                    "(yiyecekler,icecekler,temizlik_malzemeleri,islem_tarihi)"
                    + "values('" + yeni_yiyecek + "','" + yeni_icecek + "','" + yeni_temizlik + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            verileriGoster();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int yiyecek = Convert.ToInt32(txtYiyecek.Text);
            int icecek = Convert.ToInt32(txticecek.Text);
            int temizlik = Convert.ToInt32(txtTemizlik.Text);

            SqlCommand komut2 = new SqlCommand("select * from Stoklar order by stok_id desc offset 0 rows fetch next 1 rows only", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();

            if (oku.Read())
            {
                stok_id = Convert.ToInt32(oku["stok_id"]);

                int yeni_yiyecek = Convert.ToInt32(oku["yiyecekler"]) + yiyecek;
                int yeni_icecek = Convert.ToInt32(oku["icecekler"]) + icecek;
                int yeni_temizlik = Convert.ToInt32(oku["temizlik_malzemeleri"]) + temizlik;

                baglanti.Close();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Stoklar" +
                    "(yiyecekler,icecekler,temizlik_malzemeleri,islem_tarihi)"
                    + "values('" + yeni_yiyecek + "','" + yeni_icecek + "','" + yeni_temizlik + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            verileriGoster();
        }

        private void lblYiyecek_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTemizlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTemizlik_Click(object sender, EventArgs e)
        {

        }

        private void txticecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYiyecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblicecek_Click(object sender, EventArgs e)
        {

        }

        private void StokBilgileri_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }
    }
}
