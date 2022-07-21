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
    public partial class FormOdalar : Form
    {
        public FormOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True");
        private void FormOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OdaMusKayit where c_tarihi >= getdate(); ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["oda_id"].ToString() == "101")
                {
                    btn101.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn101.BackColor = Color.Red;
                    btn101.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "102")
                {
                    btn102.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn102.BackColor = Color.Red;
                    btn102.Enabled = false;
                }

                if (oku["Mus_adi"].ToString() == "103")
                {
                    btn103.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn103.BackColor = Color.Red;
                    btn103.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "104")
                {
                    btn104.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn104.BackColor = Color.Red;
                    btn104.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "105")
                {
                    btn105.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn105.BackColor = Color.Red;
                    btn105.Enabled = false;
                }

                if (oku["oda_id"].ToString() == "106")
                {
                    btn106.Text = oku["Mus_adi"].ToString() + " " + oku["Mus_soyadi"].ToString() + " " + " - Çıkış Tarihi: " + oku["c_Tarihi"];
                    btn106.BackColor = Color.Red;
                    btn106.Enabled = false;
                }
            }
            baglanti.Close();


        }
    }
}
