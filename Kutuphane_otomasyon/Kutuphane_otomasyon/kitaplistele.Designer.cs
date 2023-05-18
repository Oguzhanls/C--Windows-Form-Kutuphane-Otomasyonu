namespace Kutuphane_otomasyon
{
    partial class kitaplistele
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
            this.kitaplist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitaplist
            // 
            this.kitaplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplist.Location = new System.Drawing.Point(12, 12);
            this.kitaplist.Name = "kitaplist";
            this.kitaplist.Size = new System.Drawing.Size(282, 601);
            this.kitaplist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İsmini Giriniz:";
            // 
            // txt_kitp
            // 
            this.txt_kitp.Location = new System.Drawing.Point(315, 28);
            this.txt_kitp.Name = "txt_kitp";
            this.txt_kitp.Size = new System.Drawing.Size(198, 20);
            this.txt_kitp.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kitapları Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Yazdır/PDF Dönüştür";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(438, 54);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(75, 23);
            this.txt_ara.TabIndex = 8;
            this.txt_ara.Text = "Ara";
            this.txt_ara.UseVisualStyleBackColor = true;
            this.txt_ara.Click += new System.EventHandler(this.txt_ara_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane_otomasyon.Properties.Resources.Arma_01_Eng;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(327, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 174);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kitaplistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_kitp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitaplist);
            this.Name = "kitaplistele";
            this.Text = "Kütüphanede Bulunan Tüm Kitaplar";
            this.Load += new System.EventHandler(this.kitaplistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kitaplist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txt_ara;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}