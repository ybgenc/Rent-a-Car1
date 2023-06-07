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
    public partial class FormAracListesi : Form
    {
        public FormAracListesi()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Initial Catalog=NTPRentACar;Integrated Security=True";
        private void formAracListesi_Load(object sender, EventArgs e)
        {
            formAracListesi();
        }
        public void formAracListesi()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracListelePlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxAracListeleMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxAracListeleSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxAracListeleModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAracListeleRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAracListeleKilometre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBoxAracListeleYakıt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxAracListeleUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBoxAracListeleDurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void buttonAracListeleCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAracListeleMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAracListeleMarka.SelectedIndex == 0)
            {
                comboBoxAracListeleSeri.Items.Clear();
                comboBoxAracListeleSeri.Items.Add("1 Serisi");
                comboBoxAracListeleSeri.Items.Add("2 Serisi");
                comboBoxAracListeleSeri.Items.Add("3 Serisi");
                comboBoxAracListeleSeri.Items.Add("5 Serisi");
                comboBoxAracListeleSeri.Items.Add("M Serisi");

            }
            else if (comboBoxAracListeleMarka.SelectedIndex == 1)
            {
                comboBoxAracListeleSeri.Items.Clear();
                comboBoxAracListeleSeri.Items.Add("A Serisi");
                comboBoxAracListeleSeri.Items.Add("B Serisi");
                comboBoxAracListeleSeri.Items.Add("C Serisi");
                comboBoxAracListeleSeri.Items.Add("E Serisi");
                comboBoxAracListeleSeri.Items.Add("S Serisi");


            }
            else if (comboBoxAracListeleMarka.SelectedIndex == 2)
            {
                comboBoxAracListeleSeri.Items.Clear();
                comboBoxAracListeleSeri.Items.Add("A1");
                comboBoxAracListeleSeri.Items.Add("A3");
                comboBoxAracListeleSeri.Items.Add("A4");
                comboBoxAracListeleSeri.Items.Add("A5");
                comboBoxAracListeleSeri.Items.Add("A6");

            }
            else if (comboBoxAracListeleMarka.SelectedIndex == 3)
            {
                comboBoxAracListeleSeri.Items.Clear();
                comboBoxAracListeleSeri.Items.Add("Polo");
                comboBoxAracListeleSeri.Items.Add("Golf");
                comboBoxAracListeleSeri.Items.Add("Jetta");
                comboBoxAracListeleSeri.Items.Add("Arteon");
                comboBoxAracListeleSeri.Items.Add("Passat");

            }
        }

        

     

        private void buttonMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka = @Marka, Seri = @Seri, Model = @Model, Renk = @Renk, Kilometre = @Kilometre,Yakıt = @Yakıt, Kira_Ucreti = @Kira_Ucreti, Durum = @Durum Where Plaka = @Plaka ";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Plaka", textBoxAracListelePlaka.Text);
            komut.Parameters.AddWithValue("Marka", comboBoxAracListeleMarka.Text);
            komut.Parameters.AddWithValue("@Seri", comboBoxAracListeleSeri.Text);
            komut.Parameters.AddWithValue("@Model", textBoxAracListeleModel.Text);
            komut.Parameters.AddWithValue("@Renk", textBoxAracListeleRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", textBoxAracListeleKilometre.Text);
            komut.Parameters.AddWithValue("@Yakıt", comboBoxAracListeleYakıt.Text);
            komut.Parameters.AddWithValue("@Kira_Ucreti", textBoxAracListeleUcret.Text);
            komut.Parameters.AddWithValue("@Durum", comboBoxAracListeleDurum.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            formAracListesi();

        }

        private void buttonMusteriSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from Araclar where Plaka= '" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            formAracListesi();

        }

        private void FormAracListesi_Load_1(object sender, EventArgs e)
        {
            formAracListesi();
        }
    }
}
