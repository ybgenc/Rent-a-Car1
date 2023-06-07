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
    public partial class FormSatislar : Form
    {
        public FormSatislar()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-2PJ9TTS\SQLEXPRESS;Integrated Security=True";

        private void FormSatislar_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From [NTPRentACar].[dbo].[Satislar]";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
    }
}
