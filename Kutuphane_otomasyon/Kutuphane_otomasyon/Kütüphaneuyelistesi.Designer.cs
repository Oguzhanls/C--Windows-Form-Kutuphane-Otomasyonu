namespace Kutuphane_otomasyon
{
    partial class Kütüphaneuyelistesi
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
            this.dgw_uyelist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adiara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uyelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_uyelist
            // 
            this.dgw_uyelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_uyelist.Location = new System.Drawing.Point(12, 12);
            this.dgw_uyelist.Name = "dgw_uyelist";
            this.dgw_uyelist.Size = new System.Drawing.Size(282, 601);
            this.dgw_uyelist.TabIndex = 1;
            this.dgw_uyelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_uyelist_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye İsmini Giriniz:";
            // 
            // txt_adiara
            // 
            this.txt_adiara.Location = new System.Drawing.Point(312, 28);
            this.txt_adiara.Name = "txt_adiara";
            this.txt_adiara.Size = new System.Drawing.Size(198, 20);
            this.txt_adiara.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Üye Listesini Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Yazdır/PDF Dönüştür";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(435, 54);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(75, 23);
            this.txt_ara.TabIndex = 6;
            this.txt_ara.Text = "Ara";
            this.txt_ara.UseVisualStyleBackColor = true;
            this.txt_ara.Click += new System.EventHandler(this.txt_ara_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane_otomasyon.Properties.Resources.Arma_01_Eng;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(324, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 174);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Kütüphaneuyelistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_adiara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_uyelist);
            this.Name = "Kütüphaneuyelistesi";
            this.Text = "Kütüphane Üye Listesi";
            this.Load += new System.EventHandler(this.Kütüphaneuyelistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uyelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_uyelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adiara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txt_ara;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}