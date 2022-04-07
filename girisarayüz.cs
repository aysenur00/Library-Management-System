using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane
{
    public partial class girisarayüz :Form
    {

        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        
        int count = 0;
        public girisarayüz()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_baslik(object sender, EventArgs e)
        {

        }

         public void giris_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici where kullaniciadi='" + kullaniciadi.Text + "' and sifre='" + sifre.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            
             if (kullaniciadi.Text== "admin" || sifre.Text == "admin")
            {
                this.Hide();
                user admin = new user();
                admin.Show();
            }
            else if (count == 0)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                içarayüz ia = new içarayüz();
                ia.Show();
            }
           
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayıt ka = new kayıt();
            ka.Show();

           
        }
        private void girisarayüz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void kullaniciadi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sifreyenileme1.BringToFront();
        }

        private void sifreyenileme1_Load(object sender, EventArgs e)
        {

        }
    }
}
