namespace ArtistDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Picture = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Nationality = c.String(nullable: false, maxLength: 30),
                        ArtStyle = c.String(),
                        Info = c.String(),
                        Rating = c.String(maxLength: 5),
                        Artwork1 = c.String(),
                        Artwork2 = c.String(),
                        Artwork3 = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Artworks",
                c => new
                    {
                        ArtworkID = c.Int(nullable: false, identity: true),
                        ArtistID = c.Int(nullable: false),
                        Name = c.String(maxLength: 60),
                        ArtistName = c.String(),
                        Picture = c.String(nullable: false),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.ArtworkID)
                .ForeignKey("dbo.Artists", t => t.ArtistID, cascadeDelete: true)
                .Index(t => t.ArtistID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artworks", "ArtistID", "dbo.Artists");
            DropIndex("dbo.Artworks", new[] { "ArtistID" });
            DropTable("dbo.Artworks");
            DropTable("dbo.Artists");
        }
    }
}
