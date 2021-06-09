namespace ilk_giris_ekranı
{
    partial class caridüzenlesil
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmakoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiliadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ünvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verginoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karttipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilcesemtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topborcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bildirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyarı_metni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredikarti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet64 = new ilk_giris_ekranı.carilerDataSet64();
            this.cariTableAdapter = new ilk_giris_ekranı.carilerDataSet64TableAdapters.cariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet64)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(646, 628);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARA";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "CARİ SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaadiDataGridViewTextBoxColumn,
            this.firmakoduDataGridViewTextBoxColumn,
            this.yetkiliadiDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.ünvanDataGridViewTextBoxColumn,
            this.verginoDataGridViewTextBoxColumn,
            this.karttipiDataGridViewTextBoxColumn,
            this.fatadresDataGridViewTextBoxColumn,
            this.ilcesemtDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.gsmDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.faksDataGridViewTextBoxColumn,
            this.topborcDataGridViewTextBoxColumn,
            this.pesin,
            this.bildirim,
            this.uyarı_metni,
            this.kredikarti});
            this.dataGridView1.DataSource = this.cariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 588);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // firmaadiDataGridViewTextBoxColumn
            // 
            this.firmaadiDataGridViewTextBoxColumn.DataPropertyName = "firma_adi";
            this.firmaadiDataGridViewTextBoxColumn.HeaderText = "FİRMA ADI";
            this.firmaadiDataGridViewTextBoxColumn.Name = "firmaadiDataGridViewTextBoxColumn";
            this.firmaadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmakoduDataGridViewTextBoxColumn
            // 
            this.firmakoduDataGridViewTextBoxColumn.DataPropertyName = "firma_kodu";
            this.firmakoduDataGridViewTextBoxColumn.HeaderText = "FİRMA KODU";
            this.firmakoduDataGridViewTextBoxColumn.Name = "firmakoduDataGridViewTextBoxColumn";
            this.firmakoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yetkiliadiDataGridViewTextBoxColumn
            // 
            this.yetkiliadiDataGridViewTextBoxColumn.DataPropertyName = "yetkili_adi";
            this.yetkiliadiDataGridViewTextBoxColumn.HeaderText = "YETKİLİ ADI";
            this.yetkiliadiDataGridViewTextBoxColumn.Name = "yetkiliadiDataGridViewTextBoxColumn";
            this.yetkiliadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tc_kimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            this.tckimlikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "DURUM";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ünvanDataGridViewTextBoxColumn
            // 
            this.ünvanDataGridViewTextBoxColumn.DataPropertyName = "ünvan";
            this.ünvanDataGridViewTextBoxColumn.HeaderText = "ÜNVAN";
            this.ünvanDataGridViewTextBoxColumn.Name = "ünvanDataGridViewTextBoxColumn";
            this.ünvanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verginoDataGridViewTextBoxColumn
            // 
            this.verginoDataGridViewTextBoxColumn.DataPropertyName = "vergi_no";
            this.verginoDataGridViewTextBoxColumn.HeaderText = "VERGİ NO ";
            this.verginoDataGridViewTextBoxColumn.Name = "verginoDataGridViewTextBoxColumn";
            this.verginoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // karttipiDataGridViewTextBoxColumn
            // 
            this.karttipiDataGridViewTextBoxColumn.DataPropertyName = "kart_tipi";
            this.karttipiDataGridViewTextBoxColumn.HeaderText = "KART TİPİ";
            this.karttipiDataGridViewTextBoxColumn.Name = "karttipiDataGridViewTextBoxColumn";
            this.karttipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatadresDataGridViewTextBoxColumn
            // 
            this.fatadresDataGridViewTextBoxColumn.DataPropertyName = "fat_adres";
            this.fatadresDataGridViewTextBoxColumn.HeaderText = "FATURA ADRESİ";
            this.fatadresDataGridViewTextBoxColumn.Name = "fatadresDataGridViewTextBoxColumn";
            this.fatadresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilcesemtDataGridViewTextBoxColumn
            // 
            this.ilcesemtDataGridViewTextBoxColumn.DataPropertyName = "ilce_semt";
            this.ilcesemtDataGridViewTextBoxColumn.HeaderText = "SEMT/İLÇE";
            this.ilcesemtDataGridViewTextBoxColumn.Name = "ilcesemtDataGridViewTextBoxColumn";
            this.ilcesemtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "ŞEHİR";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "tel_no";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "TEL NO";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            this.telnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gsmDataGridViewTextBoxColumn
            // 
            this.gsmDataGridViewTextBoxColumn.DataPropertyName = "gsm";
            this.gsmDataGridViewTextBoxColumn.HeaderText = "GSM";
            this.gsmDataGridViewTextBoxColumn.Name = "gsmDataGridViewTextBoxColumn";
            this.gsmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-MAİL";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faksDataGridViewTextBoxColumn
            // 
            this.faksDataGridViewTextBoxColumn.DataPropertyName = "faks";
            this.faksDataGridViewTextBoxColumn.HeaderText = "FAKS";
            this.faksDataGridViewTextBoxColumn.Name = "faksDataGridViewTextBoxColumn";
            this.faksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topborcDataGridViewTextBoxColumn
            // 
            this.topborcDataGridViewTextBoxColumn.DataPropertyName = "top_borc";
            this.topborcDataGridViewTextBoxColumn.HeaderText = "TOPLAM BORÇ";
            this.topborcDataGridViewTextBoxColumn.Name = "topborcDataGridViewTextBoxColumn";
            this.topborcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesin
            // 
            this.pesin.DataPropertyName = "pesin";
            this.pesin.HeaderText = "PEŞİN ÖDEME";
            this.pesin.Name = "pesin";
            this.pesin.ReadOnly = true;
            // 
            // bildirim
            // 
            this.bildirim.DataPropertyName = "bildirim";
            this.bildirim.HeaderText = "BİLDİRİM";
            this.bildirim.Name = "bildirim";
            this.bildirim.ReadOnly = true;
            // 
            // uyarı_metni
            // 
            this.uyarı_metni.DataPropertyName = "uyarı_metni";
            this.uyarı_metni.HeaderText = "UYARI METNİ";
            this.uyarı_metni.Name = "uyarı_metni";
            this.uyarı_metni.ReadOnly = true;
            // 
            // kredikarti
            // 
            this.kredikarti.DataPropertyName = "kredikarti";
            this.kredikarti.HeaderText = "KREDİ KARTI ÖDEME";
            this.kredikarti.Name = "kredikarti";
            this.kredikarti.ReadOnly = true;
            // 
            // cariBindingSource
            // 
            this.cariBindingSource.DataMember = "cari";
            this.cariBindingSource.DataSource = this.carilerDataSet64;
            // 
            // carilerDataSet64
            // 
            this.carilerDataSet64.DataSetName = "carilerDataSet64";
            this.carilerDataSet64.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cariTableAdapter
            // 
            this.cariTableAdapter.ClearBeforeFill = true;
            // 
            // caridüzenlesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1429, 729);
            this.Name = "caridüzenlesil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.boş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet64)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private carilerDataSet64 carilerDataSet64;
        private System.Windows.Forms.BindingSource cariBindingSource;
        private carilerDataSet64TableAdapters.cariTableAdapter cariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmakoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiliadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ünvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verginoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karttipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilcesemtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topborcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesin;
        private System.Windows.Forms.DataGridViewTextBoxColumn bildirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyarı_metni;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredikarti;
    }
}