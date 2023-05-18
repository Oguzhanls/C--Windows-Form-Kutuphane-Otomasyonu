using Kutuphane_otomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_otomasyon
{
    public partial class kayit_ol : Form
    {
        public kayit_ol()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonDB context = new KutuphaneOtomasyonDB();
        private void btn_kytmm_Click(object sender, EventArgs e)
        {
            kullanicigirisdb kayit = new kullanicigirisdb();
            kayit.kullanici_adi = kytad_Text.Text;
            kayit.kullanici_sifre = kytsifre_text.Text;
            context.Kullanicigirisdbs.Add(kayit);
            context.SaveChanges();
            MessageBox.Show("Kullanıcı Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            giris giris = new giris();
            giris.Show();
            giris.Hide();


        }

        
    }
}
