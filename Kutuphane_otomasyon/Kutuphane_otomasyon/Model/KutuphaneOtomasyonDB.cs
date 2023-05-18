using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_otomasyon.Model
{
    public class KutuphaneOtomasyonDB : DbContext
    {
        internal static object kitapdzenle;

        public DbSet<kullanicigirisdb> Kullanicigirisdbs { get; set; }
        public DbSet<uyeeklee> uyeeklees { get; set; }
        

    }
     

}
