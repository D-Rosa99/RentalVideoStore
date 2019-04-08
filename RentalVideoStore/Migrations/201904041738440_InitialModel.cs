namespace RentalVideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Classification = c.Int(nullable: false),
                        GenreId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId_Id)
                .Index(t => t.GenreId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId_Id" });
            DropTable("dbo.Videos");
            DropTable("dbo.Genres");
        }
    }
}
