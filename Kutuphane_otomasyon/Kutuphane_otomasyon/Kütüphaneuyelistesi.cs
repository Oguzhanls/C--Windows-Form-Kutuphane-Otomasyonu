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
    public partial class Kütüphaneuyelistesi : Form
    {
        public Kütüphaneuyelistesi()
        {
            InitializeComponent();
        }

        private void Kütüphaneuyelistesi_Load(object sender, EventArgs e)
        {
            uyelistele();
        }
        KutuphaneOtomasyonDB db = new KutuphaneOtomasyonDB();
        public void uyelistele()
        {

            dgw_uyelist.DataSource = db.uyeeklees.ToList();
        }

        private void txt_ara_Click(object sender, EventArgs e)
        {

            string aramaText = txt_adiara.Text;
            var sonuc = db.uyeeklees.Where(k => k.uye_adi.Contains(aramaText)).ToList();
            if (sonuc.Count > 0)
            {
                dgw_uyelist.DataSource = sonuc;
                MessageBox.Show("Üye Bulundu");
            }
            else
            {
                dgw_uyelist.DataSource = null;
                MessageBox.Show("Üye Bulunamadı");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeekle uyeler = new uyeekle();
            uyeler.Show();
        }

        private void dgw_uyelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Özellik Yakında Eklenecektir. Medipol Üniversitesi YBS Olarak Çalışıyoruz :)", "Özellik Devre Dışı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

