using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCarNtp
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMusteriEkle musteriEkle = new formMusteriEkle();
            musteriEkle.Show();

        }

        private void buttonMusteriListesi_Click(object sender, EventArgs e)
        {
            formMusteriListele musteriListele = new formMusteriListele();
            musteriListele.Show();
        }

        private void buttonGuvenliCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonArabaEkle_Click(object sender, EventArgs e)
        {
            formAracEkle AracEkle = new formAracEkle();
            AracEkle.Show();
        }

        private void buttonArabaListesi_Click(object sender, EventArgs e)
        {
            FormAracListesi aracListesi = new FormAracListesi();
            aracListesi.Show();
        }

        private void buttonSozlesme_Click(object sender, EventArgs e)
        {
            FormSozlesme sozlesme = new FormSozlesme();
            sozlesme.Show();
        }

        private void buttonSatıslar_Click(object sender, EventArgs e)
        {
            FormSatislar satislar = new FormSatislar();
            satislar.Show();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
