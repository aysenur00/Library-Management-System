
namespace Kütüphane
{
    partial class girisarayüz
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisarayüz));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.giris_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sifreyenileme1 = new Kütüphane.sifreyenileme();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(400, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilgi Kütüphane Otomasyon Sistemine Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(950, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.kullaniciadi.BackColor = System.Drawing.SystemColors.ControlText;
            this.kullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kullaniciadi.Location = new System.Drawing.Point(954, 237);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(241, 15);
            this.kullaniciadi.TabIndex = 4;
            this.kullaniciadi.TextChanged += new System.EventHandler(this.kullaniciadi_TextChanged);
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.SystemColors.ControlText;
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sifre.Location = new System.Drawing.Point(954, 317);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(241, 15);
            this.sifre.TabIndex = 6;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(950, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // giris_button
            // 
            this.giris_button.AutoEllipsis = true;
            this.giris_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.giris_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.giris_button.Location = new System.Drawing.Point(954, 374);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(241, 37);
            this.giris_button.TabIndex = 7;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1034, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifrenizi mi Unuttunuz ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(954, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(954, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 1);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(954, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifreyenileme1
            // 
            this.sifreyenileme1.Location = new System.Drawing.Point(23, 97);
            this.sifreyenileme1.Name = "sifreyenileme1";
            this.sifreyenileme1.Size = new System.Drawing.Size(881, 473);
            this.sifreyenileme1.TabIndex = 12;
            this.sifreyenileme1.Load += new System.EventHandler(this.sifreyenileme1_Load);
            // 
            // girisarayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1375, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreyenileme1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "girisarayüz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyon Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.girisarayüz_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private sifreyenileme sifreyenileme1;
    }
}

