namespace Kutuphane_otomasyon
{
    partial class kayit_ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_ol));
            this.kyt_adi = new System.Windows.Forms.Label();
            this.kyt_sifre = new System.Windows.Forms.Label();
            this.btn_kytmm = new System.Windows.Forms.Button();
            this.kytad_Text = new System.Windows.Forms.TextBox();
            this.kytsifre_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kyt_adi
            // 
            this.kyt_adi.AutoSize = true;
            this.kyt_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kyt_adi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kyt_adi.Location = new System.Drawing.Point(27, 194);
            this.kyt_adi.Name = "kyt_adi";
            this.kyt_adi.Size = new System.Drawing.Size(197, 24);
            this.kyt_adi.TabIndex = 1;
            this.kyt_adi.Text = "Kullanıcı Adı Giriniz:";
            // 
            // kyt_sifre
            // 
            this.kyt_sifre.AutoSize = true;
            this.kyt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kyt_sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kyt_sifre.Location = new System.Drawing.Point(92, 239);
            this.kyt_sifre.Name = "kyt_sifre";
            this.kyt_sifre.Size = new System.Drawing.Size(123, 24);
            this.kyt_sifre.TabIndex = 3;
            this.kyt_sifre.Text = "Şifre Giriniz:";
            // 
            // btn_kytmm
            // 
            this.btn_kytmm.Location = new System.Drawing.Point(313, 299);
            this.btn_kytmm.Name = "btn_kytmm";
            this.btn_kytmm.Size = new System.Drawing.Size(90, 35);
            this.btn_kytmm.TabIndex = 6;
            this.btn_kytmm.Text = "Kayıt Ol";
            this.btn_kytmm.UseVisualStyleBackColor = true;
            this.btn_kytmm.Click += new System.EventHandler(this.btn_kytmm_Click);
            // 
            // kytad_Text
            // 
            this.kytad_Text.Location = new System.Drawing.Point(230, 198);
            this.kytad_Text.Name = "kytad_Text";
            this.kytad_Text.Size = new System.Drawing.Size(173, 20);
            this.kytad_Text.TabIndex = 7;
            // 
            // kytsifre_text
            // 
            this.kytsifre_text.Location = new System.Drawing.Point(230, 243);
            this.kytsifre_text.Name = "kytsifre_text";
            this.kytsifre_text.PasswordChar = '*';
            this.kytsifre_text.Size = new System.Drawing.Size(173, 20);
            this.kytsifre_text.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane_otomasyon.Properties.Resources._1160865;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(157, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 118);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kayit_ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(446, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kytsifre_text);
            this.Controls.Add(this.kytad_Text);
            this.Controls.Add(this.btn_kytmm);
            this.Controls.Add(this.kyt_sifre);
            this.Controls.Add(this.kyt_adi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayit_ol";
            this.Text = "Kayıt Olunuz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kyt_adi;
        private System.Windows.Forms.Label kyt_sifre;
        private System.Windows.Forms.Button btn_kytmm;
        private System.Windows.Forms.TextBox kytad_Text;
        private System.Windows.Forms.TextBox kytsifre_text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}