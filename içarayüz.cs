using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class içarayüz : Form
    {
        public içarayüz()
        {
            InitializeComponent();
        }

        private void içarayüz_Load(object sender, EventArgs e)
        {
            
        }

        private void alma_button_Click(object sender, EventArgs e)
        {
            alma_button.BackgroundImageLayout = ImageLayout.Stretch;
            kitapalma1.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapbagis1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            


        }

        private void içarayüz_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog==DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Application.Exit();
        }

        private void kitapbagis1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapverme1.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fatura1.Visible = true;
            fatura1.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fatura1.Visible = true;
            fatura1.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kitapbagis1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kitapverme1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kitapalma1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
