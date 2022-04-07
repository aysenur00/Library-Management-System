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
    public partial class sifreyenileme : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        public sifreyenileme()
        {
            InitializeComponent();
        }
        
        public void sifreyenileme_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            //textBox1.Text = ds.Tables[0].Rows[0][3].ToString();
           
            
            
          
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Girdiğiniz Şifreler Eşleşmiyor.Lütfen Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox3.Clear();

                }
                else
                {
                    string yenisifre = textBox2.Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update kullanici set sifre=@textbox2 where kullaniciadi=@textbox1", con);
                    cmd.Parameters.AddWithValue("@textbox2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@textbox1", textBox1.Text);
                    MessageBox.Show("Şifreniz değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Boş alanları lütfen doldurunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
