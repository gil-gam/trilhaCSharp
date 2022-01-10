namespace MvcMovie.Migrations.MovieDBContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        ReleaseDate = c.DateTime(nullable: false),
                        Director = c.String(maxLength: 60),
                        Gross = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.Double(nullable: false),
                        GenreID = c.Int(nullable: false),
                        ImageFile = c.Binary(),
                        ImageMimeType = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Usuario = c.String(),
                        Operacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropTable("dbo.Logs");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
