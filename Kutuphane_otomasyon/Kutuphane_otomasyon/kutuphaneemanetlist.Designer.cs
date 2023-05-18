namespace Kutuphane_otomasyon
{
    partial class kutuphaneemanetlist
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
            this.dgw_emanet = new System.Windows.Forms.DataGridView();
            this.txt_emanetara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_emanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_emanet
            // 
            this.dgw_emanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_emanet.Location = new System.Drawing.Point(12, 12);
            this.dgw_emanet.Name = "dgw_emanet";
            this.dgw_emanet.Size = new System.Drawing.Size(282, 601);
            this.dgw_emanet.TabIndex = 1;
            // 
            // txt_emanetara
            // 
            this.txt_emanetara.Location = new System.Drawing.Point(315, 28);
            this.txt_emanetara.Name = "txt_emanetara";
            this.txt_emanetara.Size = new System.Drawing.Size(198, 20);
            this.txt_emanetara.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emanet Kitap İsmi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Emanet Listesini Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Yazdır/PDF Dönüştür";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(438, 54);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(75, 23);
            this.txt_ara.TabIndex = 7;
            this.txt_ara.Text = "Ara";
            this.txt_ara.UseVisualStyleBackColor = true;
            this.txt_ara.Click += new System.EventHandler(this.txt_ara_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane_otomasyon.Properties.Resources.Arma_01_Eng;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(324, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 174);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // kutuphaneemanetlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_emanetara);
            this.Controls.Add(this.dgw_emanet);
            this.Name = "kutuphaneemanetlist";
            this.Text = "Kütüphane Emanet Listesi";
            this.Load += new System.EventHandler(this.kutuphaneemanetlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_emanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_emanet;
        private System.Windows.Forms.TextBox txt_emanetara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txt_ara;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}