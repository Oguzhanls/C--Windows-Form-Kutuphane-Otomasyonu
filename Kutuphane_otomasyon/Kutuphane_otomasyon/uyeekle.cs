using Kutuphane_otomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_otomasyon
{
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonDB db = new KutuphaneOtomasyonDB();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void uyelistele()
        {

            dgwuyeler.DataSource = db.uyeeklees.ToList();
        }

        private void uye_kydt_Click(object sender, EventArgs e)
        {
            uyeeklee ekle = new uyeeklee();
            ekle.uye_tc = tckimlik_text.Text;
            ekle.uye_adi = isim_text.Text;
            ekle.uye_soyadi = soyisim_text.Text;
            ekle.uye_tel = telno_text.Text;
            ekle.kayit_Tarihi = DateTime.Parse(kyttarihi_text.Text);
            ekle.uye_mail = email_text.Text;
            ekle.uye_adres = adres_text.Text;
            db.uyeeklees.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yeni Üye Eklendi");
            uyelistele();

        }

        private void dgwuyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uye_id.Text = dgwuyeler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tckimlik_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[1].Value.ToString();
            isim_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[2].Value.ToString();
            soyisim_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[3].Value.ToString();
            telno_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[4].Value.ToString();
            kyttarihi_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[5].Value.ToString();
            email_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[6].Value.ToString();
            adres_text.Text = dgwuyeler.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void uye_listele_Click(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void uye_guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uye_id.Text);

            var uye_guncelle = db.uyeeklees.FirstOrDefault(u => u.uye_id == id);
            uye_guncelle.uye_tc = tckimlik_text.Text;
            uye_guncelle.uye_adi = isim_text.Text;
            uye_guncelle.uye_soyadi = soyisim_text.Text;
            uye_guncelle.uye_tel = telno_text.Text;
            uye_guncelle.kayit_Tarihi= DateTime.Parse(kyttarihi_text.Text);
            uye_guncelle.uye_mail = email_text.Text;
            uye_guncelle.uye_adres = adres_text.Text;
            db.SaveChanges();
            MessageBox.Show("Üye güncellendi.");
            uyelistele();


        }

        private void uye_sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uye_id.Text);
            using (var db = new KutuphaneOtomasyonDB())
            {
                var uyeler = db.uyeeklees.FirstOrDefault(u => u.uye_id == id);
                if (uyeler != null)
                {
                    db.uyeeklees.Remove(uyeler);
                    db.SaveChanges();
                    MessageBox.Show("Üye silindi.");
                    uyelistele();
                }

            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tckimlik_text.Text = "";
            isim_text.Text = "";
            soyisim_text.Text = "";
            telno_text.Text = "";
            email_text.Text = "";
            adres_text.Text = "";
        }

    }
}
