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
    public partial class formMusteriListele : Form
    {
        public formMusteriListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Initial Catalog=NTPRentACar;Integrated Security=True";
        private void formMusteriListele_Load(object sender, EventArgs e)
        {
            formMusteri_Listele();
        }
        public void formMusteri_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);  
            baglanti.Open();

            string komutCumlesi = "Select * From Musteriler";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTcNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxEposta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Musteriler set Ad_Soyad = @AdSoyad, Telefon_Numarasi = @TelefonNo, EPosta = @EPosta, Adres = @Adres Where Tc_No = @TcNo ";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
         
            komut.Parameters.AddWithValue("@TcNo", textBoxTcNo.Text);
            komut.Parameters.AddWithValue("AdSoyad", textBoxAdSoyad.Text);
            komut.Parameters.AddWithValue("@TelefonNo",maskedTextBoxTelNo.Text);
            komut.Parameters.AddWithValue("@EPosta", textBoxEposta.Text);
            komut.Parameters.AddWithValue("@Adres", textBoxAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            formMusteri_Listele();


        }

        private void buttonMusteriSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from Musteriler where Tc_No= '" + dataGridView1.CurrentRow.Cells["Tc_No"].Value.ToString()+ "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            formMusteri_Listele();

        }

        private void buttonMusteriKaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
