namespace GroupNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRelationshipsBetweenTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stories", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Stories", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Stories", "UserID");
            CreateIndex("dbo.Stories", "CategoryID");
            AddForeignKey("dbo.Stories", "UserID", "dbo.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Stories", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stories", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Stories", "UserID", "dbo.Users");
            DropIndex("dbo.Stories", new[] { "CategoryID" });
            DropIndex("dbo.Stories", new[] { "UserID" });
            DropColumn("dbo.Stories", "CategoryID");
            DropColumn("dbo.Stories", "UserID");
        }
    }
}
