namespace BluePumpkinn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bezphoto : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Photo", c => c.Binary());
        }
    }
}
