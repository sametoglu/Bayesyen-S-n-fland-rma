namespace veri_odevi
{
    partial class Form2
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
            this.cb_degisim = new System.Windows.Forms.ComboBox();
            this.cb_fiyat = new System.Windows.Forms.ComboBox();
            this.cb_km_limiti = new System.Windows.Forms.ComboBox();
            this.cb_uretim_yili = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dgv_tablo = new System.Windows.Forms.DataGridView();
            this.btn_karar_agacı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_degisim
            // 
            this.cb_degisim.FormattingEnabled = true;
            this.cb_degisim.Items.AddRange(new object[] {
            "Az",
            "Çok"});
            this.cb_degisim.Location = new System.Drawing.Point(96, 12);
            this.cb_degisim.Name = "cb_degisim";
            this.cb_degisim.Size = new System.Drawing.Size(121, 21);
            this.cb_degisim.TabIndex = 0;
            // 
            // cb_fiyat
            // 
            this.cb_fiyat.FormattingEnabled = true;
            this.cb_fiyat.Items.AddRange(new object[] {
            "Çok Ucuz",
            "Ucuz",
            "Orta",
            "Pahalı",
            "Çok Pahalı"});
            this.cb_fiyat.Location = new System.Drawing.Point(96, 39);
            this.cb_fiyat.Name = "cb_fiyat";
            this.cb_fiyat.Size = new System.Drawing.Size(121, 21);
            this.cb_fiyat.TabIndex = 1;
            // 
            // cb_km_limiti
            // 
            this.cb_km_limiti.FormattingEnabled = true;
            this.cb_km_limiti.Items.AddRange(new object[] {
            "Az",
            "Orta",
            "Çok"});
            this.cb_km_limiti.Location = new System.Drawing.Point(96, 66);
            this.cb_km_limiti.Name = "cb_km_limiti";
            this.cb_km_limiti.Size = new System.Drawing.Size(121, 21);
            this.cb_km_limiti.TabIndex = 2;
            // 
            // cb_uretim_yili
            // 
            this.cb_uretim_yili.FormattingEnabled = true;
            this.cb_uretim_yili.Items.AddRange(new object[] {
            "Eski",
            "Yeni"});
            this.cb_uretim_yili.Location = new System.Drawing.Point(96, 93);
            this.cb_uretim_yili.Name = "cb_uretim_yili";
            this.cb_uretim_yili.Size = new System.Drawing.Size(121, 21);
            this.cb_uretim_yili.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parca degisim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fİyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Km limiti : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uretim Yılı : ";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(11, 120);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(206, 20);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dgv_tablo
            // 
            this.dgv_tablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablo.Location = new System.Drawing.Point(223, 12);
            this.dgv_tablo.Name = "dgv_tablo";
            this.dgv_tablo.Size = new System.Drawing.Size(555, 260);
            this.dgv_tablo.TabIndex = 10;
            // 
            // btn_karar_agacı
            // 
            this.btn_karar_agacı.Location = new System.Drawing.Point(11, 146);
            this.btn_karar_agacı.Name = "btn_karar_agacı";
            this.btn_karar_agacı.Size = new System.Drawing.Size(206, 30);
            this.btn_karar_agacı.TabIndex = 8;
            this.btn_karar_agacı.Text = "karar agacı olustur";
            this.btn_karar_agacı.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.btn_karar_agacı);
            this.Controls.Add(this.dgv_tablo);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_uretim_yili);
            this.Controls.Add(this.cb_km_limiti);
            this.Controls.Add(this.cb_fiyat);
            this.Controls.Add(this.cb_degisim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_degisim;
        private System.Windows.Forms.ComboBox cb_fiyat;
        private System.Windows.Forms.ComboBox cb_km_limiti;
        private System.Windows.Forms.ComboBox cb_uretim_yili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dgv_tablo;
        private System.Windows.Forms.Button btn_karar_agacı;
    }
}