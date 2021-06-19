using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace movie_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DAVIDOOF;Initial Catalog=MovieLibrary;Integrated Security=True");


        private void filmListele(int sayac)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMOVİEE", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (sayac == -2)
            {
                sayac = dt.Rows.Count - 1;
            }
            lblFilmId.Text = dt.Rows[sayac]["ID"].ToString();
            lblAd.Text = dt.Rows[sayac]["AD"].ToString();
            lblKategori.Text = dt.Rows[sayac]["KATEGORI"].ToString();
            lblTime.Text = dt.Rows[sayac]["TIME"].ToString();
            lbldirector.Text = dt.Rows[sayac]["DIRECTOR"].ToString();
            lblfragman.Text = dt.Rows[sayac]["FRAGMAN"].ToString();
            lblFilmId.Text = dt.Rows[sayac]["ID"].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmListele(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //sol tarafa birer birer gidebilmek için
        private void button2_Click(object sender, EventArgs e)
        {
            if (sayaci != 0)
            {
                sayaci--;
            }
            filmListele(sayaci);



        }
        //kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMOVİEE (AD,KATEGORI,TIME,DIRECTOR,FRAGMAN) values (@P1,@P2,@P3,@P4,@P5)", baglanti);

            komut.Parameters.AddWithValue("@P1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@P2", txtFilmKategori.Text);
            komut.Parameters.AddWithValue("@P3", txtFilmTime.Text);
            komut.Parameters.AddWithValue("@P4", txtFilmDırector.Text);
            komut.Parameters.AddWithValue("@P5", txtFilmLink.Text);




            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("FİLM LİSTENİZEZE EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmListele(0);
            
            txtFilmAd.Clear();
            txtFilmKategori.Clear();
            txtFilmTime.Clear();
            txtFilmDırector.Clear();
            txtFilmLink.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //sona gitmek için
        private void button5_Click(object sender, EventArgs e)
        {
            filmListele(-2);
        }
        int sayaci = 0;


        //sağ tarafa birer birer gidebilmek için
        private void btn_SagListele_Click(object sender, EventArgs e)
        {
            try
            {
                sayaci++;
                filmListele(sayaci);
            }
            catch (Exception)
            {
                sayaci--;

            }


        }
        //silme işlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLMOVİEE where ID = @FilmID", baglanti);

            komut.Parameters.AddWithValue("@FilmID", lblFilmId.Text);




            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("FİLM LİSTENİZDEN SİLİNMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (sayaci != 0)
            {
                sayaci--;
            }
            filmListele(sayaci);


        }
        //güncelle 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle.ID = lblFilmId.Text;
            Guncelle.AD = lblAd.Text;
            Guncelle.KATEGORI = lblKategori.Text;
            Guncelle.TIME = lblTime.Text;
            Guncelle.DIRECTOR = lbldirector.Text;
            Guncelle.FRAGMAN = lblfragman.Text;

            Guncelle gunc = new Guncelle();
            gunc.ShowDialog();
            filmListele(sayaci);

        }


        //fragman
        private void lblfragman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMOVİEE", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Process.Start(dt.Rows[0]["FRAGMAN"].ToString());
            webBrowser1.Navigate(lblfragman.Text);

        }
        //yapay zeka yönlendirmesi
        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:8888/lab/tree/Untitled1.ipynb");

        }
    }
}
