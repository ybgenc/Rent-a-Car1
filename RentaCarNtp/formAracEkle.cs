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
    public partial class formAracEkle : Form
    {
        public formAracEkle()
        {
            InitializeComponent();
        }
        private string baglantıCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Initial Catalog=NTPRentACar;Integrated Security=True";

        private void buttonMusteriCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEkleMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEkleMarka.SelectedIndex == 0)
            {
                comboBoxEkleSeri.Items.Clear();
                comboBoxEkleSeri.Items.Add("1 Serisi");
                comboBoxEkleSeri.Items.Add("2 Serisi");
                comboBoxEkleSeri.Items.Add("3 Serisi");
                comboBoxEkleSeri.Items.Add("5 Serisi");
                comboBoxEkleSeri.Items.Add("M Serisi");

            }
            else if(comboBoxEkleMarka.SelectedIndex == 1)
            {
                comboBoxEkleSeri.Items.Clear();
                comboBoxEkleSeri.Items.Add("A Serisi");
                comboBoxEkleSeri.Items.Add("B Serisi");
                comboBoxEkleSeri.Items.Add("C Serisi");
                comboBoxEkleSeri.Items.Add("E Serisi");
                comboBoxEkleSeri.Items.Add("S Serisi");
                

            }
            else if (comboBoxEkleMarka.SelectedIndex == 2)
            {
                comboBoxEkleSeri.Items.Clear();
                comboBoxEkleSeri.Items.Add("A1");
                comboBoxEkleSeri.Items.Add("A3");
                comboBoxEkleSeri.Items.Add("A4");
                comboBoxEkleSeri.Items.Add("A5");
                comboBoxEkleSeri.Items.Add("A6");

            }
            else if (comboBoxEkleMarka.SelectedIndex == 3)
            {
                comboBoxEkleSeri.Items.Clear();
                comboBoxEkleSeri.Items.Add("Polo");
                comboBoxEkleSeri.Items.Add("Golf");
                comboBoxEkleSeri.Items.Add("Jetta");
                comboBoxEkleSeri.Items.Add("Arteon");
                comboBoxEkleSeri.Items.Add("Passat"); 

            }
        }

        private void buttonEkleKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantıCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar Values (@plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakıt,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi,baglanti);

            komut.Parameters.AddWithValue("@Plaka", textBoxEklePlaka.Text);
            komut.Parameters.AddWithValue("@Marka", comboBoxEkleMarka.Text);
            komut.Parameters.AddWithValue("@Seri",  comboBoxEkleSeri.Text);
            komut.Parameters.AddWithValue("@Model", textBoxEkleModel.Text);
            komut.Parameters.AddWithValue("@Renk",  textBoxEkleRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", textBoxEkleKilometre.Text);
            komut.Parameters.AddWithValue("@Yakıt", comboBoxEkleYakıt.Text);
            komut.Parameters.AddWithValue("@Ucret", textBoxEkleUcret.Text);
            komut.Parameters.AddWithValue("@Durum", comboBoxEkleDurum.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Başarıyla Eklendi");
        }
    }
}
