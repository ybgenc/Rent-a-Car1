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
    public partial class FormSozlesme : Form
    {
        public FormSozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Integrated Security=True";

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * from [NTPRentACar].[dbo].[Araclar] where Durum = 'Müsait'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxSozlesmeArac.Items.Add(read["Plaka"]);
            }
        }
        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * from  [NTPRentACar].[dbo].[Sozlesme]";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSozlesme.DataSource = dt;
            baglanti.Close();

        }

        private void FormSozlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }

        private void comboBoxSozlesmeArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * from [NTPRentACar].[dbo].[Araclar] where Plaka like'" + comboBoxSozlesmeArac.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBoxSozlesmeMarka.Text = read["Marka"].ToString();
                textBoxSozlesmeSeri.Text = read["Seri"].ToString();
                textBoxSozlesmeModel.Text = read["Model"].ToString();
                textBoxSozlesmeRenk.Text = read["Renk"].ToString();

            }
        }

        private void buttonSozlesmeUcretHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunFarki = DateTime.Parse(dateTimePickerSozlesmeTeslimTarihi.Text) - DateTime.Parse(dateTimePickerSozlesmeKiraTarihi.Text);
            int gunHesap = gunFarki.Days;
            textBoxSozlesmeGun.Text = gunFarki.ToString();
            textBoxSozlesmeTutar.Text = (gunHesap * int.Parse(textBoxSozlesmeKiraUcret.Text)).ToString();

        }

        private void comboBoxSozlesmeKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = " Select Kira_Ucreti from [NTPRentACar].[dbo].[Araclar] ";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if(comboBoxSozlesmeKiraSekli.SelectedIndex == 0)
                {
                    textBoxSozlesmeKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 1).ToString();

                }
                else if (comboBoxSozlesmeKiraSekli.SelectedIndex == 1)
                {
                    textBoxSozlesmeKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.75).ToString();

                }
                else if (comboBoxSozlesmeKiraSekli.SelectedIndex ==2)
                {
                    textBoxSozlesmeKiraUcret.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.50).ToString();

                }
            }
        }

        private void buttonSozlesmeAracEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into  [NTPRentACar].[dbo].[Sozlesme] Values (@TcNo,@AdSoyad,@Telefon,@EhliyetNo,@EhliyetTarih,@Plaka,@Marka,@Seri,@Model,@KiraSekli,@Renk,@KiraUcreti,@ToplamKiraGunu,@Ucret,@CikisTarihi,@DonusTarihi)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@TcNo", textBoxSozlesmeTcNo.Text);
            komut.Parameters.AddWithValue("@AdSoyad",textBoxSozlesmeAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon",textBoxSozlesmeTelNo.Text);
            komut.Parameters.AddWithValue("@EhliyetNo",textBoxSozlesmeEhliyetNo.Text);
            komut.Parameters.AddWithValue("@EhliyetTarih",textBoxSozlesmeEhliyetTarih.Text);
            komut.Parameters.AddWithValue("@Plaka",comboBoxSozlesmeArac.SelectedItem);
            komut.Parameters.AddWithValue("@Marka",textBoxSozlesmeMarka.Text);
            komut.Parameters.AddWithValue("@Seri",textBoxSozlesmeSeri.Text);
            komut.Parameters.AddWithValue("@Model",textBoxSozlesmeModel.Text);
            komut.Parameters.AddWithValue("@KiraSekli",comboBoxSozlesmeKiraSekli.Text);
            komut.Parameters.AddWithValue("@Renk",textBoxSozlesmeRenk.Text);
            komut.Parameters.AddWithValue("@KiraUcreti",textBoxSozlesmeKiraUcret.Text);
            komut.Parameters.AddWithValue("@ToplamKiraGunu",textBoxSozlesmeGun.Text);
            komut.Parameters.AddWithValue("@Ucret",textBoxSozlesmeTutar.Text);
            komut.Parameters.AddWithValue("@CikisTarihi",dateTimePickerSozlesmeKiraTarihi.Text);
            komut.Parameters.AddWithValue("@DonusTarihi",dateTimePickerSozlesmeTeslimTarihi.Text);

            string komutCumlesiDegistir = "Update  [NTPRentACar].[dbo].[Araclar] set Durum = 'Kiralandı' where Plaka = '" + comboBoxSozlesmeArac.SelectedItem + "'";
            SqlCommand komutDegistir = new SqlCommand(komutCumlesiDegistir, baglanti);
            komut.ExecuteNonQuery();
            komutDegistir.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();
            MessageBox.Show("Araç Kaydedildi");

        }

      

        private void buttonSozlesmeCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSozlesmeMusteriAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = " Select * from [NTPRentACar].[dbo].[Musteriler] where Tc_No like '" +textBoxSozlesmeMusteriAra.Text + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                textBoxSozlesmeTcNo.Text = read["Tc_No"].ToString();
                textBoxSozlesmeAdSoyad.Text = read["Ad_Soyad"].ToString();
                textBoxSozlesmeTelNo.Text = read["Telefon_Numarasi"].ToString();
               
            }

        }

        private void buttonSozlesmeTeslimAl_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridViewSozlesme.CurrentRow;
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from [NTPRentACar].[dbo].[Sozlesme] Where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();

            string komutCumlesiDegistirr = "update [NTPRentACar].[dbo].[Araclar] set Durum = 'Müsait' where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'" ;
            SqlCommand komutDegistirr = new SqlCommand(komutCumlesiDegistirr, baglanti);
            komutDegistirr.ExecuteNonQuery();

            string komutCumlesiSatis = "Insert Into [NTPRentACar].[dbo].[Satislar] Values (@TcNo,@AdSoyad,@Telefon,@Plaka,@KiraSekli,@KiraUcreti,@Ucret,@CikisTarihi,@DonusTarihi)";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);
            komutSatis.Parameters.AddWithValue("@TcNo", satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@AdSoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Telefon", satir.Cells["Telefon"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@KiraSekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@KiraUcreti", satir.Cells["Kira_Ucreti"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Ucret", satir.Cells["Ucret"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@CikisTarihi", satir.Cells["Cikis_Tarihi"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@DonusTarihi", satir.Cells["Donus_Tarihi"].Value.ToString());
            komutSatis.ExecuteNonQuery();
            
            MessageBox.Show("Araç Teslim Alındı");
        }
    }
}
