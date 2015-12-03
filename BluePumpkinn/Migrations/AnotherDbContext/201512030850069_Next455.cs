namespace BluePumpkinn.Migrations.AnotherDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Next455 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventParticipantID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "EventParticipantID");
        }
    }
}
