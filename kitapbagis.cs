using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class kitapbagis : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        

        public kitapbagis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (adi.Text == "" || yazari.Text == "" || yayinevi.Text == "" || basimyili.Text == "" || kitapadeti.Text == "" || sayfasayisi.Text == "" || rafno.Text == "" || barkodno.Text == "" || aciklama.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kitap_info(kitap_adi,kitap_yazari,kitap_yayinevi, kitap_basimyili, kitap_adeti, mevcut_kitapadeti, barkodno, turu, rafno,aciklama, sayfasayisi) values('" + adi.Text + "','" + yazari.Text + "','" + yayinevi.Text + "'," + basimyili.Text + "," + kitapadeti.Text + "," + kitapadeti.Text + ", '" + barkodno.Text + "','" + comboBox1.Text + "','" + rafno.Text + "','" + aciklama.Text + "','" + sayfasayisi.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                adi.Text = "";
                yazari.Text = "";
                yayinevi.Text = "";
                basimyili.Text = "";
                kitapadeti.Text = "";
                sayfasayisi.Text = "";
                rafno.Text = "";
                barkodno.Text ="";
                aciklama.Text = "";
                comboBox1.Text = "";

                MessageBox.Show("Kitap bağışınız başarıyla yapılmıştır.");
            }
        }
    }
}

