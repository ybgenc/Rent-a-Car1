using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentaCarNtp
{
    public partial class formMusteriEkle : Form
    {
        public formMusteriEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Initial Catalog=NTPRentACar;Integrated Security=True";
        

        private void buttonMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Musteriler Values(@TcNo,@AdSoyad,@TelefonNo,@EPosta,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@TcNo", textBoxTcNo.Text);
            komut.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelefonNo", maskedTextBoxTelNo.Text);
            komut.Parameters.AddWithValue("@EPosta", textBoxEposta.Text);
            komut.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarılı");
        }

       

        private void buttonMusteriCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
