namespace BluePumpkinn.Migrations.AnotherDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Next45 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "EventParticipantID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventParticipantID", c => c.Int(nullable: false));
        }
    }
}
