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
    public partial class kitapdznle : Form
    {
        KutuphaneOtomasyonDBEntities db = new KutuphaneOtomasyonDBEntities();
        public kitapdznle()
        {
            InitializeComponent();
        }

        private void kitapdznle_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }
        public void kitaplistele()
        {

            dgwkitaplar.DataSource = db.kitapdzenle.ToList();
        }

        private void kitap_kaydt_Click(object sender, EventArgs e)
        {

            kitapdzenle ekle = new kitapdzenle();
            ekle.kitap_adi = kitp_adi.Text;
            ekle.kitap_yazari = kitp_yzr.Text;
            ekle.yayin_evi = yayinevi_adi.Text;
            ekle.b_Tarihi = DateTime.Parse(basim_tarih.Text);
            ekle.kitap_turu = tur_cmb.Text;
            ekle.kitap_raf = kitap_raf.Text;

            db.kitapdzenle.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yeni Kitap Eklendi");
            kitaplistele();


        }

        private void kitap_sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl_id.Text);
            using (var db = new KutuphaneOtomasyonDBEntities())
            {

                var kitap = db.kitapdzenle.FirstOrDefault(k => k.kitap_id == id);
                if (kitap != null)
                {
                    db.kitapdzenle.Remove(kitap);
                    db.SaveChanges();
                    MessageBox.Show("Kitap silindi.");
                    kitaplistele();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kitap_listele_Click(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void dgwkitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dgwkitaplar.Rows[e.RowIndex].Cells[0].Value.ToString();
            kitp_adi.Text = dgwkitaplar.Rows[e.RowIndex].Cells[1].Value.ToString();
            kitp_yzr.Text = dgwkitaplar.Rows[e.RowIndex].Cells[2].Value.ToString();
            yayinevi_adi.Text = dgwkitaplar.Rows[e.RowIndex].Cells[3].Value.ToString();
            basim_tarih.Text= dgwkitaplar.Rows[e.RowIndex].Cells[4].Value.ToString();
            tur_cmb.Text = dgwkitaplar.Rows[e.RowIndex].Cells[5].Value.ToString();
            kitap_raf.Text = dgwkitaplar.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void kitap_guncel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl_id.Text);
           
                var kitap_guncelle = db.kitapdzenle.FirstOrDefault(k => k.kitap_id == id);

               
                    kitap_guncelle.kitap_adi = kitp_adi.Text;
                    kitap_guncelle.kitap_yazari = kitp_yzr.Text;
                    kitap_guncelle.yayin_evi = yayinevi_adi.Text;
                    kitap_guncelle.b_Tarihi= DateTime.Parse(basim_tarih.Text);
                    kitap_guncelle.kitap_turu = tur_cmb.Text;
                    kitap_guncelle.kitap_raf = kitap_raf.Text;
                    db.SaveChanges();
                    MessageBox.Show("Kitap güncellendi.");
                    kitaplistele();




        }
    }
}
