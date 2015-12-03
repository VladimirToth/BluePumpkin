namespace BluePumpkinn.Migrations.AnotherDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventParticipants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.String(maxLength: 128),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserID)
                .Index(t => t.ApplicationUserID);
            
            AddColumn("dbo.Events", "EventParticipant_ID", c => c.Int());
            CreateIndex("dbo.Events", "EventParticipant_ID");
            AddForeignKey("dbo.Events", "EventParticipant_ID", "dbo.EventParticipants", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventParticipant_ID", "dbo.EventParticipants");
            DropForeignKey("dbo.EventParticipants", "ApplicationUserID", "dbo.AspNetUsers");
            DropIndex("dbo.EventParticipants", new[] { "ApplicationUserID" });
            DropIndex("dbo.Events", new[] { "EventParticipant_ID" });
            DropColumn("dbo.Events", "EventParticipant_ID");
            DropTable("dbo.EventParticipants");
        }
    }
}
