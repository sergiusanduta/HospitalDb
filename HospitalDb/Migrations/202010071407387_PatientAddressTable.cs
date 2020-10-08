namespace HospitalDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        Street = c.String(),
                        Zip = c.String(),
                        State = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientAddresses", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientAddresses", "CountryId", "dbo.Countries");
            DropIndex("dbo.PatientAddresses", new[] { "CountryId" });
            DropIndex("dbo.PatientAddresses", new[] { "PatientId" });
            DropTable("dbo.PatientAddresses");
        }
    }
}
