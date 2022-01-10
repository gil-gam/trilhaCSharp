namespace MvcMovie.Migrations.MovieDBContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logging1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogInfoes",
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
            DropTable("dbo.LogInfoes");
        }
    }
}
