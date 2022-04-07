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
    public partial class kitap_bilgiler : UserControl
    {
        public static string path = @"Data Source=DESKTOP-G86HF1S\SQLEXPRESS;Initial Catalog=ktphane_nursena;MultipleActiveResultSets=true;Integrated Security=True";
        SqlConnection con = new SqlConnection(path);
        public kitap_bilgiler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_bilgiler_Load(object sender, EventArgs e)
        {
          
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap_info";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapaditxt.Clear();
        }
        int satırno;
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap_info";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt32(e.RowIndex);
            satırno= Convert.ToInt32(ds.Tables[0].Rows[a][0].ToString());

            
            kitap_ad.Text = ds.Tables[0].Rows[a][1].ToString();
            kitap_yazar.Text = ds.Tables[0].Rows[a][2].ToString();
            yayinevi.Text= ds.Tables[0].Rows[a][3].ToString();
            basimyili.Text = ds.Tables[0].Rows[a][4].ToString();
            adedi.Text = ds.Tables[0].Rows[a][5].ToString();
            text_madet.Text = ds.Tables[0].Rows[a][6].ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            kitap_ad.Clear();
            kitap_yazar.Clear();
            yayinevi.Clear();
            basimyili.Clear();
            adedi.Clear();
            text_madet.Clear();

        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(kitapaditxt.Text != "")
            {
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kitap_info where kitap_adi LIKE '" +kitapaditxt.Text +"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kitap_info";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (kitap_ad.Text == "" || kitap_yazar.Text == "" || yayinevi.Text == "" || basimyili.Text == "" || adedi.Text == "" || text_madet.Text == "")
            {
                MessageBox.Show("Lütfen tablodan güncellenecek bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Güncelleme kaydedilecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {


                    string yeniad = kitap_ad.Text;
                    string yeniyazar = kitap_yazar.Text;
                    string yeniyayinevi = yayinevi.Text;
                    int yeniyil = Convert.ToInt32(basimyili.Text);
                    int yeniadet = Convert.ToInt32(adedi.Text);
                    int yenimevcutadet = Convert.ToInt32(text_madet.Text);

                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update kitap_info set kitap_adi= '" + yeniad + "', kitap_yazari='" + yeniyazar + "', kitap_yayinevi= '" + yeniyayinevi + "', kitap_basimyili='" + yeniyil + "',kitap_adeti='" + yeniadet + "', mevcut_kitapadeti='" + yenimevcutadet + "' where Id=" + satırno + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                }
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (kitap_ad.Text == "" || kitap_yazar.Text == "" || yayinevi.Text == "" || basimyili.Text == "" || adedi.Text == "" || text_madet.Text == "")
            {
                MessageBox.Show("Lütfen tablodan silinecek bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Veri silinecek.Onaylıyor musunuz?", "Uyarı.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {


                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " delete from kitap_info where Id =" + satırno + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                
                con.Open();
            if (kitap_ad.Text == "" || kitap_yazar.Text == "" || yayinevi.Text == "" || basimyili.Text == "" || adedi.Text == "" || text_madet.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kitap_info values('" + kitap_ad.Text + "','" + kitap_yazar.Text + "','" + yayinevi.Text + "'," + basimyili.Text + "," + adedi.Text + "," + adedi.Text + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                kitap_ad.Text = "";
                kitap_yazar.Text = "";
                yayinevi.Text = "";
                basimyili.Text = "";
                adedi.Text = "";
                text_madet.Text = "";
                MessageBox.Show("Kitap başarıyla eklenmiştir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
