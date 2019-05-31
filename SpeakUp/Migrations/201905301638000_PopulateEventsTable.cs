namespace SpeakUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEventsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Talks(Name) Values('Inspiration')");
            Sql("INSERT INTO Talks(Name) Values('Politics')");
            Sql("INSERT INTO Talks(Name) Values('Religion')");
            Sql("INSERT INTO Talks(Name) Values('Entertainment')");
            
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Talks WHERE Id IN (1, 2, 3, 4')");
        }
    }
}
