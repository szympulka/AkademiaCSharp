namespace EkaNetAppCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInfoCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        AccountNumber = c.Long(nullable: false),
                        Balance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInfoes");
        }
    }
}
