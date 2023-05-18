namespace Kutuphane_otomasyon
{
    partial class kitapdznle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kitap_listele = new System.Windows.Forms.Button();
            this.kitap_guncel = new System.Windows.Forms.Button();
            this.kitap_sil = new System.Windows.Forms.Button();
            this.tur_cmb = new System.Windows.Forms.ComboBox();
            this.kitap_kaydt = new System.Windows.Forms.Button();
            this.kitap_raf = new System.Windows.Forms.TextBox();
            this.basim_tarih = new System.Windows.Forms.DateTimePicker();
            this.yayinevi_adi = new System.Windows.Forms.TextBox();
            this.kitp_yzr = new System.Windows.Forms.TextBox();
            this.kitp_adi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgwkitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kitap_listele);
            this.groupBox1.Controls.Add(this.kitap_guncel);
            this.groupBox1.Controls.Add(this.kitap_sil);
            this.groupBox1.Controls.Add(this.tur_cmb);
            this.groupBox1.Controls.Add(this.kitap_kaydt);
            this.groupBox1.Controls.Add(this.kitap_raf);
            this.groupBox1.Controls.Add(this.basim_tarih);
            this.groupBox1.Controls.Add(this.yayinevi_adi);
            this.groupBox1.Controls.Add(this.kitp_yzr);
            this.groupBox1.Controls.Add(this.kitp_adi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kitap Detayları";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(102, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "KitapID:";
            // 
            // kitap_listele
            // 
            this.kitap_listele.Location = new System.Drawing.Point(564, 161);
            this.kitap_listele.Name = "kitap_listele";
            this.kitap_listele.Size = new System.Drawing.Size(117, 52);
            this.kitap_listele.TabIndex = 15;
            this.kitap_listele.Text = "Listeyi Görüntüle / Yazdır";
            this.kitap_listele.UseVisualStyleBackColor = true;
            this.kitap_listele.Click += new System.EventHandler(this.kitap_listele_Click);
            // 
            // kitap_guncel
            // 
            this.kitap_guncel.Location = new System.Drawing.Point(398, 161);
            this.kitap_guncel.Name = "kitap_guncel";
            this.kitap_guncel.Size = new System.Drawing.Size(117, 52);
            this.kitap_guncel.TabIndex = 14;
            this.kitap_guncel.Text = "Güncelle";
            this.kitap_guncel.UseVisualStyleBackColor = true;
            this.kitap_guncel.Click += new System.EventHandler(this.kitap_guncel_Click);
            // 
            // kitap_sil
            // 
            this.kitap_sil.Location = new System.Drawing.Point(223, 161);
            this.kitap_sil.Name = "kitap_sil";
            this.kitap_sil.Size = new System.Drawing.Size(117, 52);
            this.kitap_sil.TabIndex = 13;
            this.kitap_sil.Text = "Sil";
            this.kitap_sil.UseVisualStyleBackColor = true;
            this.kitap_sil.Click += new System.EventHandler(this.kitap_sil_Click);
            // 
            // tur_cmb
            // 
            this.tur_cmb.FormattingEnabled = true;
            this.tur_cmb.Items.AddRange(new object[] {
            "Roman",
            "Anı Kitapları",
            "Hikaye Kitapları",
            "Gezi Kitapları",
            "Şiir Kitapları",
            "Biyografi Kitapları",
            "Din Kitapları",
            "Bilgi Kitapları",
            "Çocuk Kitapları"});
            this.tur_cmb.Location = new System.Drawing.Point(412, 72);
            this.tur_cmb.Name = "tur_cmb";
            this.tur_cmb.Size = new System.Drawing.Size(171, 21);
            this.tur_cmb.TabIndex = 12;
            // 
            // kitap_kaydt
            // 
            this.kitap_kaydt.Location = new System.Drawing.Point(42, 161);
            this.kitap_kaydt.Name = "kitap_kaydt";
            this.kitap_kaydt.Size = new System.Drawing.Size(117, 52);
            this.kitap_kaydt.TabIndex = 11;
            this.kitap_kaydt.Text = "Kaydet";
            this.kitap_kaydt.UseVisualStyleBackColor = true;
            this.kitap_kaydt.Click += new System.EventHandler(this.kitap_kaydt_Click);
            // 
            // kitap_raf
            // 
            this.kitap_raf.Location = new System.Drawing.Point(444, 109);
            this.kitap_raf.Name = "kitap_raf";
            this.kitap_raf.Size = new System.Drawing.Size(154, 20);
            this.kitap_raf.TabIndex = 10;
            // 
            // basim_tarih
            // 
            this.basim_tarih.Location = new System.Drawing.Point(398, 32);
            this.basim_tarih.Name = "basim_tarih";
            this.basim_tarih.Size = new System.Drawing.Size(200, 20);
            this.basim_tarih.TabIndex = 9;
            // 
            // yayinevi_adi
            // 
            this.yayinevi_adi.Location = new System.Drawing.Point(117, 124);
            this.yayinevi_adi.Name = "yayinevi_adi";
            this.yayinevi_adi.Size = new System.Drawing.Size(154, 20);
            this.yayinevi_adi.TabIndex = 8;
            // 
            // kitp_yzr
            // 
            this.kitp_yzr.Location = new System.Drawing.Point(117, 90);
            this.kitp_yzr.Name = "kitp_yzr";
            this.kitp_yzr.Size = new System.Drawing.Size(154, 20);
            this.kitp_yzr.TabIndex = 7;
            // 
            // kitp_adi
            // 
            this.kitp_adi.Location = new System.Drawing.Point(105, 57);
            this.kitp_adi.Name = "kitp_adi";
            this.kitp_adi.Size = new System.Drawing.Size(154, 20);
            this.kitp_adi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kitap Raf/Servis Yeri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitabın Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basım Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayın Evi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabın Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgwkitaplar
            // 
            this.dgwkitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkitaplar.Location = new System.Drawing.Point(74, 268);
            this.dgwkitaplar.Name = "dgwkitaplar";
            this.dgwkitaplar.Size = new System.Drawing.Size(731, 187);
            this.dgwkitaplar.TabIndex = 2;
            this.dgwkitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwkitaplar_CellClick);
            // 
            // kitapdznle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 467);
            this.Controls.Add(this.dgwkitaplar);
            this.Controls.Add(this.groupBox1);
            this.Name = "kitapdznle";
            this.Text = "Yeni Kitap Ekle";
            this.Load += new System.EventHandler(this.kitapdznle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kitap_raf;
        private System.Windows.Forms.DateTimePicker basim_tarih;
        private System.Windows.Forms.TextBox yayinevi_adi;
        private System.Windows.Forms.TextBox kitp_yzr;
        private System.Windows.Forms.TextBox kitp_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitap_listele;
        private System.Windows.Forms.Button kitap_guncel;
        private System.Windows.Forms.Button kitap_sil;
        private System.Windows.Forms.ComboBox tur_cmb;
        private System.Windows.Forms.Button kitap_kaydt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgwkitaplar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_id;
    }
}