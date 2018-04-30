namespace GroupNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stories", "UserID", "dbo.Users");
            DropIndex("dbo.Stories", new[] { "UserID" });
            AlterColumn("dbo.Stories", "UserID", c => c.Int());
            CreateIndex("dbo.Stories", "UserID");
            AddForeignKey("dbo.Stories", "UserID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stories", "UserID", "dbo.Users");
            DropIndex("dbo.Stories", new[] { "UserID" });
            AlterColumn("dbo.Stories", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Stories", "UserID");
            AddForeignKey("dbo.Stories", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
