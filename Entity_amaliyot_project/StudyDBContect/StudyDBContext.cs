using Entity_amaliyot_project.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_amaliyot_project.StudyDBContect
{
    public class StudyDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Staff> Staffs { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server  = (localdb)\\MSSQLLocalDB;" +
                          "Database = Employe;" +
                          "Trusted_Connection = True";
            optionsBuilder.UseSqlServer(path);
        }
    }
}
