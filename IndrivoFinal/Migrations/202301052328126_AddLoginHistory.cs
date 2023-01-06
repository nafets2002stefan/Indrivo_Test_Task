namespace IndrivoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoginHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        LoginTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginHistories");
        }
    }
}
