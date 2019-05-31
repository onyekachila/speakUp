namespace SpeakUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToMOdel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "String");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "String", c => c.String());
        }
    }
}
