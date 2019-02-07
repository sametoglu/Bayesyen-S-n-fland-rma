namespace veri_odevi
{
    partial class Form1
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_aractip = new System.Windows.Forms.ComboBox();
            this.tb_limit = new System.Windows.Forms.TextBox();
            this.tb_yıl = new System.Windows.Forms.TextBox();
            this.dgv_tablo = new System.Windows.Forms.DataGridView();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_degisim = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gb_cikti = new System.Windows.Forms.GroupBox();
            this.lbl_pc5x1 = new System.Windows.Forms.Label();
            this.lbl_pc4x1 = new System.Windows.Forms.Label();
            this.lbl_pc3x1 = new System.Windows.Forms.Label();
            this.lbl_pc2x1 = new System.Windows.Forms.Label();
            this.lbl_pc1x1 = new System.Windows.Forms.Label();
            this.btn_karar_agacı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_degisim)).BeginInit();
            this.gb_cikti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(14, 143);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(198, 20);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Km Limiti : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uretim Yılı : ";
            // 
            // cb_aractip
            // 
            this.cb_aractip.FormattingEnabled = true;
            this.cb_aractip.Items.AddRange(new object[] {
            "otomobil",
            "arazi",
            "minivan"});
            this.cb_aractip.Location = new System.Drawing.Point(95, 116);
            this.cb_aractip.Name = "cb_aractip";
            this.cb_aractip.Size = new System.Drawing.Size(117, 21);
            this.cb_aractip.TabIndex = 6;
            // 
            // tb_limit
            // 
            this.tb_limit.Location = new System.Drawing.Point(95, 38);
            this.tb_limit.MaxLength = 200000;
            this.tb_limit.Name = "tb_limit";
            this.tb_limit.Size = new System.Drawing.Size(117, 20);
            this.tb_limit.TabIndex = 7;
            // 
            // tb_yıl
            // 
            this.tb_yıl.Location = new System.Drawing.Point(95, 64);
            this.tb_yıl.Name = "tb_yıl";
            this.tb_yıl.Size = new System.Drawing.Size(117, 20);
            this.tb_yıl.TabIndex = 8;
            // 
            // dgv_tablo
            // 
            this.dgv_tablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablo.Location = new System.Drawing.Point(218, 12);
            this.dgv_tablo.Name = "dgv_tablo";
            this.dgv_tablo.Size = new System.Drawing.Size(561, 316);
            this.dgv_tablo.TabIndex = 9;
            this.dgv_tablo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tablo_CellMouseDoubleClick);
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(95, 12);
            this.tb_fiyat.MaxLength = 250000;
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(117, 20);
            this.tb_fiyat.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiyat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Arac Tipi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "%Parca Degisim: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "otomobil:1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "arazi:2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "minivan:3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "200.000 < : 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "100.000 << 200.000 : 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "< 100.000 : 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 330);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilendirme";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(6, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 65);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Km Limiti ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 60);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Uretim Yılı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "2010 < : 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "2000 << 2010 : 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "< 2000 : 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(6, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 84);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fiyat";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "200.000 << 250.000 : 5";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "150.000 << 200.000 : 4";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(60, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "< 50.000 : 1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "50.000 << 100.000 : 2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "100.000 << 150.000 : 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(83, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 74);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parca Degisim %";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "%66 < : 3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "< % 33 : 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "%33 << %66 : 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(67, 66);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arac Tip";
            // 
            // nud_degisim
            // 
            this.nud_degisim.Location = new System.Drawing.Point(95, 91);
            this.nud_degisim.Name = "nud_degisim";
            this.nud_degisim.Size = new System.Drawing.Size(117, 20);
            this.nud_degisim.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(593, 331);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(186, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "id\'ye cift tıklayarak hesap yapabilirsiniz";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "P(c1,x1) : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "P(c2,x1) : ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 106);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "P(c4,x1) : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "P(c3,x1) : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 129);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "P(c5,x1) : ";
            // 
            // gb_cikti
            // 
            this.gb_cikti.Controls.Add(this.lbl_pc5x1);
            this.gb_cikti.Controls.Add(this.lbl_pc4x1);
            this.gb_cikti.Controls.Add(this.lbl_pc3x1);
            this.gb_cikti.Controls.Add(this.lbl_pc2x1);
            this.gb_cikti.Controls.Add(this.lbl_pc1x1);
            this.gb_cikti.Controls.Add(this.label24);
            this.gb_cikti.Controls.Add(this.label28);
            this.gb_cikti.Controls.Add(this.label25);
            this.gb_cikti.Controls.Add(this.label26);
            this.gb_cikti.Controls.Add(this.label27);
            this.gb_cikti.Location = new System.Drawing.Point(218, 334);
            this.gb_cikti.Name = "gb_cikti";
            this.gb_cikti.Size = new System.Drawing.Size(158, 153);
            this.gb_cikti.TabIndex = 30;
            this.gb_cikti.TabStop = false;
            this.gb_cikti.Text = "Çıktılar";
            this.gb_cikti.Visible = false;
            // 
            // lbl_pc5x1
            // 
            this.lbl_pc5x1.AutoSize = true;
            this.lbl_pc5x1.Location = new System.Drawing.Point(67, 129);
            this.lbl_pc5x1.Name = "lbl_pc5x1";
            this.lbl_pc5x1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pc5x1.TabIndex = 34;
            // 
            // lbl_pc4x1
            // 
            this.lbl_pc4x1.AutoSize = true;
            this.lbl_pc4x1.Location = new System.Drawing.Point(67, 106);
            this.lbl_pc4x1.Name = "lbl_pc4x1";
            this.lbl_pc4x1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pc4x1.TabIndex = 33;
            // 
            // lbl_pc3x1
            // 
            this.lbl_pc3x1.AutoSize = true;
            this.lbl_pc3x1.Location = new System.Drawing.Point(67, 77);
            this.lbl_pc3x1.Name = "lbl_pc3x1";
            this.lbl_pc3x1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pc3x1.TabIndex = 32;
            // 
            // lbl_pc2x1
            // 
            this.lbl_pc2x1.AutoSize = true;
            this.lbl_pc2x1.Location = new System.Drawing.Point(67, 50);
            this.lbl_pc2x1.Name = "lbl_pc2x1";
            this.lbl_pc2x1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pc2x1.TabIndex = 31;
            // 
            // lbl_pc1x1
            // 
            this.lbl_pc1x1.AutoSize = true;
            this.lbl_pc1x1.Location = new System.Drawing.Point(67, 24);
            this.lbl_pc1x1.Name = "lbl_pc1x1";
            this.lbl_pc1x1.Size = new System.Drawing.Size(0, 13);
            this.lbl_pc1x1.TabIndex = 30;
            // 
            // btn_karar_agacı
            // 
            this.btn_karar_agacı.Location = new System.Drawing.Point(704, 350);
            this.btn_karar_agacı.Name = "btn_karar_agacı";
            this.btn_karar_agacı.Size = new System.Drawing.Size(75, 23);
            this.btn_karar_agacı.TabIndex = 31;
            this.btn_karar_agacı.Text = "Karar agacı";
            this.btn_karar_agacı.UseVisualStyleBackColor = true;
            this.btn_karar_agacı.Click += new System.EventHandler(this.btn_karar_agacı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.btn_karar_agacı);
            this.Controls.Add(this.gb_cikti);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.nud_degisim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_fiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tablo);
            this.Controls.Add(this.tb_yıl);
            this.Controls.Add(this.tb_limit);
            this.Controls.Add(this.cb_aractip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_degisim)).EndInit();
            this.gb_cikti.ResumeLayout(false);
            this.gb_cikti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_aractip;
        private System.Windows.Forms.TextBox tb_limit;
        private System.Windows.Forms.TextBox tb_yıl;
        private System.Windows.Forms.DataGridView dgv_tablo;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_degisim;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox gb_cikti;
        private System.Windows.Forms.Label lbl_pc5x1;
        private System.Windows.Forms.Label lbl_pc4x1;
        private System.Windows.Forms.Label lbl_pc3x1;
        private System.Windows.Forms.Label lbl_pc2x1;
        private System.Windows.Forms.Label lbl_pc1x1;
        private System.Windows.Forms.Button btn_karar_agacı;
    }
}

