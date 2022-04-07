
namespace Kütüphane
{
    partial class kitaplisteleveguncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitaplisteleveguncelle));
            this.label9 = new System.Windows.Forms.Label();
            this.sayfasayisi = new System.Windows.Forms.TextBox();
            this.turu = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stoksayisi = new System.Windows.Forms.TextBox();
            this.rafno = new System.Windows.Forms.TextBox();
            this.yayinevi = new System.Windows.Forms.TextBox();
            this.kitapyazari = new System.Windows.Forms.TextBox();
            this.kitapadi = new System.Windows.Forms.TextBox();
            this.barkodno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mevcutkitapadeti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.basimyili = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(70, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Basım yılı";
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.Location = new System.Drawing.Point(212, 249);
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Size = new System.Drawing.Size(156, 22);
            this.sayfasayisi.TabIndex = 7;
            // 
            // turu
            // 
            this.turu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.turu.FormattingEnabled = true;
            this.turu.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Deneme",
            "İnceleme",
            "Araştırma",
            "Tarih",
            "Felsefe",
            "Mitoloji",
            "Bilim Kurgu",
            "Fantastik",
            "Macera",
            "Çocuk Kitapları"});
            this.turu.Location = new System.Drawing.Point(211, 295);
            this.turu.Name = "turu";
            this.turu.Size = new System.Drawing.Size(157, 24);
            this.turu.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(437, 454);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(140, 31);
            this.guncelle.TabIndex = 13;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(49, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kitap Açıklaması";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(70, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kitap Adeti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Raf No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitap Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kitap Barkod No";
            // 
            // stoksayisi
            // 
            this.stoksayisi.Location = new System.Drawing.Point(211, 383);
            this.stoksayisi.Name = "stoksayisi";
            this.stoksayisi.Size = new System.Drawing.Size(157, 22);
            this.stoksayisi.TabIndex = 10;
            // 
            // rafno
            // 
            this.rafno.Location = new System.Drawing.Point(211, 343);
            this.rafno.Name = "rafno";
            this.rafno.Size = new System.Drawing.Size(157, 22);
            this.rafno.TabIndex = 9;
            // 
            // yayinevi
            // 
            this.yayinevi.Location = new System.Drawing.Point(209, 162);
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Size = new System.Drawing.Size(157, 22);
            this.yayinevi.TabIndex = 5;
            // 
            // kitapyazari
            // 
            this.kitapyazari.Location = new System.Drawing.Point(209, 117);
            this.kitapyazari.Name = "kitapyazari";
            this.kitapyazari.Size = new System.Drawing.Size(157, 22);
            this.kitapyazari.TabIndex = 4;
            // 
            // kitapadi
            // 
            this.kitapadi.Location = new System.Drawing.Point(209, 74);
            this.kitapadi.Name = "kitapadi";
            this.kitapadi.Size = new System.Drawing.Size(157, 22);
            this.kitapadi.TabIndex = 3;
            // 
            // barkodno
            // 
            this.barkodno.Location = new System.Drawing.Point(209, 28);
            this.barkodno.Name = "barkodno";
            this.barkodno.Size = new System.Drawing.Size(157, 22);
            this.barkodno.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 328);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(598, 454);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(140, 31);
            this.sil.TabIndex = 14;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(492, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Kitap Barkod No Ara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(211, 487);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(155, 22);
            this.aciklama.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Mevcut Kitap Adeti";
            // 
            // mevcutkitapadeti
            // 
            this.mevcutkitapadeti.Location = new System.Drawing.Point(211, 436);
            this.mevcutkitapadeti.Name = "mevcutkitapadeti";
            this.mevcutkitapadeti.Size = new System.Drawing.Size(157, 22);
            this.mevcutkitapadeti.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(61, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Sayfa Sayısı";
            // 
            // basimyili
            // 
            this.basimyili.Location = new System.Drawing.Point(209, 203);
            this.basimyili.Name = "basimyili";
            this.basimyili.Size = new System.Drawing.Size(156, 22);
            this.basimyili.TabIndex = 6;
            // 
            // kitaplisteleveguncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 540);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.basimyili);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mevcutkitapadeti);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sayfasayisi);
            this.Controls.Add(this.turu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoksayisi);
            this.Controls.Add(this.rafno);
            this.Controls.Add(this.yayinevi);
            this.Controls.Add(this.kitapyazari);
            this.Controls.Add(this.kitapadi);
            this.Controls.Add(this.barkodno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kitaplisteleveguncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listele ve Güncelle";
            this.Load += new System.EventHandler(this.kitaplisteleveguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sayfasayisi;
        private System.Windows.Forms.ComboBox turu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stoksayisi;
        private System.Windows.Forms.TextBox rafno;
        private System.Windows.Forms.TextBox yayinevi;
        private System.Windows.Forms.TextBox kitapyazari;
        private System.Windows.Forms.TextBox kitapadi;
        private System.Windows.Forms.TextBox barkodno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mevcutkitapadeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox basimyili;
    }
}