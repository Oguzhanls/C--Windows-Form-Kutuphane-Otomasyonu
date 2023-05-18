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
    public partial class kutuphaneemanetlist : Form
    {
        public kutuphaneemanetlist()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonDBEntities1 db = new KutuphaneOtomasyonDBEntities1();

        public void emanetkitaplistele()
        {

            dgw_emanet.DataSource = db.emanetkitaplar.ToList();
        }

        private void txt_ara_Click(object sender, EventArgs e)
        {
            string aramaText =txt_emanetara.Text;
            var sonuc = db.emanetkitaplar.Where(k => k.emanetkitadi.Contains(aramaText)).ToList();
            if (sonuc.Count > 0)
            {
                dgw_emanet.DataSource = sonuc;
                MessageBox.Show("Bulundu");
            }
            else
            {
                dgw_emanet.DataSource = null;
                MessageBox.Show("Lütfen Tarihlere Göre Gelmeyen Kitaplara Üye Hakkında Yasal İşlem Başlatını!", "Kitap Bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanetkitap emanet = new emanetkitap();
            emanet.Show();
        }

        private void kutuphaneemanetlist_Load(object sender, EventArgs e)
        {
            emanetkitaplistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Eklenecektir. Medipol Üniversitesi YBS Olarak Çalışıyoruz :)", "Özellik Devre Dışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
