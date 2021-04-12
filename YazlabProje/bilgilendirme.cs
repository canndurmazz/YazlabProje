using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazlabProje
{
    public partial class bilgilendirme : Form
    {
        public bilgilendirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                adsoyad adsoyad = new adsoyad();
                adsoyad.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Oyuna Başlamak İçin Gizlilik Sözleşmesini Kabul Etmeniz Gerekir!", "Gizlikik Sözleşmesi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            sözlesme sözlesme = new sözlesme();
            sözlesme.Show();
            this.Hide();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void bilgilendirme_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void bilgilendirme_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bilgilendirme_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
