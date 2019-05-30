namespace SpeakUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedEventTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Venue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Venue");
        }
    }
}
