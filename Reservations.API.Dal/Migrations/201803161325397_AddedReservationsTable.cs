namespace Reservations.API.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReservationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuestAddresses",
                c => new
                    {
                        GuestAddressId = c.Int(nullable: false),
                        Address1 = c.String(nullable: false),
                        Address2 = c.String(),
                        City = c.String(nullable: false),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GuestAddressId)
                .ForeignKey("dbo.Guests", t => t.GuestAddressId)
                .Index(t => t.GuestAddressId);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GuestId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        HotelName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        GuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Guests", t => t.GuestId, cascadeDelete: true)
                .Index(t => t.GuestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuestAddresses", "GuestAddressId", "dbo.Guests");
            DropForeignKey("dbo.Reservations", "GuestId", "dbo.Guests");
            DropIndex("dbo.Reservations", new[] { "GuestId" });
            DropIndex("dbo.GuestAddresses", new[] { "GuestAddressId" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
            DropTable("dbo.GuestAddresses");
        }
    }
}
