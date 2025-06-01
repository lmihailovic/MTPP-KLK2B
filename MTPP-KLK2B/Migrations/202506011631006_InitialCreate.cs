namespace MTPP_KLK2B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pitanjes",
                c => new
                    {
                        IdPitanja = c.Int(nullable: false, identity: true),
                        TekstPitanja = c.String(nullable: false, maxLength: 200),
                        IdProvereZnanja = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPitanja)
                .ForeignKey("dbo.ProveraZnanjas", t => t.IdProvereZnanja, cascadeDelete: true)
                .Index(t => t.IdProvereZnanja);
            
            CreateTable(
                "dbo.ProveraZnanjas",
                c => new
                    {
                        IdProvereZnanja = c.Int(nullable: false, identity: true),
                        NazivProvere = c.String(nullable: false, maxLength: 40),
                        GodinaProvere = c.DateTime(nullable: false),
                        TrajanjeProvere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProvereZnanja);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pitanjes", "IdProvereZnanja", "dbo.ProveraZnanjas");
            DropIndex("dbo.Pitanjes", new[] { "IdProvereZnanja" });
            DropTable("dbo.ProveraZnanjas");
            DropTable("dbo.Pitanjes");
        }
    }
}
