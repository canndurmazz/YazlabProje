using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YazlabProje
{
    public partial class adsoyad : Form
    {
        public adsoyad()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(" Data Source = CANPC\\SQLEXPRESS;Initial Catalog = admin; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)

                        baglanti.Open();

                    string kayit = "insert into oyuncu(ad,soyad) values (@ad,@soyad)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox1.Text);
                    komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    //MessageBox.Show("Ad-Soyad Bilgileriniz Kaydedildi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    oyun oyun = new oyun();
                    oyun.ad = textBox1.Text;
                    oyun.Show();
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }          
        }
      
        private void adsoyad_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void adsoyad_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void adsoyad_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void adsoyad_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
