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
    public partial class kitapekle : Form
    { 
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        
        public kitapekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "insert into kitap_info(barkodno,kitap_adi,kitap_yazari,kitap_yayinevi,sayfasayisi,turu,rafno,kitap_adeti,aciklama, kitap_basimyili, mevcut_kitapadeti) values('" + barkodno.Text + "','" + kitapadi.Text + "','" + kitapyazari.Text + "','" + yayinevi.Text + "','" + sayfasayisi.Text + "','" + turu.Text + "','" + rafno.Text + "','" + stoksayisi.Text + "','" + aciklama.Text + "', '" + basimyili.Text + "', '" + stoksayisi.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            barkodno.Text = "";
            kitapadi.Text = "";
            kitapyazari.Text = "";
            yayinevi.Text = "";
            sayfasayisi.Text = "";
            basimyili.Text = "";
            turu.Text = "";
            rafno.Text = "";
            stoksayisi.Text = "";
            aciklama.Text = "";
            MessageBox.Show("Kitap ekleme işleminiz başarıyla yapılmıştır.");
         


        }

        
    
    }
}
