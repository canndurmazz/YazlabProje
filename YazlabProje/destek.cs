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
using System.Collections;


namespace YazlabProje
{
    public partial class destek : Form
    {
        SqlConnection baglanti = new SqlConnection(" Data Source = CANPC\\SQLEXPRESS;Initial Catalog = admin; Integrated Security = True");
        public destek()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adiniz.Text) == true || string.IsNullOrEmpty(soyadiniz.Text) == true || string.IsNullOrEmpty(emailiniz.Text) == true
                || string.IsNullOrEmpty(telefonunuz.Text) == true || string.IsNullOrEmpty(konunuz.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into destek(adınız,soyadınız,telefonunuz,emailiniz,konunuz) values (@adınız,@soyadınız,@telefonunuz,@emailiniz,@konunuz)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@adınız", adiniz.Text);
                    komut.Parameters.AddWithValue("@soyadınız", soyadiniz.Text);
                    komut.Parameters.AddWithValue("@emailiniz", emailiniz.Text);
                    komut.Parameters.AddWithValue("@telefonunuz", telefonunuz.Text);
                    komut.Parameters.AddWithValue("@konunuz", konunuz.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Destek Talebiniz Başarıyla İletildi");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void destek_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void destek_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void destek_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
