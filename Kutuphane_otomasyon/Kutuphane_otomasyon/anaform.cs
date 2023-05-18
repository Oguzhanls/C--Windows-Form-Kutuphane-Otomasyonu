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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void ktp_dznle_Click(object sender, EventArgs e)
        {
            kitapdznle kitapdznle = new kitapdznle();
            kitapdznle.Show();
        }

        private void uyeleri_dznle_Click(object sender, EventArgs e)
        {
            uyeekle uyeler = new uyeekle();
            uyeler.Show();
        }

        private void emanet_dznle_Click(object sender, EventArgs e)
        {
            emanetkitap emanet = new emanetkitap();
            emanet.Show();
        }

        private void uye_list_Click(object sender, EventArgs e)
        {
            Kütüphaneuyelistesi uyelistesi = new Kütüphaneuyelistesi();
            uyelistesi.Show();
        }

        private void emanet_list_Click(object sender, EventArgs e)
        {
            kutuphaneemanetlist emanetliste = new kutuphaneemanetlist();
            emanetliste.Show();
        }

        private void mvct_listele_Click(object sender, EventArgs e)
        {
            kitaplistele kitaplisteles= new kitaplistele();
            kitaplisteles.Show();
        }
    }
}
