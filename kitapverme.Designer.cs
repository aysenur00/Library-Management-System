
namespace Kütüphane
{
    partial class kitapverme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapverme));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_kitapaddoldur = new System.Windows.Forms.Label();
            this.lbl_kitapalımtdoldur = new System.Windows.Forms.Label();
            this.lbl_kitapad = new System.Windows.Forms.Label();
            this.lbl_kitapalımt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_teslim = new System.Windows.Forms.Label();
            this.kitapteslim = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gir_txt = new System.Windows.Forms.TextBox();
            this.kullaniciara = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(415, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(-104, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1237, 411);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_kitapaddoldur);
            this.panel6.Controls.Add(this.lbl_kitapalımtdoldur);
            this.panel6.Controls.Add(this.lbl_kitapad);
            this.panel6.Controls.Add(this.lbl_kitapalımt);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.lbl_teslim);
            this.panel6.Controls.Add(this.kitapteslim);
            this.panel6.Location = new System.Drawing.Point(127, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1078, 134);
            this.panel6.TabIndex = 14;
            this.panel6.Visible = false;
            // 
            // lbl_kitapaddoldur
            // 
            this.lbl_kitapaddoldur.AutoSize = true;
            this.lbl_kitapaddoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapaddoldur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_kitapaddoldur.Location = new System.Drawing.Point(127, 24);
            this.lbl_kitapaddoldur.Name = "lbl_kitapaddoldur";
            this.lbl_kitapaddoldur.Size = new System.Drawing.Size(0, 20);
            this.lbl_kitapaddoldur.TabIndex = 16;
            // 
            // lbl_kitapalımtdoldur
            // 
            this.lbl_kitapalımtdoldur.AutoSize = true;
            this.lbl_kitapalımtdoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapalımtdoldur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_kitapalımtdoldur.Location = new System.Drawing.Point(533, 24);
            this.lbl_kitapalımtdoldur.Name = "lbl_kitapalımtdoldur";
            this.lbl_kitapalımtdoldur.Size = new System.Drawing.Size(0, 20);
            this.lbl_kitapalımtdoldur.TabIndex = 15;
            // 
            // lbl_kitapad
            // 
            this.lbl_kitapad.AutoSize = true;
            this.lbl_kitapad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_kitapad.Location = new System.Drawing.Point(19, 22);
            this.lbl_kitapad.Name = "lbl_kitapad";
            this.lbl_kitapad.Size = new System.Drawing.Size(102, 24);
            this.lbl_kitapad.TabIndex = 13;
            this.lbl_kitapad.Text = "Kitap adı :";
            // 
            // lbl_kitapalımt
            // 
            this.lbl_kitapalımt.AutoSize = true;
            this.lbl_kitapalımt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapalımt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_kitapalımt.Location = new System.Drawing.Point(364, 22);
            this.lbl_kitapalımt.Name = "lbl_kitapalımt";
            this.lbl_kitapalımt.Size = new System.Drawing.Size(163, 24);
            this.lbl_kitapalımt.TabIndex = 2;
            this.lbl_kitapalımt.Text = "Kitap alım tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(836, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 10, 18, 46, 52, 0);
            // 
            // lbl_teslim
            // 
            this.lbl_teslim.AutoSize = true;
            this.lbl_teslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_teslim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_teslim.Location = new System.Drawing.Point(671, 22);
            this.lbl_teslim.Name = "lbl_teslim";
            this.lbl_teslim.Size = new System.Drawing.Size(143, 24);
            this.lbl_teslim.TabIndex = 4;
            this.lbl_teslim.Text = "Teslim Tarihi :";
            // 
            // kitapteslim
            // 
            this.kitapteslim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kitapteslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapteslim.Location = new System.Drawing.Point(910, 67);
            this.kitapteslim.Name = "kitapteslim";
            this.kitapteslim.Size = new System.Drawing.Size(123, 52);
            this.kitapteslim.TabIndex = 9;
            this.kitapteslim.Text = "Kitabı Teslim Et";
            this.kitapteslim.UseVisualStyleBackColor = false;
            this.kitapteslim.Click += new System.EventHandler(this.kitapteslim_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Location = new System.Drawing.Point(127, 18);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1078, 222);
            this.panel8.TabIndex = 12;
            this.panel8.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(597, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap İade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı Giriniz :";
            // 
            // gir_txt
            // 
            this.gir_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gir_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gir_txt.Location = new System.Drawing.Point(527, 29);
            this.gir_txt.Name = "gir_txt";
            this.gir_txt.Size = new System.Drawing.Size(197, 15);
            this.gir_txt.TabIndex = 1;
            // 
            // kullaniciara
            // 
            this.kullaniciara.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kullaniciara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciara.Location = new System.Drawing.Point(783, 27);
            this.kullaniciara.Name = "kullaniciara";
            this.kullaniciara.Size = new System.Drawing.Size(99, 39);
            this.kullaniciara.TabIndex = 2;
            this.kullaniciara.Text = "Ara";
            this.kullaniciara.UseVisualStyleBackColor = false;
            this.kullaniciara.Click += new System.EventHandler(this.kullaniciara_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(527, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 1);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(903, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.kullaniciara);
            this.panel2.Controls.Add(this.gir_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-96, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 85);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1133, 116);
            this.panel5.TabIndex = 12;
            // 
            // kitapverme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "kitapverme";
            this.Size = new System.Drawing.Size(1133, 602);
            this.Load += new System.EventHandler(this.kitapverme_Load);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button kitapteslim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_teslim;
        private System.Windows.Forms.Label lbl_kitapalımt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_kitapad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gir_txt;
        private System.Windows.Forms.Button kullaniciara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_kitapaddoldur;
        private System.Windows.Forms.Label lbl_kitapalımtdoldur;
    }
}
