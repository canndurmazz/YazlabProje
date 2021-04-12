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
    public partial class Form1 : Form
    {

      

       
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
                                               
        SqlConnection baglanti = new SqlConnection(" Data Source = CANPC\\SQLEXPRESS;Initial Catalog = admin; Integrated Security = True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();

        }      
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        string cevapuzunlugu;
        private void giris_Click(object sender, EventArgs e)
        {

            bilgilendirme bilgilendirme = new bilgilendirme();
            bilgilendirme.Show();
            this.Hide();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Çıkış Yapıldı ! \nOynadığınız İçin Teşekkür Ederiz", "Çıkış !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }
        
     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yanitla_Click(object sender, EventArgs e)
        {

        }

        private void yönetici_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
           
            giris.Show();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            destek destek = new destek();
            destek.Show();
            this.Hide();
        }    
        private void button3_Click_1(object sender, EventArgs e)
        {
            hakkımda hakkımda = new hakkımda();
            hakkımda.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            puantablosu puantablosu = new puantablosu();
            puantablosu.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
