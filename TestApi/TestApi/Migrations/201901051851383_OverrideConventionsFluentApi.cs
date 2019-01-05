namespace TestApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsFluentApi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 200));
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
