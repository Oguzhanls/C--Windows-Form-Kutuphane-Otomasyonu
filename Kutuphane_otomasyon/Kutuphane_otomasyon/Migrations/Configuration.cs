namespace Kutuphane_otomasyon.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kutuphane_otomasyon.Model.KutuphaneOtomasyonDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(Kutuphane_otomasyon.Model.KutuphaneOtomasyonDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
