namespace Kutuphane_otomasyon
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.k_adi = new System.Windows.Forms.Label();
            this.kadi_text = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.giris_yap = new System.Windows.Forms.Button();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // k_adi
            // 
            this.k_adi.AutoSize = true;
            this.k_adi.BackColor = System.Drawing.Color.Transparent;
            this.k_adi.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_adi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.k_adi.Location = new System.Drawing.Point(243, 134);
            this.k_adi.Name = "k_adi";
            this.k_adi.Size = new System.Drawing.Size(158, 21);
            this.k_adi.TabIndex = 0;
            this.k_adi.Text = "Kullanici Adi:";
            // 
            // kadi_text
            // 
            this.kadi_text.Location = new System.Drawing.Point(408, 134);
            this.kadi_text.Name = "kadi_text";
            this.kadi_text.Size = new System.Drawing.Size(162, 20);
            this.kadi_text.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(313, 178);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(72, 21);
            this.sifre.TabIndex = 2;
            this.sifre.Text = "Sifre:";
            // 
            // sifre_text
            // 
            this.sifre_text.Location = new System.Drawing.Point(408, 178);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.PasswordChar = '*';
            this.sifre_text.Size = new System.Drawing.Size(162, 20);
            this.sifre_text.TabIndex = 3;
            // 
            // giris_yap
            // 
            this.giris_yap.BackColor = System.Drawing.Color.Red;
            this.giris_yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giris_yap.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_yap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giris_yap.Location = new System.Drawing.Point(476, 240);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(94, 35);
            this.giris_yap.TabIndex = 4;
            this.giris_yap.Text = "Giris Yap";
            this.giris_yap.UseVisualStyleBackColor = false;
            this.giris_yap.Click += new System.EventHandler(this.giris_yap_Click);
            // 
            // btnkayıt
            // 
            this.btnkayıt.BackColor = System.Drawing.Color.Red;
            this.btnkayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayıt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkayıt.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnkayıt.Location = new System.Drawing.Point(590, 240);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(90, 35);
            this.btnkayıt.TabIndex = 5;
            this.btnkayıt.Text = "Kayit Ol";
            this.btnkayıt.UseVisualStyleBackColor = false;
            this.btnkayıt.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_otomasyon.Properties.Resources.desktop_wallpaper_old_books_backgrounds_old_library;
            this.ClientSize = new System.Drawing.Size(868, 345);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.giris_yap);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kadi_text);
            this.Controls.Add(this.k_adi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label k_adi;
        private System.Windows.Forms.TextBox kadi_text;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

