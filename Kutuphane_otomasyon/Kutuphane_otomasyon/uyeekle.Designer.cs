namespace Kutuphane_otomasyon
{
    partial class uyeekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uye_listele = new System.Windows.Forms.Button();
            this.uye_guncelle = new System.Windows.Forms.Button();
            this.uye_sil = new System.Windows.Forms.Button();
            this.uye_kydt = new System.Windows.Forms.Button();
            this.adres_text = new System.Windows.Forms.RichTextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.kyttarihi_text = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telno_text = new System.Windows.Forms.MaskedTextBox();
            this.soyisim_text = new System.Windows.Forms.TextBox();
            this.isim_text = new System.Windows.Forms.TextBox();
            this.tckimlik_text = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgwuyeler = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.uye_id = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwuyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.uye_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.uye_listele);
            this.groupBox1.Controls.Add(this.uye_guncelle);
            this.groupBox1.Controls.Add(this.uye_sil);
            this.groupBox1.Controls.Add(this.uye_kydt);
            this.groupBox1.Controls.Add(this.adres_text);
            this.groupBox1.Controls.Add(this.email_text);
            this.groupBox1.Controls.Add(this.kyttarihi_text);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.telno_text);
            this.groupBox1.Controls.Add(this.soyisim_text);
            this.groupBox1.Controls.Add(this.isim_text);
            this.groupBox1.Controls.Add(this.tckimlik_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Üye Kayıt";
            // 
            // uye_listele
            // 
            this.uye_listele.Location = new System.Drawing.Point(728, 120);
            this.uye_listele.Name = "uye_listele";
            this.uye_listele.Size = new System.Drawing.Size(65, 32);
            this.uye_listele.TabIndex = 17;
            this.uye_listele.Text = "Listele";
            this.uye_listele.UseVisualStyleBackColor = true;
            this.uye_listele.Click += new System.EventHandler(this.uye_listele_Click);
            // 
            // uye_guncelle
            // 
            this.uye_guncelle.Location = new System.Drawing.Point(728, 71);
            this.uye_guncelle.Name = "uye_guncelle";
            this.uye_guncelle.Size = new System.Drawing.Size(148, 32);
            this.uye_guncelle.TabIndex = 16;
            this.uye_guncelle.Text = "Güncelle";
            this.uye_guncelle.UseVisualStyleBackColor = true;
            this.uye_guncelle.Click += new System.EventHandler(this.uye_guncelle_Click);
            // 
            // uye_sil
            // 
            this.uye_sil.Location = new System.Drawing.Point(811, 21);
            this.uye_sil.Name = "uye_sil";
            this.uye_sil.Size = new System.Drawing.Size(65, 34);
            this.uye_sil.TabIndex = 15;
            this.uye_sil.Text = "Sil";
            this.uye_sil.UseVisualStyleBackColor = true;
            this.uye_sil.Click += new System.EventHandler(this.uye_sil_Click);
            // 
            // uye_kydt
            // 
            this.uye_kydt.Location = new System.Drawing.Point(728, 21);
            this.uye_kydt.Name = "uye_kydt";
            this.uye_kydt.Size = new System.Drawing.Size(65, 34);
            this.uye_kydt.TabIndex = 14;
            this.uye_kydt.Text = "Kayıt";
            this.uye_kydt.UseVisualStyleBackColor = true;
            this.uye_kydt.Click += new System.EventHandler(this.uye_kydt_Click);
            // 
            // adres_text
            // 
            this.adres_text.Location = new System.Drawing.Point(484, 87);
            this.adres_text.Name = "adres_text";
            this.adres_text.Size = new System.Drawing.Size(192, 70);
            this.adres_text.TabIndex = 13;
            this.adres_text.Text = "";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(484, 56);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(143, 20);
            this.email_text.TabIndex = 12;
            // 
            // kyttarihi_text
            // 
            this.kyttarihi_text.Location = new System.Drawing.Point(484, 26);
            this.kyttarihi_text.Name = "kyttarihi_text";
            this.kyttarihi_text.Size = new System.Drawing.Size(200, 20);
            this.kyttarihi_text.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adres:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " Kayıt Tarihi:";
            // 
            // telno_text
            // 
            this.telno_text.Location = new System.Drawing.Point(147, 132);
            this.telno_text.Mask = "(999) 000-0000";
            this.telno_text.Name = "telno_text";
            this.telno_text.Size = new System.Drawing.Size(143, 20);
            this.telno_text.TabIndex = 7;
            // 
            // soyisim_text
            // 
            this.soyisim_text.Location = new System.Drawing.Point(147, 102);
            this.soyisim_text.Name = "soyisim_text";
            this.soyisim_text.Size = new System.Drawing.Size(143, 20);
            this.soyisim_text.TabIndex = 6;
            // 
            // isim_text
            // 
            this.isim_text.Location = new System.Drawing.Point(147, 71);
            this.isim_text.Name = "isim_text";
            this.isim_text.Size = new System.Drawing.Size(143, 20);
            this.isim_text.TabIndex = 5;
            // 
            // tckimlik_text
            // 
            this.tckimlik_text.Location = new System.Drawing.Point(148, 43);
            this.tckimlik_text.Mask = "00000000000";
            this.tckimlik_text.Name = "tckimlik_text";
            this.tckimlik_text.Size = new System.Drawing.Size(143, 20);
            this.tckimlik_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TEL No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // dgwuyeler
            // 
            this.dgwuyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwuyeler.Location = new System.Drawing.Point(82, 222);
            this.dgwuyeler.Name = "dgwuyeler";
            this.dgwuyeler.Size = new System.Drawing.Size(840, 184);
            this.dgwuyeler.TabIndex = 18;
            this.dgwuyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwuyeler_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Üye ID:";
            // 
            // uye_id
            // 
            this.uye_id.AutoSize = true;
            this.uye_id.Location = new System.Drawing.Point(145, 21);
            this.uye_id.Name = "uye_id";
            this.uye_id.Size = new System.Drawing.Size(13, 13);
            this.uye_id.TabIndex = 19;
            this.uye_id.Text = "0";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(811, 120);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(65, 32);
            this.btn_temizle.TabIndex = 20;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // uyeekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.dgwuyeler);
            this.Controls.Add(this.groupBox1);
            this.Name = "uyeekle";
            this.Text = "Yeni Üye Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwuyeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox soyisim_text;
        private System.Windows.Forms.TextBox isim_text;
        private System.Windows.Forms.MaskedTextBox tckimlik_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telno_text;
        private System.Windows.Forms.DateTimePicker kyttarihi_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox adres_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Button uye_listele;
        private System.Windows.Forms.Button uye_guncelle;
        private System.Windows.Forms.Button uye_sil;
        private System.Windows.Forms.Button uye_kydt;
        private System.Windows.Forms.DataGridView dgwuyeler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uye_id;
        private System.Windows.Forms.Button btn_temizle;
    }
}