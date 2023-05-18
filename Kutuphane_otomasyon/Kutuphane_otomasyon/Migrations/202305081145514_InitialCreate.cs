namespace Kutuphane_otomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.kullanicigirisdb",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    kullanici_adi = c.String(),
                    kullanici_sifre = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.kullanicigirisdb");

        }
    }
}
