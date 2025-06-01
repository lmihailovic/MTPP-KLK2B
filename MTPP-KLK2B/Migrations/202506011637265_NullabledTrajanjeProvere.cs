namespace MTPP_KLK2B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullabledTrajanjeProvere : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProveraZnanjas", "TrajanjeProvere", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProveraZnanjas", "TrajanjeProvere", c => c.Int(nullable: false));
        }
    }
}
