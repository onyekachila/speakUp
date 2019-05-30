namespace SpeakUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Speaker_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Events", "Talk_Id", "dbo.Talks");
            DropIndex("dbo.Events", new[] { "Speaker_Id" });
            DropIndex("dbo.Events", new[] { "Talk_Id" });
            AlterColumn("dbo.Events", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "Speaker_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Events", "Talk_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Talks", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Events", "Speaker_Id");
            CreateIndex("dbo.Events", "Talk_Id");
            AddForeignKey("dbo.Events", "Speaker_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "Talk_Id", "dbo.Talks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Talk_Id", "dbo.Talks");
            DropForeignKey("dbo.Events", "Speaker_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Talk_Id" });
            DropIndex("dbo.Events", new[] { "Speaker_Id" });
            AlterColumn("dbo.Talks", "Name", c => c.String());
            AlterColumn("dbo.Events", "Talk_Id", c => c.Int());
            AlterColumn("dbo.Events", "Speaker_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "Venue", c => c.String());
            CreateIndex("dbo.Events", "Talk_Id");
            CreateIndex("dbo.Events", "Speaker_Id");
            AddForeignKey("dbo.Events", "Talk_Id", "dbo.Talks", "Id");
            AddForeignKey("dbo.Events", "Speaker_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
