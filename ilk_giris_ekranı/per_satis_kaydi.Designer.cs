namespace ilk_giris_ekranı
{
    partial class per_satis_kaydi
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
            this.dataGridView1_per_sat_kay = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persatiskaydiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet62 = new ilk_giris_ekranı.carilerDataSet62();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.per_satis_kaydiTableAdapter = new ilk_giris_ekranı.carilerDataSet62TableAdapters.per_satis_kaydiTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_per_sat_kay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persatiskaydiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet62)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1172, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1_per_sat_kay
            // 
            this.dataGridView1_per_sat_kay.AllowUserToAddRows = false;
            this.dataGridView1_per_sat_kay.AllowUserToDeleteRows = false;
            this.dataGridView1_per_sat_kay.AllowUserToResizeRows = false;
            this.dataGridView1_per_sat_kay.AutoGenerateColumns = false;
            this.dataGridView1_per_sat_kay.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1_per_sat_kay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_per_sat_kay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.iskDataGridViewTextBoxColumn,
            this.birimfiyatDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.personel_adi});
            this.dataGridView1_per_sat_kay.DataSource = this.persatiskaydiBindingSource;
            this.dataGridView1_per_sat_kay.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1_per_sat_kay.Location = new System.Drawing.Point(17, 57);
            this.dataGridView1_per_sat_kay.Name = "dataGridView1_per_sat_kay";
            this.dataGridView1_per_sat_kay.ReadOnly = true;
            this.dataGridView1_per_sat_kay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1_per_sat_kay.RowTemplate.Height = 24;
            this.dataGridView1_per_sat_kay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_per_sat_kay.Size = new System.Drawing.Size(1285, 553);
            this.dataGridView1_per_sat_kay.TabIndex = 3;
            this.dataGridView1_per_sat_kay.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_per_sat_kay_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 5;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            this.stokkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            this.stokadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            this.birimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iskDataGridViewTextBoxColumn
            // 
            this.iskDataGridViewTextBoxColumn.DataPropertyName = "isk";
            this.iskDataGridViewTextBoxColumn.HeaderText = "isk";
            this.iskDataGridViewTextBoxColumn.Name = "iskDataGridViewTextBoxColumn";
            this.iskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimfiyatDataGridViewTextBoxColumn
            // 
            this.birimfiyatDataGridViewTextBoxColumn.DataPropertyName = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn.HeaderText = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn.Name = "birimfiyatDataGridViewTextBoxColumn";
            this.birimfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toplamtutarDataGridViewTextBoxColumn
            // 
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
            this.toplamtutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personel_adi
            // 
            this.personel_adi.DataPropertyName = "personel_adi";
            this.personel_adi.HeaderText = "personel_adi";
            this.personel_adi.Name = "personel_adi";
            this.personel_adi.ReadOnly = true;
            // 
            // persatiskaydiBindingSource
            // 
            this.persatiskaydiBindingSource.DataMember = "per_satis_kaydi";
            this.persatiskaydiBindingSource.DataSource = this.carilerDataSet62;
            // 
            // carilerDataSet62
            // 
            this.carilerDataSet62.DataSetName = "carilerDataSet62";
            this.carilerDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perakende Satış Kaydı [PERAKENDE-SATIŞ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOPLAM TUTAR :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(711, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1035, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "İADE ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1172, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "YENİLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // per_satis_kaydiTableAdapter
            // 
            this.per_satis_kaydiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 616);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Visible = false;
            // 
            // per_satis_kaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 702);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_per_sat_kay);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1335, 749);
            this.Name = "per_satis_kaydi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "per_satis_kaydi";
            this.Load += new System.EventHandler(this.per_satis_kaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_per_sat_kay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persatiskaydiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet62)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1_per_sat_kay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private carilerDataSet62 carilerDataSet62;
        private System.Windows.Forms.BindingSource persatiskaydiBindingSource;
        private carilerDataSet62TableAdapters.per_satis_kaydiTableAdapter per_satis_kaydiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_adi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}