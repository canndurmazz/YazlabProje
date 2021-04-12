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
    public partial class sözlesme : Form
    {
        public sözlesme()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            bilgilendirme bilgilendirme = new bilgilendirme();
            bilgilendirme.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void sözlesme_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void sözlesme_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void sözlesme_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
