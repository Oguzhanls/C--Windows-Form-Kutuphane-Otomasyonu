namespace Kutuphane_otomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateuyeekleeTable : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.uyeeklees",
                c => new
                    {
                        uye_id = c.Int(nullable: false, identity: true),
                        uye_tc = c.String(),
                        uye_adi = c.String(),
                        uye_soyadi = c.String(),
                        uye_tel = c.String(),
                        kayit_Tarihi = c.DateTime(),
                        uye_mail = c.String(),
                        uye_adres = c.String(),
                    })
                .PrimaryKey(t => t.uye_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.uyeeklees");
            
        }
    }
}
