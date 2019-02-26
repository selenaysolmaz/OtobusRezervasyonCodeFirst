namespace quiz1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yenitablo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusControlInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNumber = c.String(),
                        BeginTime = c.DateTime(nullable: false),
                        TotalMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusControlInfoes");
        }
    }
}
