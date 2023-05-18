namespace Kutuphane_otomasyon
{
    partial class emanetkitap
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
            this.k_adi = new System.Windows.Forms.ComboBox();
            this.uyeekleesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonDBDataSet = new Kutuphane_otomasyon.KutuphaneOtomasyonDBDataSet();
            this.uyeekleesTableAdapter = new Kutuphane_otomasyon.KutuphaneOtomasyonDBDataSetTableAdapters.uyeekleesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emanet_id = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kydt = new System.Windows.Forms.Button();
            this.kitap_iade = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.kitap_verilis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.raf_numara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kitp_adi = new System.Windows.Forms.ComboBox();
            this.kitapdzenleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonDBDataSet1 = new Kutuphane_otomasyon.KutuphaneOtomasyonDBDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapdzenleTableAdapter = new Kutuphane_otomasyon.KutuphaneOtomasyonDBDataSet1TableAdapters.kitapdzenleTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgw_listele = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uyeekleesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdzenleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // k_adi
            // 
            this.k_adi.DataSource = this.uyeekleesBindingSource;
            this.k_adi.DisplayMember = "uye_adi";
            this.k_adi.FormattingEnabled = true;
            this.k_adi.Location = new System.Drawing.Point(77, 37);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(121, 21);
            this.k_adi.TabIndex = 0;
            // 
            // uyeekleesBindingSource
            // 
            this.uyeekleesBindingSource.DataMember = "uyeeklees";
            this.uyeekleesBindingSource.DataSource = this.kutuphaneOtomasyonDBDataSet;
            // 
            // kutuphaneOtomasyonDBDataSet
            // 
            this.kutuphaneOtomasyonDBDataSet.DataSetName = "KutuphaneOtomasyonDBDataSet";
            this.kutuphaneOtomasyonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeekleesTableAdapter
            // 
            this.uyeekleesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emanet_id);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_listele);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_kydt);
            this.groupBox1.Controls.Add(this.kitap_iade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.kitap_verilis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.raf_numara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kitp_adi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.k_adi);
            this.groupBox1.Location = new System.Drawing.Point(67, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Ekle";
            // 
            // emanet_id
            // 
            this.emanet_id.AutoSize = true;
            this.emanet_id.Location = new System.Drawing.Point(112, 16);
            this.emanet_id.Name = "emanet_id";
            this.emanet_id.Size = new System.Drawing.Size(13, 13);
            this.emanet_id.TabIndex = 15;
            this.emanet_id.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Emanet Kitap ID:";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(491, 132);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(99, 36);
            this.btn_listele.TabIndex = 13;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(336, 132);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(99, 36);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(193, 132);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(99, 36);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kydt
            // 
            this.btn_kydt.Location = new System.Drawing.Point(45, 132);
            this.btn_kydt.Name = "btn_kydt";
            this.btn_kydt.Size = new System.Drawing.Size(99, 36);
            this.btn_kydt.TabIndex = 10;
            this.btn_kydt.Text = "Kaydet";
            this.btn_kydt.UseVisualStyleBackColor = true;
            this.btn_kydt.Click += new System.EventHandler(this.btn_kydt_Click);
            // 
            // kitap_iade
            // 
            this.kitap_iade.Location = new System.Drawing.Point(425, 61);
            this.kitap_iade.Name = "kitap_iade";
            this.kitap_iade.Size = new System.Drawing.Size(200, 20);
            this.kitap_iade.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Kitap İade Tarihi:";
            // 
            // kitap_verilis
            // 
            this.kitap_verilis.Location = new System.Drawing.Point(425, 22);
            this.kitap_verilis.Name = "kitap_verilis";
            this.kitap_verilis.Size = new System.Drawing.Size(200, 20);
            this.kitap_verilis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Veriliş Tarihi:";
            // 
            // raf_numara
            // 
            this.raf_numara.Location = new System.Drawing.Point(86, 97);
            this.raf_numara.Name = "raf_numara";
            this.raf_numara.Size = new System.Drawing.Size(112, 20);
            this.raf_numara.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raf Numarası:";
            // 
            // kitp_adi
            // 
            this.kitp_adi.DataSource = this.kitapdzenleBindingSource;
            this.kitp_adi.DisplayMember = "kitap_adi";
            this.kitp_adi.FormattingEnabled = true;
            this.kitp_adi.Location = new System.Drawing.Point(77, 65);
            this.kitp_adi.Name = "kitp_adi";
            this.kitp_adi.Size = new System.Drawing.Size(121, 21);
            this.kitp_adi.TabIndex = 3;
            // 
            // kitapdzenleBindingSource
            // 
            this.kitapdzenleBindingSource.DataMember = "kitapdzenle";
            this.kitapdzenleBindingSource.DataSource = this.kutuphaneOtomasyonDBDataSet1;
            // 
            // kutuphaneOtomasyonDBDataSet1
            // 
            this.kutuphaneOtomasyonDBDataSet1.DataSetName = "KutuphaneOtomasyonDBDataSet1";
            this.kutuphaneOtomasyonDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Adı:";
            // 
            // kitapdzenleTableAdapter
            // 
            this.kitapdzenleTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lütfen emanetten dönen kitapları emanetler kısmından seçip siliniz!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kitapları Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgw_listele
            // 
            this.dgw_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_listele.Location = new System.Drawing.Point(67, 203);
            this.dgw_listele.Name = "dgw_listele";
            this.dgw_listele.Size = new System.Drawing.Size(673, 150);
            this.dgw_listele.TabIndex = 9;
            this.dgw_listele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_listele_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(645, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lütfen emanet verilen kitapları kaydettikten sonra, kitapları düzenle kısmından s" +
    "toklardan kaldırınız!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(581, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tekrar yerleştireceğiniz raf numarasına göre kitapları düzenle kısmından tekrar e" +
    "kleyiniz! ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kütüphane Görevlisinin Dikkatine!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Emanet listesini sürekli takip ediniz!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(257, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(509, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Emanetten dönmeyen kitaplar hakkında tarihlerine göre yasal işlem başlatınız!";
            // 
            // emanetkitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgw_listele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "emanetkitap";
            this.Text = "Emanet Kitap";
            this.Load += new System.EventHandler(this.emanetkitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeekleesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdzenleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KutuphaneOtomasyonDBDataSet kutuphaneOtomasyonDBDataSet;
        private System.Windows.Forms.BindingSource uyeekleesBindingSource;
        private KutuphaneOtomasyonDBDataSetTableAdapters.uyeekleesTableAdapter uyeekleesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KutuphaneOtomasyonDBDataSet1 kutuphaneOtomasyonDBDataSet1;
        private System.Windows.Forms.BindingSource kitapdzenleBindingSource;
        private KutuphaneOtomasyonDBDataSet1TableAdapters.kitapdzenleTableAdapter kitapdzenleTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgw_listele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kydt;
        public System.Windows.Forms.TextBox raf_numara;
        public System.Windows.Forms.DateTimePicker kitap_iade;
        public System.Windows.Forms.DateTimePicker kitap_verilis;
        public System.Windows.Forms.ComboBox k_adi;
        public System.Windows.Forms.ComboBox kitp_adi;
        private System.Windows.Forms.Label emanet_id;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_sil;
    }
}