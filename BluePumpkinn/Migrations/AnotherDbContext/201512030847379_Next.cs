namespace BluePumpkinn.Migrations.AnotherDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Next : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventParticipant_ID", "dbo.EventParticipants");
            DropIndex("dbo.Events", new[] { "EventParticipant_ID" });
            CreateTable(
                "dbo.EventParticipantEvents",
                c => new
                    {
                        EventParticipant_ID = c.Int(nullable: false),
                        Event_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventParticipant_ID, t.Event_ID })
                .ForeignKey("dbo.EventParticipants", t => t.EventParticipant_ID, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_ID, cascadeDelete: true)
                .Index(t => t.EventParticipant_ID)
                .Index(t => t.Event_ID);
            
            DropColumn("dbo.Events", "EventParticipant_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventParticipant_ID", c => c.Int());
            DropForeignKey("dbo.EventParticipantEvents", "Event_ID", "dbo.Events");
            DropForeignKey("dbo.EventParticipantEvents", "EventParticipant_ID", "dbo.EventParticipants");
            DropIndex("dbo.EventParticipantEvents", new[] { "Event_ID" });
            DropIndex("dbo.EventParticipantEvents", new[] { "EventParticipant_ID" });
            DropTable("dbo.EventParticipantEvents");
            CreateIndex("dbo.Events", "EventParticipant_ID");
            AddForeignKey("dbo.Events", "EventParticipant_ID", "dbo.EventParticipants", "ID");
        }
    }
}
