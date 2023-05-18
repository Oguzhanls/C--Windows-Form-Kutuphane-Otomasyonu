using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_otomasyon.Model
{
    public class uyeeklee
    {
        [Key]
        public int uye_id { get; set; }
        public string uye_tc { get; set; }
        public string uye_adi { get; set; }
        public string uye_soyadi { get; set; }
        public string uye_tel { get; set; }
        public Nullable<System.DateTime> kayit_Tarihi { get; set; }
        public string uye_mail { get; set; }
        public string uye_adres { get; set; }


    }
}
