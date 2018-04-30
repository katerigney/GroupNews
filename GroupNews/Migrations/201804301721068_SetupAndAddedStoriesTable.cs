namespace GroupNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetupAndAddedStoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Headline = c.String(),
                        BodyContent = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stories");
        }
    }
}
