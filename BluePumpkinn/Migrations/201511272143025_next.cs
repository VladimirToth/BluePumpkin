namespace BluePumpkinn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class next : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Files", new[] { "User_Id" });
            AddColumn("dbo.AspNetUsers", "Photo", c => c.Binary());
            DropTable("dbo.Files");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        ApplicationUserId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FileId);
            
            DropColumn("dbo.AspNetUsers", "Photo");
            CreateIndex("dbo.Files", "User_Id");
            AddForeignKey("dbo.Files", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
