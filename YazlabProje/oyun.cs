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
    public partial class oyun : Form
    {


        SqlConnection baglanti = new SqlConnection(" Data Source = CANPC\\SQLEXPRESS;Initial Catalog = admin; Integrated Security = True");

        public ArrayList soru4 = new ArrayList();
        public ArrayList soru5 = new ArrayList();
        public ArrayList soru6 = new ArrayList();
        public ArrayList soru7 = new ArrayList();
        public ArrayList soru8 = new ArrayList();
        public ArrayList soru9 = new ArrayList();
        public ArrayList soru10 = new ArrayList();

        public ArrayList cevap4 = new ArrayList();
        public ArrayList cevap5 = new ArrayList();
        public ArrayList cevap6 = new ArrayList();
        public ArrayList cevap7 = new ArrayList();
        public ArrayList cevap8 = new ArrayList();
        public ArrayList cevap9 = new ArrayList();
        public ArrayList cevap10 = new ArrayList();

        public void harfdort()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=4 ORDER BY NEWID()",baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }
            }
        }
        public void harfbes()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=5 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }
            }           
        }
        public void harfalti()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=6 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }
            }            
        }
        Random rnd = new Random();
        public void harfyedi()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=7 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }                                          
            }            
        }
        public void harfsekiz()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=8 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }
            }          
        }
        public void harfdokuz()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=9 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    soru4.Add(oku["sorular"].ToString());
                    cevap4.Add(oku["cevaplar"].ToString());
                    verisoru.Text = oku["sorular"].ToString();
                    gizlicevap = oku["cevaplar"].ToString();
                }
            }           
        }
        public void harfon()
        {
            SqlCommand cek = new SqlCommand("SELECT * from oyunn where ıd=10 ORDER BY NEWID()", baglanti);
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                        for (int i = 0; i < 2; i++)
                        {
                soru4.Add(oku["sorular"].ToString());
                cevap4.Add(oku["cevaplar"].ToString());
                verisoru.Text = oku["sorular"].ToString();
                gizlicevap = oku["cevaplar"].ToString();
                         }
            }           
        }

        public oyun()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
        }
          

        string cevapuzunlugu;
        int sayacikici = 4;
        string gizlicevap;
        private void oyun_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            sorucek();
            timer1.Start();
           

        }
        public string ad;
        private void cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Çıkış Yapıldı ! \nOynadığınız İçin Teşekkür Ederiz", "Çıkış !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }
        int sayac = 100;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz Doldu !", "BİTTİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    if (baglanti.State == ConnectionState.Closed)

                        baglanti.Open();
                    string kayit = "insert into oyuncu(puan) values (@puan)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@puan", txttoplam.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    this.Close();
                    Application.Exit();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
                this.Close();
                Application.Exit();
            }
            cubuk.Value = sayac;
            sayac--;
        }

        private void cikis_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Başarıyla Çıkış Yapıldı ! \nOynadığınız İçin Teşekkür Ederiz", "Çıkış !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }

        private void girilencevap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void yanitla_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            //timer1.Start();
            if (girilencevap.Text == gizlicevap)
            {
                //MessageBox.Show("Yeni Soruya Geçiiyor", "Cevap DOğru !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                girilencevap.Text = "";
                sayacikici++;
                puanyazdır();
                sorucek();
            }
            else
            {

                MessageBox.Show("Yanlış Çevap Harf Alabilirsiniz", "Yanlış Cevap !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
       
        private void sorucek()
        {
            sayacsub = 0;
            sayacsub2 = 1;
            sıfır.Text = (sayacikici * 100).ToString();
            txttoplam.Text = (int.Parse(sıfır.Text) + int.Parse(txttoplam.Text)).ToString();
            try
            {
                if (sayacikici == 4)
                    {
                        for (int i = 0; i <2; i++)
                        {
                     baglanti.Open();
                    harfdort();
                    baglanti.Close();
                        baglanti.Open();
                        harfdort();
                        baglanti.Close();
                        }
                  
                }
                else if (sayacikici == 5)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfbes();
                        baglanti.Close();
                    }

                }
                else if (sayacikici == 6)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfalti();
                        baglanti.Close();
                    }

                }
                else if (sayacikici == 7)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfyedi();
                        baglanti.Close();
                    }

                }
                else if (sayacikici == 8)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfsekiz();
                        baglanti.Close();
                    }

                }
                else if (sayacikici == 9)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfdokuz();
                        baglanti.Close();
                    }

                }
                else if (sayacikici == 10)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        baglanti.Open();
                        harfon();
                        baglanti.Close();
                    }

                }
                //if (sayacikici < 11)
                // { 


                //baglanti.Open();
                //SqlCommand komut = new SqlCommand("Select * FROM oyunn where ID=@id", baglanti);

                //komut.Parameters.Add("@id", SqlDbType.Int, 10).Value = sayacikici;
                //SqlDataReader oku = komut.ExecuteReader();
                //while (oku.Read())
                //{
                //    verisoru.Text = oku["sorular"].ToString();
                //    gizlicevap = oku["cevaplar"].ToString();

                //    }
                //baglanti.Close();
                //sayacikici++;
                // }
                else
                {
                    MessageBox.Show("Puanınız Başarıyla Kaydedildi !" + DateTime.Now.ToLongDateString()+
                    DateTime.Now.ToLongTimeString() + " " + txttoplam.Text, "OYUN BİTTİ !", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                         
                        
                        this.Close();
                        Application.Exit();

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                    
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
     

        int sayacsub;
        int sayacsub2 = 1;
        int puancek;
        private void harfal_Click(object sender, EventArgs e)
        {          
            girilencevap.Text = gizlicevap.Substring(sayacsub, sayacsub2);
            sayacsub2++;
            puancek = int.Parse(sıfır.Text);
            puancek = puancek - 100;
            sıfır.Text = puancek.ToString();
            txttoplam.Text = (int.Parse(txttoplam.Text) - 100).ToString();
         
            
        }

        private void cubuk_Click(object sender, EventArgs e)
        {

        }
        private void puanyazdır()
        {
            baglanti.Open();
            string kayit = "Update  oyuncu set puan=@puan where ad=@ad ";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.Add("@puan",SqlDbType.VarChar,15).Value= txttoplam.Text;
            komut.Parameters.Add("@ad", SqlDbType.VarChar, 15).Value = ad;

            komut.ExecuteNonQuery();
            baglanti.Close();
          //  MessageBox.Show("Oyunun Sonuna Geldik", "Paunınız :" + txttoplam, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txttoplam_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void cevap_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            //timer1.Start();
            if (girilencevap.Text == gizlicevap)
            {
                //MessageBox.Show("Yeni Soruya Geçiiyor", "Cevap DOğru !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                girilencevap.Text = "";
                sayacikici++;
                puanyazdır();
                sorucek();
            }
            else
            {

                MessageBox.Show("Yanlış Çevap Harf Alabilirsiniz", "Yanlış Cevap !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (girilencevap.Text == gizlicevap)
            {
                sayacikici++;
                sorucek();
                timer1.Start();
                button1.Visible = false;
                label.Visible = false;
                girilencevap.Clear();
            }
            else
            {
                int len = girilencevap.Text.Length;
                txttoplam.Text = (int.Parse(txttoplam.Text) - ((sayacikici * 100) + (len * 100))).ToString();              
                timer1.Start();                
                timer2.Stop();
                button1.Visible = false;
                label.Visible = false;
                girilencevap.Clear();
                sayacikici++;
                sorucek();
            }
        }
        int sayi ;
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label.Visible = true;
            timer1.Stop();
            sayi = 0;
            timer2.Start();
            

            
            
        }
        
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            label.Text = sayi.ToString();
            sayi++;

            if (sayi == 20)
            {
                timer1.Start();
                timer2.Stop();
                label.Visible = false;
                int len = girilencevap.Text.Length;
                txttoplam.Text = (int.Parse(txttoplam.Text) - ((sayacikici * 100) + (len * 100))).ToString();
                girilencevap.Clear();
                sayacikici++;
                sorucek();
            }
            else if ( sayi > 20)
            {
                button1.Visible = false;
                yanitla.Visible = true;

                timer1.Start();
                timer2.Stop();
                label.Visible = false;
                int len = girilencevap.Text.Length;
                txttoplam.Text = (int.Parse(txttoplam.Text) - ((sayacikici * 100) + (len * 100))).ToString();
                girilencevap.Clear();
                
                sayacikici++;
                sorucek();
            }
        }
        private bool mouseDown;
        private Point lastLocation;
        private void oyun_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void oyun_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void oyun_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }
    }
 }
