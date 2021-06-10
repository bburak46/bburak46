namespace ilk_giris_ekranı
{
    partial class From1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1_kullanıcıadı = new System.Windows.Forms.Label();
            this.label1_sifre = new System.Windows.Forms.Label();
            this.textBox1_sifregiris = new System.Windows.Forms.TextBox();
            this.textBox2_kullanıcıadıgiris = new System.Windows.Forms.TextBox();
            this.button1_sifreonay = new System.Windows.Forms.Button();
            this.dateTimePicker1_tarih = new System.Windows.Forms.DateTimePicker();
            this.label1_uyarısıfre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(33, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 77);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1_kullanıcıadı
            // 
            this.label1_kullanıcıadı.AutoSize = true;
            this.label1_kullanıcıadı.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_kullanıcıadı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1_kullanıcıadı.Location = new System.Drawing.Point(309, 240);
            this.label1_kullanıcıadı.Name = "label1_kullanıcıadı";
            this.label1_kullanıcıadı.Size = new System.Drawing.Size(112, 19);
            this.label1_kullanıcıadı.TabIndex = 2;
            this.label1_kullanıcıadı.Text = "KULLANICI ADI ";
            // 
            // label1_sifre
            // 
            this.label1_sifre.AutoSize = true;
            this.label1_sifre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_sifre.Location = new System.Drawing.Point(309, 275);
            this.label1_sifre.Name = "label1_sifre";
            this.label1_sifre.Size = new System.Drawing.Size(44, 19);
            this.label1_sifre.TabIndex = 3;
            this.label1_sifre.Text = "ŞİFRE";
            // 
            // textBox1_sifregiris
            // 
            this.textBox1_sifregiris.Location = new System.Drawing.Point(443, 272);
            this.textBox1_sifregiris.MaxLength = 32;
            this.textBox1_sifregiris.Name = "textBox1_sifregiris";
            this.textBox1_sifregiris.Size = new System.Drawing.Size(151, 25);
            this.textBox1_sifregiris.TabIndex = 2;
            this.textBox1_sifregiris.UseSystemPasswordChar = true;
            this.textBox1_sifregiris.TextChanged += new System.EventHandler(this.textBox1_sifregiris_TextChanged);
            // 
            // textBox2_kullanıcıadıgiris
            // 
            this.textBox2_kullanıcıadıgiris.Location = new System.Drawing.Point(443, 237);
            this.textBox2_kullanıcıadıgiris.MaxLength = 32;
            this.textBox2_kullanıcıadıgiris.Name = "textBox2_kullanıcıadıgiris";
            this.textBox2_kullanıcıadıgiris.Size = new System.Drawing.Size(151, 25);
            this.textBox2_kullanıcıadıgiris.TabIndex = 1;
            this.textBox2_kullanıcıadıgiris.TextChanged += new System.EventHandler(this.textBox2_kullanıcıadıgiris_TextChanged);
            // 
            // button1_sifreonay
            // 
            this.button1_sifreonay.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_sifreonay.Location = new System.Drawing.Point(443, 323);
            this.button1_sifreonay.Name = "button1_sifreonay";
            this.button1_sifreonay.Size = new System.Drawing.Size(151, 30);
            this.button1_sifreonay.TabIndex = 3;
            this.button1_sifreonay.Tag = "";
            this.button1_sifreonay.Text = "GİRİŞ";
            this.button1_sifreonay.UseVisualStyleBackColor = true;
            this.button1_sifreonay.Click += new System.EventHandler(this.button1_sifreonay_Click);
            // 
            // dateTimePicker1_tarih
            // 
            this.dateTimePicker1_tarih.Enabled = false;
            this.dateTimePicker1_tarih.Location = new System.Drawing.Point(324, 372);
            this.dateTimePicker1_tarih.Name = "dateTimePicker1_tarih";
            this.dateTimePicker1_tarih.Size = new System.Drawing.Size(219, 25);
            this.dateTimePicker1_tarih.TabIndex = 5;
            this.dateTimePicker1_tarih.Visible = false;
            // 
            // label1_uyarısıfre
            // 
            this.label1_uyarısıfre.ForeColor = System.Drawing.Color.DarkRed;
            this.label1_uyarısıfre.Location = new System.Drawing.Point(320, 303);
            this.label1_uyarısıfre.Name = "label1_uyarısıfre";
            this.label1_uyarısıfre.Size = new System.Drawing.Size(274, 17);
            this.label1_uyarısıfre.TabIndex = 6;
            this.label1_uyarısıfre.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "@MRYAZILIM";
            // 
            // From1
            // 
            this.AcceptButton = this.button1_sifreonay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_uyarısıfre);
            this.Controls.Add(this.dateTimePicker1_tarih);
            this.Controls.Add(this.button1_sifreonay);
            this.Controls.Add(this.textBox2_kullanıcıadıgiris);
            this.Controls.Add(this.textBox1_sifregiris);
            this.Controls.Add(this.label1_sifre);
            this.Controls.Add(this.label1_kullanıcıadı);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 483);
            this.Name = "From1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENERJİ MOTOR";
            this.Load += new System.EventHandler(this.From1_Load);
            this.Click += new System.EventHandler(this.From1_Click);
            this.Leave += new System.EventHandler(this.From1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1_kullanıcıadı;
        private System.Windows.Forms.Label label1_sifre;
        private System.Windows.Forms.TextBox textBox1_sifregiris;
        private System.Windows.Forms.TextBox textBox2_kullanıcıadıgiris;
        private System.Windows.Forms.Button button1_sifreonay;
        private System.Windows.Forms.Label label1_uyarısıfre;
        public System.Windows.Forms.DateTimePicker dateTimePicker1_tarih;
        private System.Windows.Forms.Label label1;
    }
}

