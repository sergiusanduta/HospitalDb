namespace HospitalDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LabLookups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LabName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PatientLabs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        LabId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LabLookups", t => t.LabId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.LabId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientLabs", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientLabs", "LabId", "dbo.LabLookups");
            DropIndex("dbo.PatientLabs", new[] { "LabId" });
            DropIndex("dbo.PatientLabs", new[] { "PatientId" });
            DropTable("dbo.Patients");
            DropTable("dbo.PatientLabs");
            DropTable("dbo.LabLookups");
        }
    }
}
