namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMovieGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        MovieGenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.MovieGenreID);
            
            AddColumn("dbo.Movies", "MovieGenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MovieGenreID");
            AddForeignKey("dbo.Movies", "MovieGenreID", "dbo.MovieGenres", "MovieGenreID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenreID", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenreID" });
            DropColumn("dbo.Movies", "MovieGenreID");
            DropTable("dbo.MovieGenres");
        }
    }
}
