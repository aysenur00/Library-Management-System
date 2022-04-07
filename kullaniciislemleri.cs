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
    public partial class kullanicislemleri : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);

        public kullanicislemleri()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kullanicislemleri_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciaditxt.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici where Id=" + i + " ";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                isim.Text = dr["isim"].ToString();
                soyisim.Text = dr["soyisim"].ToString();
                kullaniciadi.Text = dr["kullaniciadi"].ToString();
                sifre.Text = dr["sifre"].ToString();
                email.Text = dr["email"].ToString();
                fatura.Text = dr["faturaTutari"].ToString();
            }
        }
        public void fill_grid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanici ";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            isim.Clear();
            soyisim.Clear();
            kullaniciadi.Clear();
            sifre.Clear();
            email.Clear();
            fatura.Clear();
        }
        private void kullaniciaditxt_TextChanged(object sender, EventArgs e)
        {
            if (kullaniciaditxt.Text != "")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kullanici where kullaniciadi LIKE '" + kullaniciaditxt.Text + "%'";
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
                cmd.CommandText = "select * from kullanici";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (isim.Text == "" && soyisim.Text == "" && kullaniciadi.Text == "" && sifre.Text == "" && email.Text == "" && fatura.Text == "")
            {
                MessageBox.Show("Lütfen tablodan güncellenecek bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Güncelleme kaydedilecek. Onaylıyor musunuz?", "Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int i;
                    i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                    string yeniad = isim.Text;
                    string yenisoyad = soyisim.Text;
                    string yenikad = kullaniciadi.Text;
                    string yenisifre = sifre.Text;
                    string yenimail = email.Text;
                    string yenifatura = fatura.Text;


                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update kullanici set isim= '" + yeniad + "', soyisim='" + yenisoyad + "', kullaniciadi= '" + yenikad + "', sifre='" + yenisifre + "',email='" + yenimail + "',faturaTutari='" + yenifatura + "' where Id=" + i + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    fill_grid();

                    isim.Clear();
                    soyisim.Clear();
                    kullaniciadi.Clear();
                    sifre.Clear();
                    email.Clear();
                    fatura.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isim.Text == "" && soyisim.Text == "" && kullaniciadi.Text == "" && sifre.Text == "" && email.Text == "" && fatura.Text == "")
            {
                MessageBox.Show("Lütfen tablodan silinecek bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                if (MessageBox.Show("Veri silinecek.Onaylıyor musunuz?", "Sil.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int i;
                    i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " delete from kullanici where Id =" + i + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    fill_grid();

                    isim.Clear();
                    soyisim.Clear();
                    kullaniciadi.Clear();
                    sifre.Clear();
                    email.Clear();
                    fatura.Clear();
                }
            }
        }

    }
}
