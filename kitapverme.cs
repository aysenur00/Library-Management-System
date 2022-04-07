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
    public partial class kitapverme : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        public kitapverme()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void kitapverme_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public void fill_grid(string kullaniciadi)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitaphareketleri where kullaniciadi='"+kullaniciadi.ToString()+ "' AND (veristarihi='' or veristarihi is null) ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void kullaniciara_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            fill_grid(gir_txt.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel6.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitaphareketleri where id="+i+" ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbl_kitapaddoldur.Text = dr["kitapadi"].ToString();
                lbl_kitapalımtdoldur.Text= dr["alistarihi"].ToString();
            }
        }

        private void kitapteslim_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            DateTime alis, veris;
            SqlCommand verioku = new SqlCommand("select alistarihi from kitaphareketleri where id = '" + i.ToString() + "'", con);
            verioku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = verioku.ExecuteReader();
            double tutar;

            while (oku.Read())
            {

                alis = Convert.ToDateTime(oku["alistarihi"].ToString());
                veris = Convert.ToDateTime(dateTimePicker1.Text);
                TimeSpan fark = veris - alis;
                double gunFarki = fark.TotalDays;
                if (gunFarki > 30)
                {
                    string k = dataGridView1.SelectedCells[3].Value.ToString();
                    tutar = (gunFarki - 30) * 1;
                    MessageBox.Show("Fatura tutarı: " + tutar + " TL");
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update kullanici set faturaTutari='" + tutar + "'+ faturaTutari where kullaniciadi = '" + k + "' ";
                    cmd2.ExecuteNonQuery();
                }

            }

            oku.Close();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update kitaphareketleri set veristarihi ='" + dateTimePicker1.Value.ToShortDateString() + "' where id=" + i + " ";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update kitap_info set mevcut_kitapadeti=mevcut_kitapadeti+1 where kitap_adi='" + lbl_kitapaddoldur.Text + "' ";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Kitap teslimi başarılı");

            panel6.Visible = true;
            fill_grid(gir_txt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gir_txt.Clear();
        }
    }
}
