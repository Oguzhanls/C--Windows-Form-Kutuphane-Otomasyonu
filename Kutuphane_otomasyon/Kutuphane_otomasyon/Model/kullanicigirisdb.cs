using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_otomasyon.Model
{
    public class kullanicigirisdb
    {
        [Key]
        public int Id { get; set; }
        public string kullanici_adi { get; set; }
        public string kullanici_sifre { get; set; }
    }

}
