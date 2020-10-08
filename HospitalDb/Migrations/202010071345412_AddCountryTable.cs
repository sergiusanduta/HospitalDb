namespace HospitalDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Patients", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Patients", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "IsActive");
            DropColumn("dbo.Patients", "DateCreated");
            DropTable("dbo.Countries");
        }
    }
}
