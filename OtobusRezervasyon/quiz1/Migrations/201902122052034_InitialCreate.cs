namespace quiz1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNumber = c.String(nullable: false),
                        Name = c.String(),
                        SeatNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        IdentificationNumber = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TripPassengerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TripId = c.Int(nullable: false),
                        PassengerId = c.Int(nullable: false),
                        KoltukNo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .ForeignKey("dbo.Trips", t => t.TripId, cascadeDelete: true)
                .Index(t => t.TripId)
                .Index(t => t.PassengerId);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureTime = c.DateTime(nullable: false),
                        CityId = c.Int(nullable: false),
                        Bus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.Bus_Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.Bus_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripPassengerInfoes", "TripId", "dbo.Trips");
            DropForeignKey("dbo.Trips", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Trips", "Bus_Id", "dbo.Buses");
            DropForeignKey("dbo.TripPassengerInfoes", "PassengerId", "dbo.Passengers");
            DropIndex("dbo.Trips", new[] { "Bus_Id" });
            DropIndex("dbo.Trips", new[] { "CityId" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "PassengerId" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "TripId" });
            DropTable("dbo.Trips");
            DropTable("dbo.TripPassengerInfoes");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Buses");
        }
    }
}
