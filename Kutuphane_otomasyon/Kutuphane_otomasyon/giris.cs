using Kutuphane_otomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_otomasyon
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonDB context = new KutuphaneOtomasyonDB();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            /*using(KutuphaneOtomasyonDB context=new KutuphaneOtomasyonDB())
            {
                context.Database.Create(); // Database Mizi Kurduk
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit_ol kayit1 = new kayit_ol();
            
            kayit1.Show();
        }

        private void giris_yap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kadi_text.Text;
            string sifre = sifre_text.Text;

            using(var db=new KutuphaneOtomasyonDB())
            {
                var kullanicigirisdb = db.Kullanicigirisdbs.FirstOrDefault(k => k.kullanici_adi == kullaniciAdi && k.kullanici_sifre==sifre);
                if (kullanicigirisdb == null) {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı! Lütfen kayıt olunuz.");
                    return;
                }
                if (kullanicigirisdb.kullanici_sifre!=sifre && kullanicigirisdb.kullanici_adi!=kullaniciAdi) {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı! lütfen kayıt olunuz");
                    return;
                }
                if (kullanicigirisdb.kullanici_sifre == sifre && kullanicigirisdb.kullanici_adi == kullaniciAdi)
                {
                    MessageBox.Show("Hoşgeldin Admin!", "Başarıyla Giriş Yapıldı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    anaform anaform = new anaform();
                    anaform.Show();
                }


            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
