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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_bilgiler1.BringToFront();
        }

        private void admin_bilgiler1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicislemleri1.BringToFront();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            admin_bilgiler1.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            kullanicislemleri1.BringToFront();
        }
       

        private void kullanicislemleri1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kitapekle ke = new kitapekle();
            ke.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            kitaplisteleveguncelle kg = new kitaplisteleveguncelle();
            kg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitaphareketleri1.BringToFront();
        }

        private void kitaphareketleri1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kitaphareketleri1.BringToFront();
        }
    }
}
