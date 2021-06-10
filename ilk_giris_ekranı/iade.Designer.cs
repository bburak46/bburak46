namespace ilk_giris_ekranı
{
    partial class iade
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
            this.dataGridView1_cari = new System.Windows.Forms.DataGridView();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carisatiskaydiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet49 = new ilk_giris_ekranı.carilerDataSet49();
            this.dataGridView2_per = new System.Windows.Forms.DataGridView();
            this.stokkoduDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persatiskaydiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet50 = new ilk_giris_ekranı.carilerDataSet50();
            this.cari_satis_kaydiTableAdapter = new ilk_giris_ekranı.carilerDataSet49TableAdapters.cari_satis_kaydiTableAdapter();
            this.per_satis_kaydiTableAdapter = new ilk_giris_ekranı.carilerDataSet50TableAdapters.per_satis_kaydiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_cari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carisatiskaydiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persatiskaydiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet50)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_cari
            // 
            this.dataGridView1_cari.AutoGenerateColumns = false;
            this.dataGridView1_cari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_cari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.iskDataGridViewTextBoxColumn,
            this.birimfiyatDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.cariadiDataGridViewTextBoxColumn,
            this.personeladiDataGridViewTextBoxColumn});
            this.dataGridView1_cari.DataSource = this.carisatiskaydiBindingSource;
            this.dataGridView1_cari.Location = new System.Drawing.Point(738, 80);
            this.dataGridView1_cari.Name = "dataGridView1_cari";
            this.dataGridView1_cari.RowTemplate.Height = 24;
            this.dataGridView1_cari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_cari.Size = new System.Drawing.Size(720, 602);
            this.dataGridView1_cari.TabIndex = 0;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            // 
            // iskDataGridViewTextBoxColumn
            // 
            this.iskDataGridViewTextBoxColumn.DataPropertyName = "isk";
            this.iskDataGridViewTextBoxColumn.HeaderText = "isk";
            this.iskDataGridViewTextBoxColumn.Name = "iskDataGridViewTextBoxColumn";
            // 
            // birimfiyatDataGridViewTextBoxColumn
            // 
            this.birimfiyatDataGridViewTextBoxColumn.DataPropertyName = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn.HeaderText = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn.Name = "birimfiyatDataGridViewTextBoxColumn";
            // 
            // toplamtutarDataGridViewTextBoxColumn
            // 
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // cariadiDataGridViewTextBoxColumn
            // 
            this.cariadiDataGridViewTextBoxColumn.DataPropertyName = "cari_adi";
            this.cariadiDataGridViewTextBoxColumn.HeaderText = "cari_adi";
            this.cariadiDataGridViewTextBoxColumn.Name = "cariadiDataGridViewTextBoxColumn";
            // 
            // personeladiDataGridViewTextBoxColumn
            // 
            this.personeladiDataGridViewTextBoxColumn.DataPropertyName = "personel_adi";
            this.personeladiDataGridViewTextBoxColumn.HeaderText = "personel_adi";
            this.personeladiDataGridViewTextBoxColumn.Name = "personeladiDataGridViewTextBoxColumn";
            // 
            // carisatiskaydiBindingSource
            // 
            this.carisatiskaydiBindingSource.DataMember = "cari_satis_kaydi";
            this.carisatiskaydiBindingSource.DataSource = this.carilerDataSet49;
            // 
            // carilerDataSet49
            // 
            this.carilerDataSet49.DataSetName = "carilerDataSet49";
            this.carilerDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2_per
            // 
            this.dataGridView2_per.AutoGenerateColumns = false;
            this.dataGridView2_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_per.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokkoduDataGridViewTextBoxColumn1,
            this.stokadiDataGridViewTextBoxColumn1,
            this.adetDataGridViewTextBoxColumn1,
            this.birimDataGridViewTextBoxColumn1,
            this.kdvDataGridViewTextBoxColumn1,
            this.iskDataGridViewTextBoxColumn1,
            this.birimfiyatDataGridViewTextBoxColumn1,
            this.toplamtutarDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1,
            this.personeladiDataGridViewTextBoxColumn1});
            this.dataGridView2_per.DataSource = this.persatiskaydiBindingSource;
            this.dataGridView2_per.Location = new System.Drawing.Point(12, 80);
            this.dataGridView2_per.Name = "dataGridView2_per";
            this.dataGridView2_per.RowTemplate.Height = 24;
            this.dataGridView2_per.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_per.Size = new System.Drawing.Size(720, 602);
            this.dataGridView2_per.TabIndex = 2;
            // 
            // stokkoduDataGridViewTextBoxColumn1
            // 
            this.stokkoduDataGridViewTextBoxColumn1.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn1.HeaderText = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn1.Name = "stokkoduDataGridViewTextBoxColumn1";
            // 
            // stokadiDataGridViewTextBoxColumn1
            // 
            this.stokadiDataGridViewTextBoxColumn1.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn1.HeaderText = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn1.Name = "stokadiDataGridViewTextBoxColumn1";
            // 
            // adetDataGridViewTextBoxColumn1
            // 
            this.adetDataGridViewTextBoxColumn1.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn1.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn1.Name = "adetDataGridViewTextBoxColumn1";
            // 
            // birimDataGridViewTextBoxColumn1
            // 
            this.birimDataGridViewTextBoxColumn1.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn1.HeaderText = "birim";
            this.birimDataGridViewTextBoxColumn1.Name = "birimDataGridViewTextBoxColumn1";
            // 
            // kdvDataGridViewTextBoxColumn1
            // 
            this.kdvDataGridViewTextBoxColumn1.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn1.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn1.Name = "kdvDataGridViewTextBoxColumn1";
            // 
            // iskDataGridViewTextBoxColumn1
            // 
            this.iskDataGridViewTextBoxColumn1.DataPropertyName = "isk";
            this.iskDataGridViewTextBoxColumn1.HeaderText = "isk";
            this.iskDataGridViewTextBoxColumn1.Name = "iskDataGridViewTextBoxColumn1";
            // 
            // birimfiyatDataGridViewTextBoxColumn1
            // 
            this.birimfiyatDataGridViewTextBoxColumn1.DataPropertyName = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn1.HeaderText = "birim_fiyat";
            this.birimfiyatDataGridViewTextBoxColumn1.Name = "birimfiyatDataGridViewTextBoxColumn1";
            // 
            // toplamtutarDataGridViewTextBoxColumn1
            // 
            this.toplamtutarDataGridViewTextBoxColumn1.DataPropertyName = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn1.HeaderText = "toplam_tutar";
            this.toplamtutarDataGridViewTextBoxColumn1.Name = "toplamtutarDataGridViewTextBoxColumn1";
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            // 
            // personeladiDataGridViewTextBoxColumn1
            // 
            this.personeladiDataGridViewTextBoxColumn1.DataPropertyName = "personel_adi";
            this.personeladiDataGridViewTextBoxColumn1.HeaderText = "personel_adi";
            this.personeladiDataGridViewTextBoxColumn1.Name = "personeladiDataGridViewTextBoxColumn1";
            // 
            // persatiskaydiBindingSource
            // 
            this.persatiskaydiBindingSource.DataMember = "per_satis_kaydi";
            this.persatiskaydiBindingSource.DataSource = this.carilerDataSet50;
            // 
            // carilerDataSet50
            // 
            this.carilerDataSet50.DataSetName = "carilerDataSet50";
            this.carilerDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cari_satis_kaydiTableAdapter
            // 
            this.cari_satis_kaydiTableAdapter.ClearBeforeFill = true;
            // 
            // per_satis_kaydiTableAdapter
            // 
            this.per_satis_kaydiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "PERSONEL SATIŞ DETAY[SATIŞ-DETAY]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(734, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CARİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "PERAKENDE";
            // 
            // iade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_cari);
            this.Controls.Add(this.dataGridView2_per);
            this.Name = "iade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.iade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_cari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carisatiskaydiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persatiskaydiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_cari;
        private System.Windows.Forms.DataGridView dataGridView2_per;
        private carilerDataSet49 carilerDataSet49;
        private System.Windows.Forms.BindingSource carisatiskaydiBindingSource;
        private carilerDataSet49TableAdapters.cari_satis_kaydiTableAdapter cari_satis_kaydiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladiDataGridViewTextBoxColumn;
        private carilerDataSet50 carilerDataSet50;
        private System.Windows.Forms.BindingSource persatiskaydiBindingSource;
        private carilerDataSet50TableAdapters.per_satis_kaydiTableAdapter per_satis_kaydiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}