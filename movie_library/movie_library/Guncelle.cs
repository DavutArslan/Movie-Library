using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace movie_library
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DAVIDOOF;Initial Catalog=MovieLibrary;Integrated Security=True");
        private void Guncelle_Load(object sender, EventArgs e)
        {
            txtId.Text = ID;
            txtFilmAd.Text = AD;
            txtFilmKategori.Text = KATEGORI;
            txtFilmTime.Text = TIME;
            txtFilmDırector.Text = DIRECTOR;
            txtFilmLink.Text = FRAGMAN;
        }
        static public string ID, AD, KATEGORI, TIME, DIRECTOR, FRAGMAN;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLMOVİEE set AD=@AD,KATEGORI=@KATEGORI,TIME=@TIME,DIRECTOR=@DIRECTOR,FRAGMAN=@FRAGMAN where ID = @FilmID", baglanti);
            komut.Parameters.AddWithValue("@FilmID", txtId.Text);
            komut.Parameters.AddWithValue("@AD", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@KATEGORI", txtFilmKategori.Text);
            komut.Parameters.AddWithValue("@TIME", txtFilmTime.Text);
            komut.Parameters.AddWithValue("@DIRECTOR", txtFilmDırector.Text);
            komut.Parameters.AddWithValue("@FRAGMAN", txtFilmLink.Text);





            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("FİLM BAŞARIYLA GÜNCELLENMİŞTİR.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();






        }
    }
}
