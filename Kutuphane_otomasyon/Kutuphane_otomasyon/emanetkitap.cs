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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane_otomasyon
{
    public partial class emanetkitap : Form
    {
        public emanetkitap()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonDBEntities1 db = new KutuphaneOtomasyonDBEntities1();
        private void emanetkitap_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneOtomasyonDBDataSet1.kitapdzenle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapdzenleTableAdapter.Fill(this.kutuphaneOtomasyonDBDataSet1.kitapdzenle);
            // TODO: Bu kod satırı 'kutuphaneOtomasyonDBDataSet.uyeeklees' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyeekleesTableAdapter.Fill(this.kutuphaneOtomasyonDBDataSet.uyeeklees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapdznle kitapdznle = new kitapdznle();
            kitapdznle.Show();

        }

        public void emanetkitaplistele()
        {

            dgw_listele.DataSource = db.emanetkitaplar.ToList();
        }

        private void btn_kydt_Click(object sender, EventArgs e)
        {
            emanetkitaplar emanetkitap = new emanetkitaplar();
            emanetkitap.emanetuyeadi = k_adi.Text;
            emanetkitap.emanetkitadi = kitp_adi.Text;
            emanetkitap.emanetraf = raf_numara.Text;
            emanetkitap.emanet_Tarihi = DateTime.Parse(kitap_verilis.Text);
            emanetkitap.iade_Tarihi = DateTime.Parse(kitap_iade.Text);
            db.emanetkitaplar.Add(emanetkitap);
            db.SaveChanges();
            MessageBox.Show("Yeni Emanet Kitap Eklendi");
            emanetkitaplistele();



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(emanet_id.Text);
            
            var sil = db.emanetkitaplar.FirstOrDefault(em => em.emanetkitid == id);
            if (sil != null) { 
            db.emanetkitaplar.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Emanet Kitap Silindi!");
            emanetkitaplistele();
            }

        }
    

        private void btn_listele_Click(object sender, EventArgs e)
        {
            emanetkitaplistele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(emanet_id.Text);
            var guncelle = db.emanetkitaplar.FirstOrDefault(em => em.emanetkitid == id);
            guncelle.emanetuyeadi = k_adi.Text;
            guncelle.emanetkitadi = kitp_adi.Text;
            guncelle.emanetraf = raf_numara.Text;
            guncelle.emanet_Tarihi = DateTime.Parse(kitap_verilis.Text);
            guncelle.iade_Tarihi = DateTime.Parse(kitap_iade.Text);
            MessageBox.Show("Emanet kitap güncellendi.");
            emanetkitaplistele();
            db.SaveChanges();

        }

        private void dgw_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emanet_id.Text = dgw_listele.Rows[e.RowIndex].Cells[0].Value.ToString();
            k_adi.Text = dgw_listele.Rows[e.RowIndex].Cells[1].Value.ToString();
            kitp_adi.Text = dgw_listele.Rows[e.RowIndex].Cells[2].Value.ToString();
            raf_numara.Text = dgw_listele.Rows[e.RowIndex].Cells[3].Value.ToString();
            kitap_verilis.Text = dgw_listele.Rows[e.RowIndex].Cells[4].Value.ToString();
            kitap_iade.Text = dgw_listele.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }
    }

}
