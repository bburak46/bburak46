namespace ilk_giris_ekranı
{
    partial class stokara
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üreticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoklistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet56 = new ilk_giris_ekranı.carilerDataSet56();
            this.stok_listTableAdapter1 = new ilk_giris_ekranı.carilerDataSet56TableAdapters.stok_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet56)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(675, 583);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(629, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokadiDataGridViewTextBoxColumn,
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadediDataGridViewTextBoxColumn,
            this.stokfiyatiDataGridViewTextBoxColumn,
            this.üreticiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoklistBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 545);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "stok_adi";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            this.stokadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokadiDataGridViewTextBoxColumn.Width = 200;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "stok_kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            this.stokkoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokadediDataGridViewTextBoxColumn
            // 
            this.stokadediDataGridViewTextBoxColumn.DataPropertyName = "stok_adedi";
            this.stokadediDataGridViewTextBoxColumn.HeaderText = "stok_adedi";
            this.stokadediDataGridViewTextBoxColumn.Name = "stokadediDataGridViewTextBoxColumn";
            this.stokadediDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokfiyatiDataGridViewTextBoxColumn
            // 
            this.stokfiyatiDataGridViewTextBoxColumn.DataPropertyName = "stok_fiyati";
            this.stokfiyatiDataGridViewTextBoxColumn.HeaderText = "stok_fiyati";
            this.stokfiyatiDataGridViewTextBoxColumn.Name = "stokfiyatiDataGridViewTextBoxColumn";
            this.stokfiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // üreticiDataGridViewTextBoxColumn
            // 
            this.üreticiDataGridViewTextBoxColumn.DataPropertyName = "üretici";
            this.üreticiDataGridViewTextBoxColumn.HeaderText = "üretici";
            this.üreticiDataGridViewTextBoxColumn.Name = "üreticiDataGridViewTextBoxColumn";
            this.üreticiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoklistBindingSource1
            // 
            this.stoklistBindingSource1.DataMember = "stok_list";
            this.stoklistBindingSource1.DataSource = this.carilerDataSet56;
            // 
            // carilerDataSet56
            // 
            this.carilerDataSet56.DataSetName = "carilerDataSet56";
            this.carilerDataSet56.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stok_listTableAdapter1
            // 
            this.stok_listTableAdapter1.ClearBeforeFill = true;
            // 
            // stokara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(901, 699);
            this.Name = "stokara";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.stokara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet56)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private carilerDataSet56 carilerDataSet56;
        private System.Windows.Forms.BindingSource stoklistBindingSource1;
        private carilerDataSet56TableAdapters.stok_listTableAdapter stok_listTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üreticiDataGridViewTextBoxColumn;
    }
}