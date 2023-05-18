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
    public partial class kitaplistele : Form
    {
        public kitaplistele()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonDBEntities db = new KutuphaneOtomasyonDBEntities();
        private void kitaplistele_Load(object sender, EventArgs e)
        {
            kitaplists();
        }

        public void kitaplists() 
        {

            kitaplist.DataSource = db.kitapdzenle.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapdznle kitapdznle = new kitapdznle();
            kitapdznle.Show();
        }

        private void txt_ara_Click(object sender, EventArgs e)
        {
            string aramaText = txt_kitp.Text;
            var sonuc = db.kitapdzenle.Where(k => k.kitap_adi.Contains(aramaText)).ToList();
            if (sonuc.Count > 0)
            {
                kitaplist.DataSource = sonuc;
                MessageBox.Show("Bulundu");
            }
            else
            {
                kitaplist.DataSource = null;
                MessageBox.Show("Bulunamadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Eklenecektir. Medipol Üniversitesi YBS Olarak Çalışıyoruz :)", "Özellik Devre Dışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
