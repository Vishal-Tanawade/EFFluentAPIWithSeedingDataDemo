namespace EFFluentAPIWithSeedingDataDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFFluentAPIWithSeedingDataDemo.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFFluentAPIWithSeedingDataDemo.AppDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.tblEmployees.AddOrUpdate(
                      new ClsEmployee { EmpID = 1, FirstName = "Aaron", LastName = "Hawkins", Password = "arron@123", CellNumber = "(660) 663-4518", Email = "aron.hawkins@aol.com" },
                       new ClsEmployee { EmpID = 2, FirstName = "Hedy", LastName = "Greene", Password = "hedy@123", CellNumber = "(608) 265-2215", Email = "hedy.greene@aol.com" },
                       new ClsEmployee { EmpID = 3, FirstName = "Melvin", LastName = "Porter", Password = "melvin@123", CellNumber = "(959) 119-8364", Email = "melvin.porter@aol.com" }
                      );

            context.tblSkills.AddOrUpdate(
            new ClsSkill { SkillId = 1, EmpID = 1, SkillName = "Microsoft Office Suite", Role = "Business Analyst", ExperienceInYears = 2 },
            new ClsSkill { SkillId = 2, EmpID = 1, SkillName = "Testing", Role = "Developer", ExperienceInYears = 3 },
            new ClsSkill { SkillId = 3, EmpID = 1, SkillName = "Stakeholder Management", Role = "Project Lead", ExperienceInYears = 4 }
            );

        }
    }
}
