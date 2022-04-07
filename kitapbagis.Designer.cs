
namespace Kütüphane
{
    partial class kitapbagis
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapbagis));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapadeti = new System.Windows.Forms.TextBox();
            this.basimyili = new System.Windows.Forms.TextBox();
            this.yayinevi = new System.Windows.Forms.TextBox();
            this.yazari = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sayfasayisi = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rafno = new System.Windows.Forms.TextBox();
            this.barkodno = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(662, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Bağışla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkGray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(201, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 31);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "Kitap Bağışla";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(371, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kitap Adedi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Basım Yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yayınevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kitap Adı:";
            // 
            // kitapadeti
            // 
            this.kitapadeti.BackColor = System.Drawing.Color.DarkGray;
            this.kitapadeti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitapadeti.Location = new System.Drawing.Point(507, 258);
            this.kitapadeti.Name = "kitapadeti";
            this.kitapadeti.Size = new System.Drawing.Size(100, 15);
            this.kitapadeti.TabIndex = 9;
            // 
            // basimyili
            // 
            this.basimyili.BackColor = System.Drawing.Color.DarkGray;
            this.basimyili.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.basimyili.Location = new System.Drawing.Point(212, 313);
            this.basimyili.Name = "basimyili";
            this.basimyili.Size = new System.Drawing.Size(100, 15);
            this.basimyili.TabIndex = 5;
            // 
            // yayinevi
            // 
            this.yayinevi.BackColor = System.Drawing.Color.DarkGray;
            this.yayinevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yayinevi.Location = new System.Drawing.Point(212, 260);
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Size = new System.Drawing.Size(100, 15);
            this.yayinevi.TabIndex = 4;
            // 
            // yazari
            // 
            this.yazari.BackColor = System.Drawing.Color.DarkGray;
            this.yazari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yazari.Location = new System.Drawing.Point(212, 209);
            this.yazari.Name = "yazari";
            this.yazari.Size = new System.Drawing.Size(100, 15);
            this.yazari.TabIndex = 3;
            // 
            // adi
            // 
            this.adi.BackColor = System.Drawing.Color.DarkGray;
            this.adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adi.Location = new System.Drawing.Point(212, 162);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(100, 15);
            this.adi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(212, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(212, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(212, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(212, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(507, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.sayfasayisi);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.rafno);
            this.panel6.Controls.Add(this.barkodno);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.aciklama);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.adi);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.yazari);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.yayinevi);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.basimyili);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.kitapadeti);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(22, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(797, 438);
            this.panel6.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(507, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.BackColor = System.Drawing.Color.DarkGray;
            this.sayfasayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sayfasayisi.Location = new System.Drawing.Point(507, 116);
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Size = new System.Drawing.Size(100, 15);
            this.sayfasayisi.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(507, 332);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 1);
            this.panel7.TabIndex = 44;
            // 
            // rafno
            // 
            this.rafno.BackColor = System.Drawing.Color.DarkGray;
            this.rafno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rafno.Location = new System.Drawing.Point(507, 209);
            this.rafno.Name = "rafno";
            this.rafno.Size = new System.Drawing.Size(100, 15);
            this.rafno.TabIndex = 8;
            // 
            // barkodno
            // 
            this.barkodno.BackColor = System.Drawing.Color.DarkGray;
            this.barkodno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barkodno.Location = new System.Drawing.Point(212, 116);
            this.barkodno.Name = "barkodno";
            this.barkodno.Size = new System.Drawing.Size(100, 15);
            this.barkodno.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel9.Location = new System.Drawing.Point(212, 137);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 1);
            this.panel9.TabIndex = 41;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel10.Location = new System.Drawing.Point(507, 232);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 1);
            this.panel10.TabIndex = 42;
            // 
            // aciklama
            // 
            this.aciklama.BackColor = System.Drawing.Color.DarkGray;
            this.aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aciklama.Location = new System.Drawing.Point(507, 311);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(100, 15);
            this.aciklama.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel11.Location = new System.Drawing.Point(507, 137);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 1);
            this.panel11.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(368, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(412, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Raf No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Kitap Barkod No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(327, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Kitap Açıklaması:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(431, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Türü:";
            // 
            // kitapbagis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel6);
            this.Name = "kitapbagis";
            this.Size = new System.Drawing.Size(856, 551);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapadeti;
        private System.Windows.Forms.TextBox basimyili;
        private System.Windows.Forms.TextBox yayinevi;
        private System.Windows.Forms.TextBox yazari;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox sayfasayisi;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox rafno;
        private System.Windows.Forms.TextBox barkodno;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
