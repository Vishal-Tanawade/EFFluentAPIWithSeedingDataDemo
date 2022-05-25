using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFluentAPIWithSeedingDataDemo
{
    internal class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=EmployeeSkillConnnectionString")
        {

        }


        public DbSet<ClsEmployee> tblEmployees { get; set; }
        public DbSet<ClsSkill> tblSkills { get; set; }
    }
}
