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
    public partial class kitapalma : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        
        public kitapalma()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kitapalma_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gir_txt.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici where kullaniciadi='"+gir_txt.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Kullanıcı adı bulunamadı");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    isim_txt.Text = dr["isim"].ToString();
                    soyisim_txt.Text = dr["soyisim"].ToString();
                    kullaniciadi_txt.Text = dr["kullaniciadi"].ToString();
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            isim_txt.Clear();
            soyisim_txt.Clear();
            kullaniciadi_txt.Clear();
            kitapadi_txt.Clear();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode!= Keys.Enter)
            {
                listBox1.Items.Clear();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kitap_info where kitap_adi like('"+kitapadi_txt.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count>0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["kitap_adi"]);
                    }
                }

            }
        }

        private void kitapadi_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                kitapadi_txt.Text =listBox1.SelectedItem.ToString();
                listBox1.Visible = false;    
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            kitapadi_txt.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible= false;
        }

        private void kitapal_Click(object sender, EventArgs e)
        {
            int kitapadet=0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from kitap_info where kitap_adi='"+kitapadi_txt.Text+"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2= new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                kitapadet = Convert.ToInt32(dr2["mevcut_kitapadeti"].ToString());
            }
            if (kitapadet>0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kitaphareketleri values('" + isim_txt.Text + "','" + soyisim_txt.Text + "','" + kullaniciadi_txt.Text + "','" + kitapadi_txt.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "', '')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update kitap_info set mevcut_kitapadeti=mevcut_kitapadeti-1 where kitap_adi='" + kitapadi_txt.Text + "' ";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Kitap verildi");

            }
            else
            {
                MessageBox.Show("Kitap mevcut değil.");
            }

            
        }
    }
}
