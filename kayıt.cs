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
    public partial class kayıt : Form
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);

        public kayıt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void kayıt_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            try
            {
                
                if(isim.Text=="" || soyisim.Text=="" || kullaniciadi.Text=="" || sifre.Text=="" || email.Text=="" )
                {
                        MessageBox.Show("Boş alan bıraktınız! Lütfen Doldurunuz.");
                        
                    
                }
                else {
                    
                    using (SqlConnection con = new SqlConnection(kitap_bilgiler.path))
                    {
                        con.Open();

                        bool exists = false;

                        
                        using (SqlCommand cmd = new SqlCommand("select count(*) from [kullanici] where kullaniciadi = @kullaniciadi", con))
                        {
                            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }

                        
                        if (exists)
                            MessageBox.Show(kullaniciadi, "Bu kullanıcı adı kullanılıyor. Başka bir kullanıcı adı seçiniz");
                        else
                        {
                            
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO [kullanici] values ('"+isim.Text+"','"+soyisim.Text+"', '"+kullaniciadi.Text+"','"+sifre.Text+"', '"+email.Text+"', '')", con))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Kayıt oluşturuldu");
                            }
                        }

                        con.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisarayüz ga = new girisarayüz();
            ga.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
