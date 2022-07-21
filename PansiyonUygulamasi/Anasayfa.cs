using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGirisi fr = new AdminGirisi();
            fr.Show();
            
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle fr = new MusteriEkle();
            fr.Show();
           
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FormOdalar fr = new FormOdalar();
            fr.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void butonMusteriler_Click(object sender, EventArgs e)
        {
            FormMusteriler fr = new FormMusteriler();
            fr.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonStok_Click(object sender, EventArgs e)
        {
            StokBilgileri fr = new StokBilgileri();
            fr.Show();
        }
    }
}
