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
    public partial class fatura : UserControl
    {
        SqlConnection con = new SqlConnection(kitap_bilgiler.path);
        public fatura()
        {
            InitializeComponent();
        }

        private void btn_onizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
                Font font = new Font("Arial", 10);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"Tarih: {DateTime.Now.ToString("dd.MM.yyyy")}", font, firca, 60, 25);
                font = new Font("Arial", 17, FontStyle.Bold);

                e.Graphics.DrawString("FATURA", font, firca, 352, 70);

                font = new Font("Arial", 15);
                e.Graphics.DrawString("---------------", font, firca, 350, 90);

                font = new Font("Arial", 10, FontStyle.Bold);

                e.Graphics.DrawString("İsim", font, firca, 60, 170);
                e.Graphics.DrawString("Soy İsim", font, firca, 195, 170);
                e.Graphics.DrawString("Kullanıcı Adı", font, firca, 330, 170);
                e.Graphics.DrawString("E-Mail", font, firca, 465, 170);
                e.Graphics.DrawString("Tutar(TL)", font, firca, 680, 170);

                e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------", font, firca, 60, 190);

                int i = 0;
                int y = 210;
                while (i <= dataGridView1.Rows.Count-1 )
                {
                    font = new Font("Arial", 10);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 195, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 330, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 465, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 680, y);

                    y += 40;
                    i += 1;

                }


           
        }

        private void fatura_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void kullaniciara_Click(object sender, EventArgs e)
        {
            fill_grid(textBox1.Text);
        }

        public void fill_grid(string kullaniciadi)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isim, soyisim, kullaniciadi, email, faturaTutari from kullanici where kullaniciadi='" + kullaniciadi.ToString() + "' AND (faturaTutari !='' or faturaTutari <> null)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
