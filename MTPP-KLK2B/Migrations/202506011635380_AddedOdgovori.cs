namespace MTPP_KLK2B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOdgovori : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Odgovors",
                c => new
                    {
                        IdOdgovora = c.Int(nullable: false, identity: true),
                        TekstOdgovora = c.String(nullable: false, maxLength: 200),
                        IdPitanja = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdOdgovora)
                .ForeignKey("dbo.Pitanjes", t => t.IdPitanja, cascadeDelete: true)
                .Index(t => t.IdPitanja);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Odgovors", "IdPitanja", "dbo.Pitanjes");
            DropIndex("dbo.Odgovors", new[] { "IdPitanja" });
            DropTable("dbo.Odgovors");
        }
    }
}
