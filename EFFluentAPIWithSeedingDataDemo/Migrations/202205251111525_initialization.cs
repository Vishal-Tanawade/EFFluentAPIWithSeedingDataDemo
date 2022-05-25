namespace EFFluentAPIWithSeedingDataDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClsEmployees",
                c => new
                    {
                        EmpID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CellNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID);
            
            CreateTable(
                "dbo.ClsSkills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        EmpID = c.Int(nullable: false),
                        SkillName = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        ExperienceInYears = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.ClsEmployees", t => t.EmpID, cascadeDelete: true)
                .Index(t => t.EmpID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClsSkills", "EmpID", "dbo.ClsEmployees");
            DropIndex("dbo.ClsSkills", new[] { "EmpID" });
            DropTable("dbo.ClsSkills");
            DropTable("dbo.ClsEmployees");
        }
    }
}
