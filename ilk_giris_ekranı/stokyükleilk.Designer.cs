namespace ilk_giris_ekranı
{
    partial class stokyükleilk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokyükleilk));
            this.label1_stokyükleilk = new System.Windows.Forms.Label();
            this.label2_stokyükleilktip = new System.Windows.Forms.Label();
            this.comboBox1_stokyükle1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1_stokyükle = new System.Windows.Forms.PictureBox();
            this.button_stokyükleilk_iptal = new System.Windows.Forms.Button();
            this.button1_stokyükleilk_tamam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_stokyükle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_stokyükleilk
            // 
            this.label1_stokyükleilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_stokyükleilk.Location = new System.Drawing.Point(121, 19);
            this.label1_stokyükleilk.Name = "label1_stokyükleilk";
            this.label1_stokyükleilk.Size = new System.Drawing.Size(250, 51);
            this.label1_stokyükleilk.TabIndex = 0;
            this.label1_stokyükleilk.Text = "Yeni bir stok tanımlamadan önce Stok  Tipini belirtmeniz gerekiyor.";
            // 
            // label2_stokyükleilktip
            // 
            this.label2_stokyükleilktip.AutoSize = true;
            this.label2_stokyükleilktip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_stokyükleilktip.Location = new System.Drawing.Point(24, 83);
            this.label2_stokyükleilktip.Name = "label2_stokyükleilktip";
            this.label2_stokyükleilktip.Size = new System.Drawing.Size(129, 18);
            this.label2_stokyükleilktip.TabIndex = 1;
            this.label2_stokyükleilktip.Text = "Stok Tipi Belirtiniz:";
            // 
            // comboBox1_stokyükle1
            // 
            this.comboBox1_stokyükle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_stokyükle1.Items.AddRange(new object[] {
            "Seri Detay",
            "Yedek Parça"});
            this.comboBox1_stokyükle1.Location = new System.Drawing.Point(27, 116);
            this.comboBox1_stokyükle1.Name = "comboBox1_stokyükle1";
            this.comboBox1_stokyükle1.Size = new System.Drawing.Size(315, 24);
            this.comboBox1_stokyükle1.TabIndex = 1;
            this.comboBox1_stokyükle1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_stokyükle1_SelectedIndexChanged);
            // 
            // pictureBox1_stokyükle
            // 
            this.pictureBox1_stokyükle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_stokyükle.Image")));
            this.pictureBox1_stokyükle.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1_stokyükle.Name = "pictureBox1_stokyükle";
            this.pictureBox1_stokyükle.Size = new System.Drawing.Size(60, 40);
            this.pictureBox1_stokyükle.TabIndex = 3;
            this.pictureBox1_stokyükle.TabStop = false;
            // 
            // button_stokyükleilk_iptal
            // 
            this.button_stokyükleilk_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_stokyükleilk_iptal.Location = new System.Drawing.Point(238, 161);
            this.button_stokyükleilk_iptal.Name = "button_stokyükleilk_iptal";
            this.button_stokyükleilk_iptal.Size = new System.Drawing.Size(104, 23);
            this.button_stokyükleilk_iptal.TabIndex = 4;
            this.button_stokyükleilk_iptal.Text = "İPTAL";
            this.button_stokyükleilk_iptal.UseVisualStyleBackColor = true;
            this.button_stokyükleilk_iptal.Click += new System.EventHandler(this.button_stokyükleilk_iptal_Click);
            // 
            // button1_stokyükleilk_tamam
            // 
            this.button1_stokyükleilk_tamam.Location = new System.Drawing.Point(124, 161);
            this.button1_stokyükleilk_tamam.Name = "button1_stokyükleilk_tamam";
            this.button1_stokyükleilk_tamam.Size = new System.Drawing.Size(104, 23);
            this.button1_stokyükleilk_tamam.TabIndex = 5;
            this.button1_stokyükleilk_tamam.Text = "DEVAM ET";
            this.button1_stokyükleilk_tamam.UseVisualStyleBackColor = true;
            this.button1_stokyükleilk_tamam.Click += new System.EventHandler(this.button1_stokyükleilk_tamam_Click);
            // 
            // stokyükleilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_stokyükleilk_iptal;
            this.ClientSize = new System.Drawing.Size(376, 209);
            this.Controls.Add(this.button1_stokyükleilk_tamam);
            this.Controls.Add(this.button_stokyükleilk_iptal);
            this.Controls.Add(this.pictureBox1_stokyükle);
            this.Controls.Add(this.comboBox1_stokyükle1);
            this.Controls.Add(this.label2_stokyükleilktip);
            this.Controls.Add(this.label1_stokyükleilk);
            this.Name = "stokyükleilk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.stokyükleilk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_stokyükle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_stokyükleilk;
        private System.Windows.Forms.Label label2_stokyükleilktip;
        private System.Windows.Forms.ComboBox comboBox1_stokyükle1;
        private System.Windows.Forms.PictureBox pictureBox1_stokyükle;
        private System.Windows.Forms.Button button_stokyükleilk_iptal;
        private System.Windows.Forms.Button button1_stokyükleilk_tamam;
    }
}