namespace ilk_giris_ekranı
{
    partial class stokgör
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üreticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alis_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet55 = new ilk_giris_ekranı.carilerDataSet55();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stok_listTableAdapter1 = new ilk_giris_ekranı.carilerDataSet55TableAdapters.stok_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet55)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stok Sil";
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
            this.stokadiDataGridViewTextBoxColumn,
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadediDataGridViewTextBoxColumn,
            this.stokfiyatiDataGridViewTextBoxColumn,
            this.üreticiDataGridViewTextBoxColumn,
            this.alis_fiyat});
            this.dataGridView1.DataSource = this.stoklistBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(865, 483);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "STOK ADI";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            this.stokadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokadiDataGridViewTextBoxColumn.Width = 110;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "STOK KODU";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            this.stokkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokadediDataGridViewTextBoxColumn
            // 
            this.stokadediDataGridViewTextBoxColumn.DataPropertyName = "stok_adedi";
            this.stokadediDataGridViewTextBoxColumn.HeaderText = "STOK ADEDİ";
            this.stokadediDataGridViewTextBoxColumn.Name = "stokadediDataGridViewTextBoxColumn";
            this.stokadediDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokfiyatiDataGridViewTextBoxColumn
            // 
            this.stokfiyatiDataGridViewTextBoxColumn.DataPropertyName = "stok_fiyati";
            this.stokfiyatiDataGridViewTextBoxColumn.HeaderText = "STOK FİYATI";
            this.stokfiyatiDataGridViewTextBoxColumn.Name = "stokfiyatiDataGridViewTextBoxColumn";
            this.stokfiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // üreticiDataGridViewTextBoxColumn
            // 
            this.üreticiDataGridViewTextBoxColumn.DataPropertyName = "üretici";
            this.üreticiDataGridViewTextBoxColumn.HeaderText = "ÜRETİCİ";
            this.üreticiDataGridViewTextBoxColumn.Name = "üreticiDataGridViewTextBoxColumn";
            this.üreticiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alis_fiyat
            // 
            this.alis_fiyat.DataPropertyName = "alis_fiyat";
            this.alis_fiyat.HeaderText = "ALIŞ FİYAT";
            this.alis_fiyat.Name = "alis_fiyat";
            this.alis_fiyat.ReadOnly = true;
            // 
            // stoklistBindingSource1
            // 
            this.stoklistBindingSource1.DataMember = "stok_list";
            this.stoklistBindingSource1.DataSource = this.carilerDataSet55;
            // 
            // carilerDataSet55
            // 
            this.carilerDataSet55.DataSetName = "carilerDataSet55";
            this.carilerDataSet55.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 506);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(597, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ARA :";
            // 
            // stok_listTableAdapter1
            // 
            this.stok_listTableAdapter1.ClearBeforeFill = true;
            // 
            // stokgör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(907, 592);
            this.Name = "stokgör";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.stokgör_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet55)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private carilerDataSet55 carilerDataSet55;
        private System.Windows.Forms.BindingSource stoklistBindingSource1;
        private carilerDataSet55TableAdapters.stok_listTableAdapter stok_listTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üreticiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alis_fiyat;
    }
}