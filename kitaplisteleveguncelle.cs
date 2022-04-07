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
    public partial class kitaplisteleveguncelle : Form
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);

        public kitaplisteleveguncelle()
        {
            InitializeComponent();
        }
       
        DataSet dataSet = new DataSet();

        private void kitaplistele()
        {
            //con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from kitap_info", con);
            adapter.Fill(dataSet, "kitap_info");
            dataGridView1.DataSource = dataSet.Tables["kitap_info"];
            con.Close();
        }
        private void kitaplisteleveguncelle_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }
        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kitabı silmek mi istiyorsunuz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from kitap_info where barkodno=@barkodno", con);
                cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kitap silme işleminiz başarıyla gerçekleşmiştir.");
                dataSet.Tables["kitap_info"].Clear();
                kitaplistele();
                foreach(Control item in Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["kitap_info"].Clear();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from kitap_info where barkodno like '%" + textBox1.Text + "%'", con);
            adapter.Fill(dataSet, "kitap_info");
            dataGridView1.DataSource = dataSet.Tables["kitap_info"];
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void barkodno_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from kitap_info where barkodno like '" +barkodno.Text+ "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                kitapadi.Text = read["kitap_adi"].ToString();
                kitapyazari.Text = read["kitap_yazari"].ToString();
                yayinevi.Text = read["kitap_yayinevi"].ToString();
                basimyili.Text = read["kitap_basimyili"].ToString();
                sayfasayisi.Text = read["sayfasayisi"].ToString();
                turu.Text = read["turu"].ToString();
                rafno.Text = read["rafno"].ToString();
                stoksayisi.Text = read["kitap_adeti"].ToString();
                mevcutkitapadeti.Text = read["mevcut_kitapadeti"].ToString();
                aciklama.Text = read["aciklama"].ToString();

            }
            con.Close(); 

           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update kitap_info set kitap_adi=@kitapadi,kitap_yazari=@kitapyazari,kitap_yayinevi=@yayinevi,sayfasayisi=@sayfasayisi, kitap_basimyili=@basimyili,turu=@turu,rafno=@rafno,kitap_adeti=@stoksayisi,mevcut_kitapadeti=@mevcutkitapadeti,aciklama=@aciklama where barkodno=@barkodno", con);
            if (Convert.ToInt32(mevcutkitapadeti.Text) < Convert.ToInt32(stoksayisi.Text) || mevcutkitapadeti.Text == stoksayisi.Text)
            {
                cmd.Parameters.AddWithValue("@barkodno", barkodno.Text);
                cmd.Parameters.AddWithValue("@kitapadi", kitapadi.Text);
                cmd.Parameters.AddWithValue("@kitapyazari", kitapyazari.Text);
                cmd.Parameters.AddWithValue("@yayinevi", yayinevi.Text);
                cmd.Parameters.AddWithValue("@basimyili", basimyili.Text);
                cmd.Parameters.AddWithValue("@sayfasayisi", sayfasayisi.Text);
                cmd.Parameters.AddWithValue("@turu", turu.Text);
                cmd.Parameters.AddWithValue("@rafno", rafno.Text);
                cmd.Parameters.AddWithValue("@aciklama", aciklama.Text);
                cmd.Parameters.AddWithValue("@stoksayisi", stoksayisi.Text);
                cmd.Parameters.AddWithValue("@mevcutkitapadeti", mevcutkitapadeti.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kitap güncelleme işleminiz başarıyla gerçekleşmiştir.");
                dataSet.Tables["kitap_info"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
                MessageBox.Show("Mevcut kitap adeti kitap adetinden büyük girilemez!");

            
            con.Close();
            



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodno.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kitapadi.Text = dataGridView1.CurrentRow.Cells["kitap_adi"].Value.ToString();
            kitapyazari.Text = dataGridView1.CurrentRow.Cells["kitap_yazari"].Value.ToString();
            yayinevi.Text = dataGridView1.CurrentRow.Cells["kitap_yayinevi"].Value.ToString();
            basimyili.Text = dataGridView1.CurrentRow.Cells["kitap_basimyili"].Value.ToString();
            sayfasayisi.Text = dataGridView1.CurrentRow.Cells["sayfasayisi"].Value.ToString();
            turu.Text = dataGridView1.CurrentRow.Cells["turu"].Value.ToString();
            rafno.Text = dataGridView1.CurrentRow.Cells["rafno"].Value.ToString();
            stoksayisi.Text = dataGridView1.CurrentRow.Cells["kitap_adeti"].Value.ToString();
            mevcutkitapadeti.Text = dataGridView1.CurrentRow.Cells["mevcut_kitapadeti"].Value.ToString();
            aciklama.Text = dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
        }
    }
}
